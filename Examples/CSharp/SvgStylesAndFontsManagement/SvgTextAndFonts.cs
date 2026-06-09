using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Rendering.Pdf;
using Aspose.Svg.Saving;
using Aspose.Svg.Services;
using System;
using System.IO;

namespace CSharp.SvgStylesAndFontsManagement
{
    class SvgTextAndFonts
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            CreateAndStyleSvgTextElement();
            ConvertSvgWithCustomFontFolder();
            RenderSvgTextWithCustomFont();
            ConvertSvgTextWithFontFallbackToPdf();
            UseFontFaceRuleWithLocalFont();
            RenderConsistentTextToPngAndPdf();
        }

        public static void CreateAndStyleSvgTextElement()
        {
            // Create and style an SVG text element programmatically in C#.
            // This example builds a small SVG document and renders the text to a JPEG image.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "basic-svg-text.jpg");

            using (var document = new SVGDocument())
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "640");
                svg.SetAttribute("height", "200");
                svg.SetAttribute("viewBox", "0 0 640 200");

                var text = (SVGTextElement)document.CreateElementNS(SvgNamespace, "text");
                text.SetAttribute("x", "50");
                text.SetAttribute("y", "110");
                text.SetAttribute("font-family", "Arial, sans-serif");
                text.SetAttribute("font-size", "32");
                text.SetAttribute("fill", "#034586");
                text.TextContent = "Working with SVG Text";
                svg.AppendChild(text);

                var options = new ImageSaveOptions(ImageFormat.Jpeg)
                {
                    BackgroundColor = System.Drawing.Color.White
                };
                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Created and rendered SVG text: {outputPath}");
        }

        public static void ConvertSvgWithCustomFontFolder()
        {
            // Convert SVG text with a custom font folder in C#.
            // FontsSettings.SetFontsLookupFolder() lets Aspose.SVG resolve local fonts during rendering.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "input.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "input-with-custom-font.jpg");

            using (Configuration configuration = CreateFontConfiguration())
            using (var document = new SVGDocument(inputPath, configuration))
            {
                var text = document.QuerySelector("text") as SVGTextElement;
                if (text != null)
                {
                    text.SetAttribute("font-family", "Montserrat, Arial, sans-serif");
                }

                var options = new ImageSaveOptions(ImageFormat.Jpeg)
                {
                    BackgroundColor = System.Drawing.Color.White
                };
                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG with custom font folder: {outputPath}");
        }

        public static void RenderSvgTextWithCustomFont()
        {
            // Render SVG text with a custom font using Aspose.SVG for .NET.
            // The document is created with Configuration so the font lookup folder is available before rendering.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "custom-font-text.png");

            using (Configuration configuration = CreateFontConfiguration())
            using (var document = new SVGDocument(configuration))
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "640");
                svg.SetAttribute("height", "180");
                svg.SetAttribute("viewBox", "0 0 640 180");

                var text = (SVGTextElement)document.CreateElementNS(SvgNamespace, "text");
                text.SetAttribute("x", "50");
                text.SetAttribute("y", "100");
                text.SetAttribute("font-family", "Montserrat, Arial, sans-serif");
                text.SetAttribute("font-size", "34");
                text.SetAttribute("fill", "#2c3e50");
                text.TextContent = "Custom Font Example";
                svg.AppendChild(text);

                Converter.ConvertSVG(document, new ImageSaveOptions(), outputPath);
            }

            Console.WriteLine($"Rendered SVG with custom font: {outputPath}");
        }

        public static void ConvertSvgTextWithFontFallbackToPdf()
        {
            // Convert SVG text to PDF with font fallback in C#.
            // The CSS font-family list lets rendering fall back when the preferred font is unavailable.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "font-fallback.pdf");

            using (Configuration configuration = CreateFontConfiguration())
            using (var document = new SVGDocument(configuration))
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "720");
                svg.SetAttribute("height", "160");

                var style = (SVGStyleElement)document.CreateElementNS(SvgNamespace, "style");
                style.TextContent =
                    "text { font-family: 'Montserrat', Arial, sans-serif; font-weight: bold; font-size: 32px; fill: #2c2c2c; }";
                svg.AppendChild(style);

                var text = (SVGTextElement)document.CreateElementNS(SvgNamespace, "text");
                text.SetAttribute("x", "40");
                text.SetAttribute("y", "90");
                text.TextContent = "Font fallback PDF example";
                svg.AppendChild(text);

                Converter.ConvertSVG(document, new PdfSaveOptions(), outputPath);
            }

            Console.WriteLine($"Converted SVG text to PDF with font fallback: {outputPath}");
        }

        public static void UseFontFaceRuleWithLocalFont()
        {
            // Use @font-face with a local font file in SVG and convert it to PDF.
            // The SVG uses a base URI from Examples/Data so the relative font URL resolves during conversion.
            string outputDir = RunExamples.GetDataDir_OutputStylesAndFonts();
            string svgOutputPath = Path.Combine(outputDir, "font-face-local.svg");
            string pdfOutputPath = Path.Combine(outputDir, "font-face-local.pdf");
            string svgContent =
                "<svg xmlns='http://www.w3.org/2000/svg' width='720' height='160'>" +
                "<style>" +
                "@font-face { font-family: 'MontserratLocal'; src: url('fonts/Montserrat-Bold.ttf') format('truetype'); }" +
                "text { font-family: 'MontserratLocal', Arial, sans-serif; font-size: 32px; fill: #2c3e50; }" +
                "</style>" +
                "<text x='40' y='90'>SVG text rendered with @font-face</text>" +
                "</svg>";

            using (var document = new SVGDocument(svgContent, RunExamples.GetDataDir_SVG()))
            {
                document.Save(svgOutputPath);
                Converter.ConvertSVG(document, new PdfSaveOptions(), pdfOutputPath);
            }

            Console.WriteLine($"Created SVG and PDF with @font-face: {pdfOutputPath}");
        }

        public static void RenderConsistentTextToPngAndPdf()
        {
            // Render the same SVG text to PNG and PDF with a registered custom font folder.
            // Registering fonts before document creation helps keep text output consistent across formats.
            string outputDir = RunExamples.GetDataDir_OutputStylesAndFonts();

            using (Configuration configuration = CreateFontConfiguration())
            using (var document = new SVGDocument(configuration))
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "720");
                svg.SetAttribute("height", "180");

                var text = (SVGTextElement)document.CreateElementNS(SvgNamespace, "text");
                text.SetAttribute("x", "50");
                text.SetAttribute("y", "105");
                text.SetAttribute("font-family", "Montserrat, Arial, sans-serif");
                text.SetAttribute("font-size", "36");
                text.SetAttribute("fill", "#2c3e50");
                text.TextContent = "Consistent Rendering Example";
                svg.AppendChild(text);

                using (IDevice pngDevice = new ImageDevice(new ImageRenderingOptions(), Path.Combine(outputDir, "consistent-text.png")))
                using (IDevice pdfDevice = new PdfDevice(new PdfRenderingOptions(), Path.Combine(outputDir, "consistent-text.pdf")))
                {
                    document.RenderTo(pngDevice);
                    document.RenderTo(pdfDevice);
                }
            }

            Console.WriteLine($"Rendered consistent text output to PNG and PDF: {outputDir}");
        }

        private static Configuration CreateFontConfiguration()
        {
            var configuration = new Configuration();
            IUserAgentService userAgentService = configuration.GetService<IUserAgentService>();
            userAgentService.FontsSettings.SetFontsLookupFolder(Path.Combine(RunExamples.GetDataDir_SVG(), "fonts"));
            return configuration;
        }
    }
}
