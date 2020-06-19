using Aspose.Svg;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Merger
{
	abstract class MergerHandler : ApplicationExecutionHandler<MergerApplicationOptions>
	{
		protected MergerHandler(params ExecutionHandlerFilter[] filters)
			: base(filters)
		{
		}

		protected abstract RenderingWorkUnit CreateWorkItem(DataSource source, Configuration configuration);
	}
}
