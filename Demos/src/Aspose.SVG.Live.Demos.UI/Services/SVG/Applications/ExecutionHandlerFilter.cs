namespace Aspose.SVG.Live.Demos.UI.Services.SVG.Applications
{
	public abstract class ExecutionHandlerFilter<TOptions> : ExecutionHandlerFilter
		where TOptions : ApplicationOptions
	{
		public abstract MatchResult Match(TOptions options);

		public override MatchResult Match(ApplicationOptions options)
		{
			return Match((TOptions) options);
		}
	}

	public abstract class ExecutionHandlerFilter
	{
		public abstract MatchResult Match(ApplicationOptions options);
	}
}
