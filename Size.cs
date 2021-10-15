using System.Xml.Serialization;

namespace AwwScrapDefinitionGenerator
{
	[XmlInclude(typeof(Size))]
	public class Size
	{
		public double X = 0.2;
		public double Y = 0.2;
		public double Z = 0.1;
	}
}