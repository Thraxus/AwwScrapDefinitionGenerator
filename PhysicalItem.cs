using System.Xml.Serialization;

namespace AwwScrapDefinitionGenerator
{
	[XmlInclude(typeof(PhysicalItem))]
	public class PhysicalItem
	{
		public Id Id;
		public string DisplayName;
		public string Icon = "Textures\\GUI\\Icons\\Components\\generic_scrap.dds";
		public Size Size = new Size();
		public int Mass = 1;
		public double Volume = 0.254;
		public string Model = "Models\\Components\\GenericScrap.mwm";
		public string PhysicalMaterial = "Metal";
	}
}