using System;
using System.ComponentModel.Design;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Aspose.SVG.Live.Demos.UI.Services.Extensions;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Conversion;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Merger;
using ApplicationId = Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.ApplicationId;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG
{
	/// <summary>
	/// This class contains all business logic for SVG.Apps 
	/// </summary>
	/// <seealso cref="System.IDisposable" />
	public partial class SVGService : IDisposable
	{
		public SVGService()
		{
			FileNameProvider = new FileNameProvider();
		}

		public Result Convert(InputDataProvider inputData, ConversionApplicationOptions options)
		{
			return Execute(ApplicationRegistry.Instance.Get(ApplicationId.Conversion), inputData, options);
		}

		public Result Merge(InputDataProvider inputData, MergerApplicationOptions options)
		{
			if (inputData.GetData().Count(x => x.IsValid()) < 2)
				return Result.Error(ErrorCodes.NotEnoughFilesToPerformOperation);

			return Execute(ApplicationRegistry.Instance.Get(ApplicationId.Merger), inputData, options);
		}

		Result Execute(Application application, InputDataProvider inputData, ApplicationOptions options)
		{
			var result = application.Execute(inputData, options);
			if (result.IsValid &&
			    (result.DataFiles.Count > 1 && SVGOperationContextScope.Context.PackIfResultHasMultipleFiles))
			{
				var fileName = Guid.NewGuid();
				var zipTmpFilePath = Path.Combine(SVGOperationContextScope.Context.OutputFolder, $"./../{fileName}.zip");
				var zipFilePath = Path.Combine(SVGOperationContextScope.Context.OutputFolder, $"{ConversionApplication.DEFAULT_NAME_FOR_COVERTED_SET_OF_FILES}.zip");

				// TODO: Use the result.DataFiles property instead of packing the whole output directory
				ZipFile.CreateFromDirectory(SVGOperationContextScope.Context.OutputFolder, zipTmpFilePath);
				File.Move(zipTmpFilePath, zipFilePath);
				return Result.FromFiles(zipFilePath);
			}
			return result;
		}

		public IFileNameProvider FileNameProvider { get; }

		/// <summary>
		/// Releases all resources used by this object.
		/// </summary>
		public void Dispose()
		{
			// intentionally blank
		}
	}
}
