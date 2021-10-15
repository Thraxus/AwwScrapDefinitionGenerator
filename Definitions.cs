using System.Collections.Generic;
using System.Xml.Serialization;

namespace AwwScrapDefinitionGenerator
{
	[XmlRoot(nameof(Definitions))]
	public class Definitions
	{
		public List<PhysicalItem> PhysicalItems = new List<PhysicalItem>();
		public List<Blueprint> Blueprints = new List<Blueprint>();
	}
}