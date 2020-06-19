using System.IO;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG.DataSources
{
	sealed class UrlDataSource : DataSource
	{
		private string name;
		public UrlDataSource(string uri)
			: base(uri)
		{
			var url = new Svg.Url(Uri);
			name = url.Hostname;
		}

		public override string Name
		{
			get { return name; }
		}
	}
}
