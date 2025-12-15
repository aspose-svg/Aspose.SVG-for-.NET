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
            ConvertSVGFilesUsingRenderer.Run();
            ConvertSVGToImage.ConvertSVGToBMP();
            ConvertSVGToImage.ConvertSVGToGIF();
            ConvertSVGToImage.ConvertSVGToJPEG();
            ConvertSVGToImage.ConvertSVGToPNG();
            ConvertSVGToImage.ConvertSVGToTIFF();
            ConvertSVGToPDF.Run();
            ConvertSVGToXPS.Run();
            CreateEmptySVGDocument.Run();
            CreateSVGDocumentFromContent.Run();
            LoadSVGDocumentAsync.Run();
            LoadSVGDocumentFromFile.Run();
            LoadSVGDocumentFromUrl.Run();
            RenderingOptions.Run();
            SaveSVGDocument.Run();
            SupportForHtmlContentInSVG.Run();
            VectorizeText.Run();
            #endregion

            #region WorkingWithSVGDocument
            CSSSelector.Run();
            EditSVGFile.Run();
            InspectDocumentContent.Run();
            NodeIterator.Run();
            TraverseSVGElement.Run();
            ViewDocumentContentAsString.Run();
            XPathQuery.Run();
            #endregion

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            // Replaced ReadKey with ReadLine to avoid InvalidOperationException in non‑interactive environments
            Console.ReadLine();
        }
        
        public static String GetDataDir_Convert()
        {
            // Input files for conversion examples are stored in Examples/Data/convert/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "convert\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_Save()
        {
            // Output files for save examples are stored in Examples/output/save/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\save\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_Open()
        {
            // Input files for open examples are stored in Examples/Data/open/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "open\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_SVG()
        {
            // Input SVG files for working with SVG document examples are located in Examples/Data/svg/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "svg\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        // Output directory for conversion examples (separate from input directory)
        public static String GetDataDir_OutputConvert()
        {
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\convert\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static string GetDataDir_Data()
        {
            // Determine the Data folder location robustly.
            // The Data folder resides under the repository's Examples/Data directory.
            // This implementation works regardless of the current working directory
            // (e.g., when launched from VS, dotnet run, or the compiled binary).
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            // Navigate up from bin\Debug\net6.0 (or similar) to the repository root,
            // then into Examples/Data.
            var dataPath = Path.GetFullPath(
                Path.Combine(baseDir, "..", "..", "..", "..", "..", "Examples", "Data"));
            // Ensure the path ends with a directory separator.
            return dataPath + Path.DirectorySeparatorChar;
        }
    }
}
