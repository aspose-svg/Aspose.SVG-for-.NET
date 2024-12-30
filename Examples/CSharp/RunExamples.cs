using Aspose.Svg;
using CSharp.GettingStarted;
using CSharp.LoadSaveConvert;
using CSharp.WorkingWithSVGDocument;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the one you want to try out
            #region Getting Started
            //LoadLicense.LoadLicenseFromFile();
            //LoadLicense.LoadLicenseFromStream();
            //LoadLicense.ApplyLicenseUsingEmbeddedResource();
            //LoadLicense.ApplyMeteredLicense();
            #endregion

            #region LoadSaveConvert
            //ConvertSVGFilesUsingRenderer.Run();
            //ConvertSVGToImage.ConvertSVGToBMP();
            //ConvertSVGToImage.ConvertSVGToGIF();
            //ConvertSVGToImage.ConvertSVGToJPEG();
            //ConvertSVGToImage.ConvertSVGToPNG();
            //ConvertSVGToImage.ConvertSVGToTIFF();
            //ConvertSVGToPDF.Run();
            //ConvertSVGToXPS.Run();
            //CreateEmptySVGDocument.Run();
            //CreateSVGDocumentFromContent.Run();
            //LoadSVGDocumentAsync.Run();
            //LoadSVGDocumentFromFile.Run();
            //LoadSVGDocumentFromUrl.Run();
            //RenderingOptions.Run();
            //SaveSVGDocument.Run();
            //SupportForHtmlContentInSVG.Run();
            //VectorizeText.Run();
            #endregion

            #region WorkingWithSVGDocument
            //CSSSelector.Run();
            //EditSVGFile.Run();
            //InspectDocumentContent.Run();
            //NodeIterator.Run();
            //TraverseSVGElement.Run();
            //ViewDocumentContentAsString.Run();
            //XPathQuery.Run();
            #endregion

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        
        public static String GetDataDir_Convert()
        {
            return Path.GetFullPath(GetDataDir_Data() + "convert/");
        }

        public static String GetDataDir_Save()
        {
            return Path.GetFullPath(GetDataDir_Data() + "save/");
        }

        public static String GetDataDir_Open()
        {
            return Path.GetFullPath(GetDataDir_Data() + "open/");
        }

        public static String GetDataDir_SVG()
        {
            return Path.GetFullPath(GetDataDir_Data() + "svg/");
        }

        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory());
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }
    }
}
