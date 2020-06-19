using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG.DataSources
{
	public class MemoryStringDataSource : DataSource
	{

		public MemoryStringDataSource() : base("string")
		{ }

		public string Content { get; set; }
	}
}
