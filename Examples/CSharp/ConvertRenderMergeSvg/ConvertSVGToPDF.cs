using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Pdf;
using Aspose.Svg.Saving;
using System;
using System.IO;

namespace CSharp.ConvertRenderMergeSvg
{
    class ConvertSVGToPDF
    {
        public static void Run()
        {
            ConvertSvgToPdfUsingConverter();
            ConvertSvgFileToPdfWithFitContent();
            ConvertSvgStringToPdf();
            ConvertSvgStreamToPdf();
            ConvertSvgToPdfWithCustomPageSetup();
            RenderSvgToPdfUsingDevice();
        }

        public static void ConvertSvgToPdfUsingConverter()
        {
            // Convert SVG to PDF in C# using Converter.ConvertSVG().
            // PdfSaveOptions controls PDF-specific conversion settings such as background color and resolution.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "lineto.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "lineto.pdf");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new PdfSaveOptions
                {
                    BackgroundColor = System.Drawing.Color.Gainsboro,
                    HorizontalResolution = 300,
                    VerticalResolution = 300
                };

                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG to PDF: {outputPath}");
        }

        public static void ConvertSvgFileToPdfWithFitContent()
        {
            // Convert SVG to PDF in C# and fit the PDF page to SVG content.
            // SizingType.FitContent is useful when the output page should match the drawing bounds.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "svg-to-png.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "svg-fit-content.pdf");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new PdfSaveOptions
                {
                    BackgroundColor = System.Drawing.Color.White
                };
                options.PageSetup.Sizing = SizingType.FitContent;

                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG to PDF with FitContent: {outputPath}");
        }

        public static void ConvertSvgStringToPdf()
        {
            // Convert SVG markup from a string to PDF in C#.
            // This scenario is useful when SVG content is generated dynamically from templates or user input.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "svg-string.pdf");
            string svgContent =
                "<svg xmlns='http://www.w3.org/2000/svg' width='420' height='240' viewBox='0 0 420 240'>" +
                "<rect x='0' y='0' width='420' height='240' fill='#f5f7fb' />" +
                "<circle cx='130' cy='120' r='70' fill='#3A86FF' />" +
                "<rect x='240' y='60' width='120' height='120' rx='16' fill='#FFB703' />" +
                "<text x='40' y='215' font-size='24' font-family='Arial' fill='#1f2937'>SVG string to PDF</text>" +
                "</svg>";

            using (var document = new SVGDocument(svgContent, "."))
            {
                var options = new PdfSaveOptions
                {
                    BackgroundColor = System.Drawing.Color.White,
                    HorizontalResolution = 300,
                    VerticalResolution = 300
                };

                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG string to PDF: {outputPath}");
        }

        public static void ConvertSvgStreamToPdf()
        {
            // Convert SVG from a stream to PDF in C#.
            // Stream input is common for uploaded SVG files, embedded resources, and custom storage systems.
            string dataDir = RunExamples.GetDataDir_SVG();
            string inputPath = Path.Combine(dataDir, "bezier-curves.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "svg-stream.pdf");

            using (var stream = File.Open(inputPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var document = new SVGDocument(stream, dataDir))
            {
                var options = new PdfSaveOptions();
                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG stream to PDF: {outputPath}");
        }

        public static void ConvertSvgToPdfWithCustomPageSetup()
        {
            // Convert SVG to PDF in C# with custom page size and margins.
            // PageSetup.AnyPage controls the target PDF page dimensions used during conversion.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "owl.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "owl-custom-page.pdf");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new PdfSaveOptions
                {
                    BackgroundColor = System.Drawing.Color.White
                };
                options.PageSetup.AnyPage = new Page(new Size(640, 840), new Margin(40, 40, 40, 40));

                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG to PDF with custom page setup: {outputPath}");
        }

        public static void RenderSvgToPdfUsingDevice()
        {
            // Render SVG to PDF in C# using PdfDevice.
            // Rendering options let you define page size, margins, and JPEG quality for PDF output.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "light.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "light-rendered.pdf");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new PdfRenderingOptions
                {
                    JpegQuality = 90
                };
                options.PageSetup.AnyPage = new Page(new Size(500, 500), new Margin(10, 10, 10, 10));

                using (IDevice device = new PdfDevice(options, outputPath))
                {
                    document.RenderTo(device);
                }
            }

            Console.WriteLine($"Rendered SVG to PDF: {outputPath}");
        }
    }
}
