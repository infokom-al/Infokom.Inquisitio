using Infokom.Inquisitio.Domain.Atomics;

namespace Infokom.Inquisitio.Domain.Records
{
	public record EnterpriseInfo
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public EnterpriseType Type { get; set; }
	}


}
