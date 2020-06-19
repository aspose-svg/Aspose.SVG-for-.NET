using System.Collections.Generic;
using System.IO;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG
{
	class FileNameProvider : IFileNameProvider
	{
		Dictionary<string, int> usedNames = new Dictionary<string, int>();

		public string GetNextFileName(string fileName, string extension)
		{
			string key = fileName.ToUpperInvariant();
			if (usedNames.ContainsKey(key))
			{
				fileName = $"{fileName}_{++usedNames[key]}{extension}";
				return fileName;
			}
			else
			{
				fileName = $"{fileName}{extension}";
				usedNames.Add(key, 1);
				return fileName;
			}
		}
	}
}
