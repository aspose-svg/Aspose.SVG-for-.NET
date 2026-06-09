using Aspose.Svg;
using CSharp.LoadSaveConvert;
using CSharp.WorkingWithSVGDocument;
using System;
using System.IO;

namespace CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            if (TryRunSection(args))
            {
                Finish();
                return;
            }

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
            //WorkingWithSVGDocumentExamples.RunAll();
            #endregion

            Finish();
        }

        private static bool TryRunSection(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                return false;
            }

            string section = null;
            for (int i = 0; i < args.Length; i++)
            {
                if (string.Equals(args[i], "--section", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                {
                    section = args[i + 1];
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(section))
            {
                return false;
            }

            switch (section.Trim())
            {
                case "GettingStarted":
                    RunGettingStartedSection();
                    return true;

                case "LoadSaveConvert":
                    RunLoadSaveConvertSection();
                    return true;

                case "WorkingWithSVGDocument":
                    WorkingWithSVGDocumentExamples.RunAll();
                    return true;

                default:
                    Console.WriteLine($"Unknown section: {section}");
                    Console.WriteLine("Available sections: GettingStarted, LoadSaveConvert, WorkingWithSVGDocument");
                    return true;
            }
        }

        private static void RunGettingStartedSection()
        {
            Console.WriteLine("GettingStarted examples are license setup examples.");
            Console.WriteLine("Run them one by one after adding a valid Aspose.SVG license file or metered keys.");
            Console.WriteLine("Available methods:");
            Console.WriteLine("- LoadLicense.LoadLicenseFromFile()");
            Console.WriteLine("- LoadLicense.LoadLicenseFromStream()");
            Console.WriteLine("- LoadLicense.ApplyLicenseUsingEmbeddedResource()");
            Console.WriteLine("- LoadLicense.ApplyMeteredLicense()");
        }

        private static void RunLoadSaveConvertSection()
        {
            Console.WriteLine("Running LoadSaveConvert examples...");

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
            LoadSVGDocumentFromFile.Run();
            RenderingOptions.Run();
            SaveSVGDocument.Run();
            SupportForHtmlContentInSVG.Run();
            VectorizeText.Run();

            Console.WriteLine("Skipped LoadSVGDocumentFromUrl and LoadSVGDocumentAsync because they still use an old external HTTP URL.");
            Console.WriteLine("LoadSaveConvert examples finished.");
        }

        private static void Finish()
        {
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
            // Shared SVG input files are stored centrally in Examples/Data/
            // so they can be reused by multiple example sections.
            var dir = Path.GetFullPath(GetDataDir_Data());
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_OutputSVG()
        {
            // Output files for working with SVG document examples are stored in Examples/output/svg/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\svg\\"));
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
            // Locate Examples/Data for SVG examples regardless of whether the app is
            // launched from Visual Studio, dotnet run, a compiled binary, or a small runner project.
            string dataPath = FindExamplesDataDirectory(Directory.GetCurrentDirectory())
                ?? FindExamplesDataDirectory(AppDomain.CurrentDomain.BaseDirectory);

            if (dataPath == null)
            {
                throw new DirectoryNotFoundException("Could not locate the Examples/Data directory.");
            }

            return dataPath + Path.DirectorySeparatorChar;
        }

        private static string FindExamplesDataDirectory(string startDirectory)
        {
            var directory = new DirectoryInfo(Path.GetFullPath(startDirectory));

            while (directory != null)
            {
                var directData = Path.Combine(directory.FullName, "Data");
                if (IsExamplesDataDirectory(directData) && directory.Name.Equals("Examples", StringComparison.OrdinalIgnoreCase))
                {
                    return Path.GetFullPath(directData);
                }

                var nestedData = Path.Combine(directory.FullName, "Examples", "Data");
                if (IsExamplesDataDirectory(nestedData))
                {
                    return Path.GetFullPath(nestedData);
                }

                directory = directory.Parent;
            }

            return null;
        }

        private static bool IsExamplesDataDirectory(string path)
        {
            return Directory.Exists(path)
                && (File.Exists(Path.Combine(path, "paths.svg"))
                    || File.Exists(Path.Combine(path, "svg", "paths.svg")));
        }
    }
}
