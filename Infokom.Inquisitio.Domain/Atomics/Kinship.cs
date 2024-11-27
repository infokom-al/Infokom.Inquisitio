using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Atomics
{
	public enum Kinship : byte
	{
		[Display(Name = "")]
		None = 0,

		[Display(Name = "Kryefamiljar")]
		_1 = 1,

		[Display(Name = "Bashkëshort / e")]
		_2 = 2,

		[Display(Name = "Bir")]
		_3 = 3,

		[Display(Name = "Bijë")]
		_4 = 4,

		[Display(Name = "I adoptuar")]
		_5 = 5,

		[Display(Name = "E reja")]
		_6 = 6,

		[Display(Name = "Dhëndri")]
		_7 = 7,

		[Display(Name = "Nusja e djalit të adaptuar")]
		_8 = 8,

		[Display(Name = "Djali i gruas")]
		_9 = 9,

		[Display(Name = "Vajza e gruas")]
		_10 = 10,

		[Display(Name = "Djali i burrit")]
		_11 = 11,

		[Display(Name = "Vajza e burrit")]
		_12 = 12,

		[Display(Name = "E reja e gruas")]
		_13 = 13,

		[Display(Name = "Bir i sjellë")]
		_14 = 14,

		[Display(Name = "Bijë e sjelle")]
		_15 = 15,

		[Display(Name = "Nip")]
		_16 = 16,

		[Display(Name = "Mbesë")]
		_17 = 17,

		[Display(Name = "Nipi i gruas")]
		_18 = 18,

		[Display(Name = "Mbesa e gruas")]
		_19 = 19,

		[Display(Name = "Djali i së resë")]
		_20 = 20,

		[Display(Name = "Vajza i së resë")]
		_21 = 21,

		[Display(Name = "Nusja e nipit")]
		_22 = 22,

		[Display(Name = "Stërnip/e")]
		_23 = 23,

		[Display(Name = "Djali i nipit")]
		_24 = 24,

		[Display(Name = "Vajza e nipit")]
		_25 = 25,

		[Display(Name = "Mbesa e djalit të gruas")]
		_26 = 26,

		[Display(Name = "Gjysh/e")]
		_27 = 27,

		[Display(Name = "I ati")]
		_28 = 28,

		[Display(Name = "E ëma")]
		_29 = 29,

		[Display(Name = "Vjehrri")]
		_30 = 30,

		[Display(Name = "Vjehrra")]
		_31 = 31,

		[Display(Name = "Vëllai")]
		_32 = 32,

		[Display(Name = "Motra")]
		_33 = 33,

		[Display(Name = "Njerk / a")]
		_34 = 34,

		[Display(Name = "Djali i njerkës")]
		_35 = 35,

		[Display(Name = "Vajza e njerkës")]
		_36 = 36,

		[Display(Name = "Djali i vëllait")]
		_37 = 37,

		[Display(Name = "Vajza e vëllait")]
		_38 = 38,

		[Display(Name = "Kunat / a")]
		_39 = 39,

		[Display(Name = "Xhaxhai")]
		_40 = 40,

		[Display(Name = "Nusja e xhaxhait")]
		_41 = 41,

		[Display(Name = "Hallë")]
		_42 = 42,

		[Display(Name = "Dajë")]
		_43 = 43,

		[Display(Name = "Teze")]
		_44 = 44,

		[Display(Name = "Vjehrra e djalit")]
		_45 = 45,

		[Display(Name = "Djali i xhaxhait")]
		_46 = 46,

		[Display(Name = "Kushëri/ra")]
		_47 = 47,

		[Display(Name = "Ilegal")]
		_48 = 48,

		[Display(Name = "E panjohur")]
		_49 = 49,

	}
}
