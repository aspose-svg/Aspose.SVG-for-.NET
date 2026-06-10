using Aspose.Svg;
using CSharp.ConvertRenderMergeSvg;
using CSharp.ImageAndTextVectorization;
using CSharp.SvgFiltersAndGradients;
using CSharp.SvgStylesAndFontsManagement;
using CSharp.SvgTransformations;
using CSharp.UsingSvgBuilder;
using CSharp.WorkingWithSvgColors;
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

            #region ConvertRenderMergeSvg
            //ConvertRenderMergeSvgExamples.RunAll();
            #endregion

            #region ImageAndTextVectorization
            //ImageAndTextVectorizationExamples.RunAll();
            #endregion

            #region SvgFiltersAndGradients
            //SvgFiltersAndGradientsExamples.RunAll();
            #endregion

            #region SvgStylesAndFontsManagement
            //SvgStylesAndFontsManagementExamples.RunAll();
            #endregion

            #region SvgTransformations
            //SvgTransformationsExamples.RunAll();
            #endregion

            #region UsingSvgBuilder
            //UsingSvgBuilderExamples.RunAll();
            #endregion

            #region WorkingWithSvgColors
            //WorkingWithSvgColorsExamples.RunAll();
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

                case "ConvertRenderMergeSvg":
                    ConvertRenderMergeSvgExamples.RunAll();
                    return true;

                case "ImageAndTextVectorization":
                    ImageAndTextVectorizationExamples.RunAll();
                    return true;

                case "SvgFiltersAndGradients":
                    SvgFiltersAndGradientsExamples.RunAll();
                    return true;

                case "SvgStylesAndFontsManagement":
                    SvgStylesAndFontsManagementExamples.RunAll();
                    return true;

                case "SvgTransformations":
                    SvgTransformationsExamples.RunAll();
                    return true;

                case "UsingSvgBuilder":
                    UsingSvgBuilderExamples.RunAll();
                    return true;

                case "WorkingWithSvgColors":
                    WorkingWithSvgColorsExamples.RunAll();
                    return true;

                case "WorkingWithSVGDocument":
                    WorkingWithSVGDocumentExamples.RunAll();
                    return true;

                default:
                    Console.WriteLine($"Unknown section: {section}");
                    Console.WriteLine("Available sections: GettingStarted, ConvertRenderMergeSvg, ImageAndTextVectorization, SvgFiltersAndGradients, SvgStylesAndFontsManagement, SvgTransformations, UsingSvgBuilder, WorkingWithSvgColors, WorkingWithSVGDocument");
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

        public static String GetDataDir_OutputVectorization()
        {
            // Output files for image and text vectorization examples are stored in Examples/output/vectorization/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\vectorization\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_OutputFiltersAndGradients()
        {
            // Output files for SVG filters and gradients examples are stored in Examples/output/filters-gradients/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\filters-gradients\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_OutputStylesAndFonts()
        {
            // Output files for SVG styles and fonts examples are stored in Examples/output/styles-fonts/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\styles-fonts\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_OutputTransformations()
        {
            // Output files for SVG transformation examples are stored in Examples/output/transformations/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\transformations\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_OutputBuilder()
        {
            // Output files for SVG Builder API examples are stored in Examples/output/builder/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\builder\\"));
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static String GetDataDir_OutputColors()
        {
            // Output files for SVG color examples are stored in Examples/output/colors/
            var dir = Path.GetFullPath(Path.Combine(GetDataDir_Data(), "..\\output\\colors\\"));
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
