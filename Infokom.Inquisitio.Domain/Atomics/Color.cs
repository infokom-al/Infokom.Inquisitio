using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Atomics
{
	public enum Color : int
	{
		[Display(Name = "Zezë")]
		Black = 0x000000,

		[Display(Name = "Blu E Errët")]
		DarkBlue = 0x00008B,

		[Display(Name = "Blu")]
		Blue = 0x0000FF,

		[Display(Name = "Jeshile E Errët")]
		DarkGreen = 0x006400,

		[Display(Name = "Jeshile")]
		Green = 0x008000,
		
		[Display(Name = "Kafe E Errët")]
		DarkBrown = 0x5C4033,

		[Display(Name = "Gri")]
		Gray = 0x808080,

		[Display(Name = "Gri E Errët")]
		DarkGray = 0x8B0000,

		[Display(Name = "Kuqe E Errët")]
		DarkRed = 0x8B0000,

		[Display(Name = "Verdhe E Errët")]
		DarkYellow = 0x8B8000,

		[Display(Name = "Jeshile E Hapur")]
		LightGreen = 0x90EE90,

		[Display(Name = "Violetë E Errët")]
		DarkViolet = 0x9400D3,

		[Display(Name = "Kafe")]
		Brown = 0xA52A2A,

		[Display(Name = "Blu E Hapur")]
		LightBlue = 0xADD8E6,

		[Display(Name = "Kafe E Hapur")]
		LightBrown = 0xC4A484,

		[Display(Name = "Violetë E Hapur")]
		LightViolet = 0xCF9FFF,

		[Display(Name = "Gri E Hapur")]
		LightGray = 0xD3D3D3,

		[Display(Name = "Violetë")]
		Violet = 0xEE82EE,

		[Display(Name = "Portokalli E Hapur")]
		LightOrange = 0xFDAA48,

		[Display(Name = "Kuqe")]
		Red = 0xFF0000,

		[Display(Name = "Kuqe E Hapur")]
		LightRed = 0xFF7F7F,

		[Display(Name = "Portokalli E Errët")]
		DarkOrange = 0xFF8C00,

		[Display(Name = "Portokalli")]
		Orange = 0xFFA500,

		[Display(Name = "Verdhë")]
		Yellow = 0xFFFF00,

		[Display(Name = "Verdhe E Hapur")]
		LightYellow = 0xFFFFE0,

		[Display(Name = "Bardhë")]
		White = 0xFFFFFF,
	}
}
