using Infokom.Inquisitio.Domain;
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
	public record CitizenFilter
	{
		[Display(Name = "Emri"), MaxLength(64)]
		public string GivenName { get; set; }

		[Display(Name = "Mbiemri"), MaxLength(64)]
		public string FamilyName { get; set; }

		[Display(Name = "Atësia"), MaxLength(64)]
		public string FatherName { get; set; }

		[Display(Name = "Amësia"), MaxLength(64)]
		public string MotherName { get; set; }

		[Display(Name = "Datelindja"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
		public DateOnly? BirthDate { get; set; }
	}
}
