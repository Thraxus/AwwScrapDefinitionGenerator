using System;
using System.Collections.Generic;

namespace AwwScrapDefinitionGenerator
{
	internal class Program
	{

		private static void Main(string[] args)
		{
			//string item = "DemoComponent";

			foreach (var item in Items)
			{
				PhysicalItem pi = new PhysicalItem
				{
					Id = new Id
					{
						TypeId = Ore,
						SubtypeId = ScrapSubtype(item)
					},
					DisplayName = ScrapSubtype(item)
				};
				Definitions.PhysicalItems.Add(pi);


				Blueprint bp = new Blueprint
				{
					Id = new Id
					{
						TypeId = "BlueprintDefinition",
						SubtypeId = ScrapToIngotSubtype(item)
					},
					DisplayName = ScrapToIngotSubtype(item)

				};

				var pr = new Item
				{
					TypeId = Ore,
					SubtypeId = ScrapSubtype(item)
				};

				bp.Prerequisites.Add(pr);
				Definitions.Blueprints.Add(bp);
			}
			
			Console.WriteLine(XmlOperations.WriteToString(Definitions));

			Console.ReadKey();
		}

		public static Definitions Definitions = new Definitions();

		public const string Ore = "Ore";
		public const string Scrap = "Scrap";
		public const string ScrapToIngot = "ScrapToIngot";
		
		public static string ScrapSubtype(string item) => item + Scrap;

		public static string ScrapToIngotSubtype(string item) => item + ScrapToIngot;

		public static List<string> Items = new List<string>
		{
			"LWTS_AssemblerMotorT2",
			"LWTS_AssemblerMotorT3",
			"LWTS_AssemblerMotorT4",
			"LWTS_AssemblerMotorT5",
			"LWTS_ALBUC_T5",
			"LWTS_ASBUC_T5",
			"LWTS_AlloyTube",
			"LWTS_ConstructionArmored",
			"LWTS_AlloyPlate",
			"MetalPlate",
			"MetalPlate_Military",
			"LWTS_DetectorTier2",
			"LWTS_DetectorTier3",
			"LWTS_DetectorTier4",
			"LWTS_DetectorTier5",
			"LWTS_GravityGeneratorTier2",
			"LWTS_GravityGeneratorTier3",
			"LWTS_GravityGeneratorTier4",
			"LWTS_GravityGeneratorTier5",
			"HydroThrustComponentT2",
			"HydroThrustComponentT3",
			"HydroThrustComponentT4",
			"HydroThrustComponentT5",
			"MotorT2",
			"MotorT3",
			"MotorT4",
			"MotorT5",
			"LWTS_PowerCellT2",
			"LWTS_PowerCellT3",
			"LWTS_PowerCellT4",
			"LWTS_PowerCellT5",
			"LWTS_ReactorT2",
			"LWTS_ReactorT3",
			"LWTS_ReactorT4",
			"LWTS_ReactorT5",
			"LWTS_SolarCellT2",
			"LWTS_SolarCellT3",
			"LWTS_SolarCellT4",
			"LWTS_SolarCellT5",
			"ThrustT2",
			"ThrustT3",
			"ThrustT4",
			"ThrustT5"
		};
	}

	
}
