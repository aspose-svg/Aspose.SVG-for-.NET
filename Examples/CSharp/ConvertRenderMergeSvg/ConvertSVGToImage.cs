using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Saving;
using System;
using System.IO;

namespace CSharp.ConvertRenderMergeSvg
{
    class ConvertSVGToImage
    {
        public static void Run()
        {
            ConvertSvgToPngUsingConverter();
            RenderSvgToPngUsingRenderTo();
            ConvertSvgToJpegUsingConverter();
            RenderSvgToJpegWithAntialiasing();
            ConvertSvgToBmp();
            ConvertSvgToGifWithPageSetup();
            ConvertSvgToTiffWithCompression();
        }

        public static void ConvertSvgToPngUsingConverter()
        {
            // Convert SVG to PNG in C# using Aspose.SVG for .NET.
            // This example uses Converter.ConvertSVG() with ImageSaveOptions for a direct SVG to PNG workflow.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "svg-to-png.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "svg-to-png.png");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new ImageSaveOptions
                {
                    BackgroundColor = System.Drawing.Color.White,
                    HorizontalResolution = 144,
                    VerticalResolution = 144
                };

                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG to PNG: {outputPath}");
        }

        public static void RenderSvgToPngUsingRenderTo()
        {
            // Render SVG to PNG in C# using SVGDocument.RenderTo().
            // RenderTo() sends the loaded SVG document to an ImageDevice configured for PNG output.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "snowflake.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "snowflake-rendered.png");

            using (var document = new SVGDocument(inputPath))
            using (IDevice device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Png), outputPath))
            {
                document.RenderTo(device);
            }

            Console.WriteLine($"Rendered SVG to PNG: {outputPath}");
        }

        public static void ConvertSvgToJpegUsingConverter()
        {
            // Convert SVG to JPEG in C# using ImageSaveOptions.
            // JPEG does not support transparency, so this example sets an opaque background color.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "owl-edited.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "owl-edited.jpg");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new ImageSaveOptions(ImageFormat.Jpeg)
                {
                    BackgroundColor = System.Drawing.Color.WhiteSmoke,
                    UseAntialiasing = true
                };

                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG to JPEG: {outputPath}");
        }

        public static void RenderSvgToJpegWithAntialiasing()
        {
            // Render SVG to JPEG with and without antialiasing.
            // This comparison helps users understand how ImageRenderingOptions affects raster output quality.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "owl.svg");
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(inputPath))
            {
                var antialiasingOptions = new ImageRenderingOptions(ImageFormat.Jpeg)
                {
                    UseAntialiasing = true
                };

                var noAntialiasingOptions = new ImageRenderingOptions(ImageFormat.Jpeg)
                {
                    UseAntialiasing = false
                };

                using (IDevice device = new ImageDevice(antialiasingOptions, Path.Combine(outputDir, "owl-antialiasing.jpg")))
                {
                    document.RenderTo(device);
                }

                using (IDevice device = new ImageDevice(noAntialiasingOptions, Path.Combine(outputDir, "owl-no-antialiasing.jpg")))
                {
                    document.RenderTo(device);
                }
            }

            Console.WriteLine($"Rendered SVG to JPEG with antialiasing options: {outputDir}");
        }

        public static void ConvertSvgToBmp()
        {
            // Convert SVG to BMP in C# using ImageDevice.
            // BMP output is useful for legacy workflows that require an uncompressed raster image format.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "conclusion.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "conclusion.bmp");

            using (var document = new SVGDocument(inputPath))
            using (IDevice device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Bmp), outputPath))
            {
                document.RenderTo(device);
            }

            Console.WriteLine($"Converted SVG to BMP: {outputPath}");
        }

        public static void ConvertSvgToGifWithPageSetup()
        {
            // Convert SVG to GIF in C# with custom page setup.
            // PageSetup controls the output page size and margins during SVG rendering.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "owl.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "owl.gif");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new ImageSaveOptions(ImageFormat.Gif);
                options.PageSetup.AnyPage = new Page(new Size(400, 600), new Margin(20, 20, 20, 20));

                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG to GIF: {outputPath}");
        }

        public static void ConvertSvgToTiffWithCompression()
        {
            // Convert SVG to TIFF in C# with custom TIFF compression settings.
            // ImageRenderingOptions lets you choose image format and rendering-specific output options.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "conclusion.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "conclusion.tiff");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new ImageRenderingOptions(ImageFormat.Tiff)
                {
                    Compression = Compression.None
                };

                using (IDevice device = new ImageDevice(options, outputPath))
                {
                    document.RenderTo(device);
                }
            }

            Console.WriteLine($"Converted SVG to TIFF: {outputPath}");
        }
    }
}
