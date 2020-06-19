using System;
using System.IO;
using System.Security;
using Aspose.SVG.Live.Demos.UI.Services.Extensions;
using Aspose.SVG.Live.Demos.UI.Services.SVG.DataSources;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG
{
	public class DataRecordFactory
	{
		Uri inputFolder = new Uri(Path.GetFullPath(Config.Configuration.WorkingDirectory));
		Uri currentFolder = new Uri(Path.GetFullPath(".") + "\\", UriKind.Absolute);
		private bool checkSecurityAccess;

		public DataRecordFactory()
			: this(true)
		{

		}

		public DataRecordFactory(bool checkSecurityAccess)
		{
			this.checkSecurityAccess = checkSecurityAccess;
		}

		public DataSource CreateDataSource(string url)
		{
			if (string.IsNullOrEmpty(url))
				return new MemoryStringDataSource();

			Uri uri = new Uri(currentFolder, url);
			if (uri.IsFile)
			{
				// NOTE: Attempt of unauthorized access outside of the input folder
				if (checkSecurityAccess && !uri.AbsolutePath.StartsWith(inputFolder.AbsolutePath, StringComparison.OrdinalIgnoreCase))
					throw new SecurityException();

				var ext = Path.GetExtension(uri.AbsoluteUri);
				if (FileFormat.ZIP.ToFileExtension().Equals(ext, StringComparison.OrdinalIgnoreCase))
					return new ArchiveDataSource(uri.LocalPath);
				return new LocalFileDataSource(uri.LocalPath);
			}

			return new UrlDataSource(url);
		}
	}
}
