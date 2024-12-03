using Infokom.Inquisitio.Domain.Atomics;
using Infokom.Inquisitio.Domain.Entities.Registry;
using Infokom.Inquisitio.Domain.Records;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Infokom.Inquisitio.Application.FIlters.Registry
{
	public record SalarySpecification : ISpecification<Salary>
	{
		public record EmployerFilter : ISpecification<Salary>
		{
			[Display(Name = "NIPT")]
			public string Code { get; set; }

			[Display(Name = "Emri Tregtar")]
			public string Name { get; set; }

			public Expression<Func<Salary, bool>> ToExpression() => x =>
				EF.Functions.Like(x.Employer.Code, $"{this.Code ?? string.Empty}%") &&
				EF.Functions.Like(x.Employer.Name, $"%{this.Name ?? string.Empty}%");
		}


		public record EmployeeFilter : ISpecification<Salary>
		{
			[Display(Name = "NISH")]
			public string Code { get; set; }

			[Display(Name = "Emri")]
			public string GivenName { get; set; }

			[Display(Name = "Mbiemri")]
			public string FamilyName { get; set; }

			public Expression<Func<Salary, bool>> ToExpression() => x =>
				EF.Functions.Like(x.Employee.Code, $"{this.Code ?? string.Empty}%") &&
				EF.Functions.Like(x.Employee.GivenName, $"%{this.GivenName ?? string.Empty}%") &&
				EF.Functions.Like(x.Employee.FamilyName, $"%{this.FamilyName ?? string.Empty}%");
		}

		public int? Year { get; set; }
		public Month? Month { get; set; }
		public EmployerFilter Employer {  get; set; } = new EmployerFilter();
		public EmployeeFilter Employee { get; set; } = new EmployeeFilter();

		//public Expression<Func<Salary, bool>> ToExpression() => x =>
		//	(this.Year == null || x.Year == this.Year) &&
		//	(this.Month == null || x.Month == this.Month) &&
		//	EF.Functions.Like(x.Employee.Code, $"{this.Employee.Code ?? string.Empty}%") &&
		//	EF.Functions.Like(x.Employee.GivenName, $"%{this.Employee.GivenName ?? string.Empty}%") &&
		//	EF.Functions.Like(x.Employee.FamilyName, $"%{this.Employee.FamilyName ?? string.Empty}%") &&
		//	EF.Functions.Like(x.Employer.Code, $"{this.Employer.Code ?? string.Empty}%") &&
		//	EF.Functions.Like(x.Employer.Name, $"%{this.Employer.Name ?? string.Empty}%");


		public Expression<Func<Salary, bool>> ToExpression()
		{
			
			return x =>
				(this.Year == null || x.Year == this.Year) &&
				(this.Month == null || x.Month == this.Month) &&
				EF.Functions.Like(x.Employee.Code, $"{this.Employee.Code ?? string.Empty}%") &&
				EF.Functions.Like(x.Employee.GivenName, $"%{this.Employee.GivenName ?? string.Empty}%") &&
				EF.Functions.Like(x.Employee.FamilyName, $"%{this.Employee.FamilyName ?? string.Empty}%") &&
				EF.Functions.Like(x.Employer.Code, $"{this.Employer.Code ?? string.Empty}%") &&
				EF.Functions.Like(x.Employer.Name, $"%{this.Employer.Name ?? string.Empty}%");
		}
	}
}
