using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;

namespace Aspose.SVG.Live.Demos.UI.Models
{
	///<Summary>
	/// ApiControllerBase class to have base methods
	///</Summary>

	public abstract class ModelBase : ApiController
	{
		
		///<Summary>
		/// ActionDelegate
		///</Summary>
		protected delegate void ActionDelegate(string inFilePath, string outPath, string zipOutFolder);
		///<Summary>
		/// inFileActionDelegate
		///</Summary>
		protected delegate void inFileActionDelegate(string inFilePath);
		///<Summary>
		/// Get File extension
		///</Summary>
		protected string GetoutFileExtension(string fileName, string folderName)
		{
			string sourceFolder = Aspose.SVG.Live.Demos.UI.Config.Configuration.WorkingDirectory + folderName;
			fileName = sourceFolder + "\\" + fileName;
			return Path.GetExtension(fileName);
		}

		

	}
}
