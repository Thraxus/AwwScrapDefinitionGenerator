using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace AwwScrapDefinitionGenerator
{
	internal static class ErrorHandler
	{
		internal static void HandleError(Exception e, bool throwError = false, [CallerMemberName] string caller = "", [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
			var sb = new StringBuilder();

			Debug.WriteLine("");

			sb.AppendLine("Error Detected!");
			sb.AppendLine("************************ BEGIN ****************************");
			sb.AppendLine();

			sb.AppendLine($"From: {caller}");
			sb.AppendLine($"In: {file}");
			sb.AppendLine($"On Line: {line}");

			sb.AppendLine();
			sb.AppendLine("Error:");
			sb.Append(e);
			sb.AppendLine();
			sb.AppendLine();

			sb.AppendLine();
			sb.AppendLine("************************  END  ****************************");

			Debug.Write(sb.ToString());
			Debug.WriteLine("");

			if (throwError) throw new Exception(sb.ToString());
		}
	}
}