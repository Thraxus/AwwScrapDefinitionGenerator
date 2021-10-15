using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AwwScrapDefinitionGenerator
{
	public static class XmlOperations
	{
		public static bool WriteToFile<T>(string path, T data)
		{
			try
			{
				if (Path.GetDirectoryName(path) == null)
				{
					ErrorHandler.HandleError(new Exception($"Directory Path is invalid: {path}"));
					return false;
				}

				if (File.Exists(path))
				{
					ErrorHandler.HandleError(new Exception($"File already exists: {path}"));
					return false;
				}

				var ns = new XmlSerializerNamespaces();
				ns.Add("", "");
				var xml = string.Empty;

				using (TextWriter writer = new StreamWriter(path))
				{
					var xmlSerializer = new XmlSerializer(typeof(T));
					xmlSerializer.Serialize(writer, data, ns);
				}

				return true;
			}
			catch (Exception e)
			{
				ErrorHandler.HandleError(e);
				return false;
			}
		}

		public static string WriteToString<T>(T source)
		{
			try
			{
				var xDoc = new XDocument();
				using (var writer = xDoc.CreateWriter())
				{
					var serializer = new XmlSerializer(typeof(T));
					serializer.Serialize(writer, source);
				}
				//xDoc.Descendants().Attributes().Where(x => x.IsNamespaceDeclaration).Remove();
				xDoc.Declaration = new XDeclaration("1.0", null, null);
				return $"{xDoc.Declaration}{Environment.NewLine}{xDoc}";
			}
			catch (Exception e)
			{
				ErrorHandler.HandleError(e);
				return null;
			}
		}
	}
}