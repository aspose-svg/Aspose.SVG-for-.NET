using Aspose.Svg;
using Aspose.Svg.Builder;
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;
using Aspose.Svg.Services;
using System;
using System.Drawing;
using System.IO;
using System.Threading;

namespace CSharp.WorkingWithSVGDocument
{
    class CreateAndLoadSVGDocument
    {
        public static void Run()
        {
            CreateEmptySVGDocument();
            CreateSVGDocumentFromString();
            CreateSVGDocumentFromStringWithBaseUri();
            LoadSVGDocumentFromFile();
            LoadSVGDocumentFromStream();
            LoadSVGDocumentFromUrl();
            LoadSVGDocumentAsync();
            CreateSVGUsingBuilderApi();
            LoadSVGDocumentWithConfiguration();
            LimitJavaScriptRuntime();
        }

        public static void CreateEmptySVGDocument()
        {
            // Create an empty SVG document with Aspose.SVG for .NET and save it to a file.
            // This is the smallest starting point for generating SVG markup programmatically in C#.
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "empty-document.svg");

            using (var document = new SVGDocument())
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG document: {outputPath}");
        }

        public static void CreateSVGDocumentFromString()
        {
            // Create an SVG document from an in-memory string using Aspose.SVG for .NET.
            // This pattern is useful when SVG markup comes from a template, database, or API response.
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "document-from-string.svg");
            string svgContent =
                "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"360\" height=\"180\">" +
                "<circle cx=\"90\" cy=\"90\" r=\"60\" fill=\"#ff595e\" />" +
                "<polygon points=\"180,20 330,90 210,160\" fill=\"#ffca3a\" />" +
                "</svg>";

            using (var document = new SVGDocument(svgContent, "."))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG from string: {outputPath}");
        }

        public static void CreateSVGDocumentFromStringWithBaseUri()
        {
            // Create an SVG document from a string and resolve relative resources by base URI.
            // Aspose.SVG for .NET uses the base URI to load linked files such as flower.png.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "from-string-with-base-uri.svg");
            string svgContent =
                "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"240\" height=\"160\">" +
                "<image href=\"flower.png\" x=\"20\" y=\"20\" width=\"200\" height=\"120\" />" +
                "</svg>";

            using (var document = new SVGDocument(svgContent, dataDir))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG from string with base URI: {outputPath}");
        }

        public static void LoadSVGDocumentFromFile()
        {
            // Load an SVG document from a file using Aspose.SVG for .NET.
            // This example uses a shared input file from Examples/Data and saves a copy after loading.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string inputPath = Path.Combine(dataDir, "bezier-curves.svg");
            string outputPath = Path.Combine(outputDir, "document-from-file.svg");

            using (var document = new SVGDocument(inputPath))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Loaded SVG from file: {outputPath}");
        }

        public static void LoadSVGDocumentFromStream()
        {
            // Load an SVG document from a FileStream with Aspose.SVG for .NET.
            // Stream loading is useful for web uploads, embedded resources, and custom storage layers.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string inputPath = Path.Combine(dataDir, "bezier-curves.svg");
            string outputPath = Path.Combine(outputDir, "document-from-stream.svg");

            using (var stream = File.Open(inputPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var document = new SVGDocument(stream, dataDir))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Loaded SVG from stream: {outputPath}");
        }

        public static void LoadSVGDocumentFromUrl()
        {
            // Load an SVG document from a Url object using Aspose.SVG for .NET.
            // The example uses a local file URL so it works offline in documentation samples and CI builds.
            string dataDir = RunExamples.GetDataDir_SVG();
            string inputPath = Path.Combine(dataDir, "owl.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputSVG(), "document-from-url.svg");
            var documentUrl = new Url(inputPath, Directory.GetCurrentDirectory());

            using (var document = new SVGDocument(documentUrl))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Loaded SVG from URL: {outputPath}");
        }

        public static void LoadSVGDocumentAsync()
        {
            // Load an SVG document asynchronously and wait until the DOM is ready.
            // This pattern is useful when SVG content has linked resources and you need a completion signal.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputSVG(), "document-async.svg");
            var documentUrl = new Url(Path.Combine(dataDir, "owl.svg"), Directory.GetCurrentDirectory());
            using (var documentReady = new ManualResetEvent(false))
            using (var document = new SVGDocument())
            {
                document.OnReadyStateChange += (sender, ev) =>
                {
                    if (document.ReadyState == "complete")
                    {
                        documentReady.Set();
                    }
                };

                document.Navigate(documentUrl);
                documentReady.WaitOne();
                document.Save(outputPath);
            }

            Console.WriteLine($"Loaded SVG asynchronously: {outputPath}");
        }

        public static void CreateSVGUsingBuilderApi()
        {
            // Create SVG markup with the Aspose.SVG Builder API.
            // Builder classes provide a fluent C# syntax for constructing nested SVG elements.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputSVG(), "builder-api-face.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(100)
                    .Height(100)
                    .ViewBox(-21, -21, 42, 42)
                    .AddDefs(def => def
                        .AddRadialGradient(id: "face", cx: .5, cy: .5, r: .5, extend: gradient => gradient
                            .AddStop(offset: 0, stopColor: Color.FromArgb(255, 255, 0))
                            .AddStop(offset: .9, stopColor: Color.FromArgb(245, 184, 0))
                            .AddStop(offset: 1, stopColor: Color.FromArgb(232, 145, 0))))
                    .AddCircle(r: 20, fill: "url(#face)", stroke: Color.Black, extend: circle => circle.StrokeWidth(.2))
                    .AddG(group => group
                        .AddCircle(cx: -7, cy: -6, r: 2, fill: Paint.None, stroke: Color.Black, extend: circle => circle.StrokeWidth(.5))
                        .AddCircle(cx: 7, cy: -6, r: 2, fill: Paint.None, stroke: Color.Black, extend: circle => circle.StrokeWidth(.5)))
                    .AddPath(d: "M-10 5 Q0 14 10 5", fill: Paint.None, stroke: Color.Black, extend: path => path.StrokeWidth(.75))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG with Builder API: {outputPath}");
        }

        public static void LoadSVGDocumentWithConfiguration()
        {
            // Load an SVG document with a custom Aspose.SVG configuration.
            // This example uses IUserAgentService to provide a user style sheet before parsing the SVG.
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string inputPath = Path.Combine(outputDir, "configured-user-agent.svg");
            string outputPath = Path.Combine(outputDir, "configured-user-agent-copy.svg");
            string svgContent =
                "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"360\" height=\"140\">" +
                "<circle cx=\"70\" cy=\"70\" r=\"45\" />" +
                "<text x=\"135\" y=\"85\">Aspose.SVG</text>" +
                "</svg>";

            File.WriteAllText(inputPath, svgContent);

            using (var configuration = new Configuration())
            {
                IUserAgentService userAgentService = configuration.GetService<IUserAgentService>();
                userAgentService.UserStyleSheet =
                    "circle { fill: silver; stroke: #0057B8; stroke-width: 4; }" +
                    "text { fill: DarkCyan; font-size: 32px; font-family: Arial; }";

                using (var document = new SVGDocument(inputPath, configuration))
                {
                    document.Save(outputPath);
                }
            }

            Console.WriteLine($"Loaded SVG with custom configuration: {outputPath}");
        }

        public static void LimitJavaScriptRuntime()
        {
            // Limit JavaScript execution time for an SVG document with Aspose.SVG for .NET.
            // IRuntimeService protects rendering and conversion workflows from scripts that run too long.
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string inputPath = Path.Combine(outputDir, "runtime-limited.svg");
            string outputPath = Path.Combine(outputDir, "runtime-limited.png");
            string svgContent =
                "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"180\" height=\"140\">" +
                "<script>while(true) {}</script>" +
                "<circle cx=\"70\" cy=\"70\" r=\"45\" fill=\"#3A86FF\" />" +
                "</svg>";

            File.WriteAllText(inputPath, svgContent);

            using (var configuration = new Configuration())
            {
                IRuntimeService runtimeService = configuration.GetService<IRuntimeService>();
                runtimeService.JavaScriptTimeout = TimeSpan.FromSeconds(5);

                using (var document = new SVGDocument(inputPath, configuration))
                {
                    Converter.ConvertSVG(document, new ImageSaveOptions(), outputPath);
                }
            }

            Console.WriteLine($"Converted SVG with limited JavaScript runtime: {outputPath}");
        }
    }
}
