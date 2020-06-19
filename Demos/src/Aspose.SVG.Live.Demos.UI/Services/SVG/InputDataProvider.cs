namespace Aspose.SVG.Live.Demos.UI.Services.SVG
{
	public abstract class InputDataProvider : DataProvider
	{
		private DataRecordFactory factory;

		public InputDataProvider()
			: this(new DataRecordFactory())
		{

		}

		public InputDataProvider(DataRecordFactory factory)
		{
			this.factory = factory;
		}

		protected DataRecordFactory Factory => factory;
	}
}
