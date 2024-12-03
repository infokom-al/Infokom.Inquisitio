using Infokom.Inquisitio.Domain;
using Infokom.Inquisitio.Domain.Atomics;
using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Application.FIlters.Registry
{
	public record CitizenSpecification : ISpecification<Citizen>
	{
		[Display(GroupName = "Emri", Name = "Emër"), MaxLength(64)]
		public string GivenName { get; set; }

		[Display(GroupName = "Emri", Name = "Mbiemër"), MaxLength(64)]
		public string FamilyName { get; set; }

		[Display(GroupName = "Emri", Name = "Atësi"), MaxLength(64)]
		public string FatherName { get; set; }

		[Display(GroupName = "Emri", Name = "Amësi"), MaxLength(64)]
		public string MotherName { get; set; }

		[Display(GroupName = "Lindja", Name = "Data"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
		public DateOnly? BirthDate { get; set; }

		public Expression<Func<Citizen, bool>> ToExpression() => x =>
			EF.Functions.Like(x.GivenName, (this.GivenName ?? "") + "%") &&
			EF.Functions.Like(x.FamilyName, (this.FamilyName ?? "") + "%") &&
			EF.Functions.Like(x.FatherName, (this.FatherName ?? "") + "%") &&
			EF.Functions.Like(x.MotherName, (this.MotherName ?? "") + "%") &&
			EF.Functions.DateDiffDay(x.BirthDate, this.BirthDate ?? x.BirthDate) == 0;
	}
}
