using Microsoft.VisualStudio.TextTemplating.VSHost;
using System;
using System.Text;

namespace SimpleSingleFileGenerator;

public class FileGenerator : BaseCodeGeneratorWithSite
{
	public override string GetDefaultExtension() => ".txt.sfg";

	protected override byte[] GenerateCode(string inputFileName, string inputFileContent)
	{
		var result = new StringBuilder();
		result.AppendLine("// The following was output by SimpleSingleFileGenerator.FileGenerator");
		result.AppendLine($"// On {DateTimeOffset.Now}");
		result.AppendLine();
		result.AppendLine(inputFileContent);

		return Encoding.UTF8.GetBytes(result.ToString());
	}
}
