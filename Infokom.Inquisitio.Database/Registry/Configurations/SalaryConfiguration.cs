using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Inquisitio.Database.Registry.Configurations
{
	internal class SalaryConfiguration : IEntityTypeConfiguration<Salary>
	{
		public void Configure(EntityTypeBuilder<Salary> entity)
		{
			entity.ToTable("Salary", "Registry");


			entity.OwnsOne(x => x.Employer, owned =>
			{
				owned.Property(y => y.Code).HasColumnName("Employer.Code");
				owned.Property(y => y.Name).HasColumnName("Employer.Name");
				owned.Property(y => y.Type).HasColumnName("Employer.Type");
			});

			entity.OwnsOne(x => x.Employee, owned =>
			{
				owned.Property(y => y.Code).HasColumnName("Employee.Code");
				owned.Property(y => y.Name).HasColumnName("Employee.Name");
				owned.Property(y => y.GivenName).HasColumnName("Employee.GivenName");
				owned.Property(y => y.FamilyName).HasColumnName("Employee.FamilyName");
			});


			entity.HasKey(e => e.Id);
		}
	}
}
