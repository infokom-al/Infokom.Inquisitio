using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Infokom.Inquisitio.Application.Extensions
{
	public static class StringExtensions
	{
		/// <summary>
		/// Gets the enum value based on the given enum type and display name.
		/// </summary>
		/// <param name="displayName">The display name.</param>
		public static T GetEnumFromDisplayName<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>(this string displayName)
		{
			var type = typeof(T);
			if (!type.IsEnum)
			{
				return default;
			}

			foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
			{
				var displayAttribute = (DisplayAttribute)field.GetCustomAttribute(typeof(DisplayAttribute));
				if (displayAttribute != null && displayAttribute.Name == displayName)
				{
					return (T)field.GetValue(null);
				}
			}

			return default;
		}
		internal static string ToFirstCharacterLowerCase(this string input)
		=> string.IsNullOrEmpty(input) ? string.Empty : char.ToLowerInvariant(input[0]) + input.Substring(1);
	}
}
