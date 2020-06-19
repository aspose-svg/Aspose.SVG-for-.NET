using System;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Conversion
{
	class ConversionApplication : Application<ConversionApplicationOptions>
	{
		public ConversionApplication(params ConversionHandler[] handlers)
			: base(ApplicationId.Conversion, handlers)
		{
		}
	}
}
