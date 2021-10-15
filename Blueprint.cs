using System.Collections.Generic;
using System.Xml.Serialization;

namespace AwwScrapDefinitionGenerator
{
	[XmlInclude(typeof(Blueprint))]
	public class Blueprint
	{
		public Id Id;
		public string DisplayName;
		public string Icon = "Textures\\GUI\\Icons\\Components\\generic_scrap.dds";
		[XmlArray(nameof(Prerequisites))] public List<Item> Prerequisites = new List<Item>();
		[XmlArray(nameof(Results))] public List<Item> Results = new List<Item>()
		{
			new Item
			{
				TypeId = "Ingot",
				SubtypeId = "Silicon"
			}
		};
		public double BaseProductionTimeInSeconds = 0.04;
	}
}