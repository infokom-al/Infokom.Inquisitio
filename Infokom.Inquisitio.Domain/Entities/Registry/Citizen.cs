using Infokom.Inquisitio.Domain.Atomics;

using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public partial class Citizen : IEquatable<Citizen>, IComparable<Citizen>
	{

		[Key]
		public long Id { get; set; }

		[StringLength(10, MinimumLength = 10)]
		public string Code { get; set; }

		[Required, MaxLength(64)]
		public string Register { get; set; }

		[Required, MaxLength(256)]
		public string Address { get; set; }

		[Required, MaxLength(64)]
		public string GivenName { get; set; }

		[Required, MaxLength(64)]
		public string FamilyName { get; set; }

		[Required, MaxLength(64)]
		public string FatherName { get; set; }

		[Required, MaxLength(64)]
		public string MotherName { get; set; }

		public Gender Gender { get; set; }

		public DateOnly BirthDate { get; set; }

		[Required, MaxLength(64)]
		public string BirthPlace { get; set; }

		[Required, MaxLength(64)]
		public string District { get; set; }

		[Required, MaxLength(64)]
		public string Nationality { get; set; }

		public Marital Marital { get; set; }

		public int CompareTo(Citizen other) => this.ToString().CompareTo(other?.ToString());

		public override bool Equals(object obj) => this.Equals(obj as Citizen);
		public bool Equals(Citizen other) => other is not null && this.GetHashCode() == other.GetHashCode();
		public override int GetHashCode() => HashCode.Combine(this.GivenName, this.FamilyName, this.FatherName, this.MotherName, this.BirthDate, this.BirthPlace, this.Gender);
		public override string ToString() => $"{this.GivenName} {this.FatherName} {this.FamilyName}";
	}
}

