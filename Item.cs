using System.Xml.Serialization;

namespace AwwScrapDefinitionGenerator
{
	[XmlInclude(typeof(Item))]
	public class Item
	{
		[XmlAttribute(nameof(Amount))] public int Amount = 1;
		[XmlAttribute(nameof(TypeId))] public string TypeId;
		[XmlAttribute(nameof(SubtypeId))] public string SubtypeId;
	}
}