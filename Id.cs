using System.Xml.Serialization;

namespace AwwScrapDefinitionGenerator
{
	[XmlInclude(typeof(Id))]
	public class Id
	{
		public string TypeId;
		public string SubtypeId;
	}
}