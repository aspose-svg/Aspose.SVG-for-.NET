using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  AsposeSvg = Aspose.SVG;

namespace Aspose.SVG.Live.Demos.UI.Models
{
	///<Summary>
	/// License class to set apose products license
	///</Summary>
	public static class License
	{
		private static string _licenseFileName = "Aspose.Total.lic";


		///<Summary>
		/// SetAsposeSVGLicense method to Aspose.Words License
		///</Summary>
		public static void SetAsposeCellsLicense()
		{
			try
			{
				Aspose.Svg.License acLic = new Aspose.Svg.License();
				acLic.SetLicense(_licenseFileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		
		
	}
}
