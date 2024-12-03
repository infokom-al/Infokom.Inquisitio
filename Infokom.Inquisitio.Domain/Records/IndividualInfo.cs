namespace Infokom.Inquisitio.Domain.Records
{
	public record IndividualInfo
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public string GivenName { get; set; }
		public string FamilyName { get; set; }
	}


}
