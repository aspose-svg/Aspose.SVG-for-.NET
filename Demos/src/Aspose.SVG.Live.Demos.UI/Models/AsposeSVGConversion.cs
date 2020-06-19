using System;
using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;
using Aspose.SVG.Live.Demos.UI.Models;
using Aspose.SVG.Live.Demos.UI.Services.SVG;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications;
using System.IO;
using System.Security;
using System.Collections.Generic;

namespace Aspose.SVG.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeSVGConversion class to convert SVG files to different formats
	///</Summary>
	public class AsposeSVGConversion : SVGBase
	{
		

		public Response Convert( string[] files, string outputType )
		{
			var workingFolder = string.Empty;
			try
			{
				Dictionary<string, string> Params = new Dictionary<string, string>();
				Params.Add("inputType", Path.GetExtension(files[0]).Replace(".", ""));
				Params.Add("outputType", outputType);
				
				using (var service = new SVGService())
				using (new SVGOperationContextScope(service, Params))
				{
					workingFolder = SVGOperationContextScope.Context.InputFolder;
					using (var dataProvider = new UrlDataProvider(files))
					{
						var data = dataProvider.GetData();
						if (data.Count(x => x.IsValid()) == 0)
							return BadDocumentResponse;

						if (data.Count(x => x.IsValid()) > MaximumUploadFiles)
							return MaximumFileLimitsResponse;

						// SVGOperationContextScope.Context.DeleteSourceFolder = true;

						var options = SVGOperationContextScope
							.Context
							.ApplicationOptionsFactory
							.CreateConversionOptions();

						var result = service.Convert(dataProvider, options);

						if (!result.IsValid)
						{
							string message;
							switch (result.ErrorCode)
							{
								case ErrorCodes.InvalidInputFormat:
									message = $"Input type '{options.InputFormat}' is not supported.";
									break;
								case ErrorCodes.InvalidOutputFormat:
									message = $"Output type '{options.InputFormat}' is not supported.";
									break;
								case ErrorCodes.MergingIsNotAllowed:
									message =
										$"Document merging is not supported for the '{options.OutputFormat}' format.";
									break;									
								case ErrorCodes.DocumentLoadError:
								case ErrorCodes.DocumentRenderingError:
								default:
									message = $"Document processing error.";
									break;
							}

							return new Response
							{
								FileName = null,
								Status = message,
								StatusCode = 500
							};
						}

					

						return new Response
						{
							FileName = Path.GetFileName(result.DataFiles.First()),
							FolderName = $"{SVGOperationContextScope.Context.Id}",
							Status = "OK",
							StatusCode = 200,
						};

					}
				}
			}
			catch (SecurityException ex)
			{
				Console.WriteLine(ex.Message);
				return new Response
				{
					FileName = null,
					Status = $"Document processing error.",
					StatusCode = 500
				};
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);

				return new Response
				{
					FileName = null,
					Status = $"Document processing error.",
					StatusCode = 500
				};
			}
		}

		
	}
}
