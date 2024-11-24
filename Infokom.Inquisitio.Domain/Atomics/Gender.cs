using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Atomics
{
	public enum Gender : byte
	{
		[Display(Name = "Mashkull")]
		Male,

		[Display(Name = "Femer")]
		Female
	}

	public static class Kinships
	{

		
		public static string GetName(int id) => data[id];

		private static Dictionary<int, string> data = new()
		{
			{ 1, "Kryefamiljar" },
			{ 2, "Bashkëshort / e" },
			{ 3, "Bir" },
			{ 4, "Bijë" },
			{ 5, "I adoptuar" },
			{ 6, "E reja" },
			{ 7, "Dhëndri" },
			{ 8, "Nusja e djalit të adaptuar" },
			{ 9, "Djali i gruas" },
			{ 10, "Vajza e gruas" },
			{ 11, "Djali i burrit" },
			{ 12, "Vajza e burrit" },
			{ 13, "E reja e gruas" },
			{ 14, "Bir i sjellë" },
			{ 15, "Bijë e sjelle" },
			{ 16, "Nip" },
			{ 17, "Mbesë" },
			{ 18, "Nipi i gruas" },
			{ 19, "Mbesa e gruas" },
			{ 20, "Djali i së resë" },
			{ 21, "Vajza i së resë" },
			{ 22, "Nusja e nipit" },
			{ 23, "Stërnip/e" },
			{ 24, "Djali i nipit" },
			{ 25, "Vajza e nipit" },
			{ 26, "Mbesa e djalit të gruas" },
			{ 27, "Gjysh/e" },
			{ 28, "I ati" },
			{ 29, "E ëma" },
			{ 30, "Vjehrri" },
			{ 31, "Vjehrra" },
			{ 32, "Vëllai" },
			{ 33, "Motra" },
			{ 34, "Njerk / a" },
			{ 35, "Djali i njerkës" },
			{ 36, "Vajza e njerkës" },
			{ 37, "Djali i vëllait" },
			{ 38, "Vajza e vëllait" },
			{ 39, "Kunat / a" },
			{ 40, "Xhaxhai" },
			{ 41, "Nusja e xhaxhait" },
			{ 42, "Hallë" },
			{ 43, "Dajë" },
			{ 44, "Teze" },
			{ 45, "Vjehrra e djalit" },
			{ 46, "Djali i xhaxhait" },
			{ 47, "Kushëri/ra" },
			{ 48, "Ilegal" },
			{ 49, "E panjohur" },
		};
	}
}
