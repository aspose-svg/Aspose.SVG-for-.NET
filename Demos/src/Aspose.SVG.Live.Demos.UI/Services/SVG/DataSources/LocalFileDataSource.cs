using System.IO;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG.DataSources
{
	class LocalFileDataSource : DataSource
	{
		public LocalFileDataSource(string filePath)
			: base(filePath)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (SVGOperationContextScope.Context.DeleteSourceFolder)
			{
				if (File.Exists(Uri))
					System.IO.File.Delete(Uri);
			}
			base.Dispose(disposing);
		}
	}
}
