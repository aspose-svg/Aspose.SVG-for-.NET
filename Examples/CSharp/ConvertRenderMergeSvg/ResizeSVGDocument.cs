using Aspose.Svg;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
using System;
using System.IO;

namespace CSharp.ConvertRenderMergeSvg
{
    class ResizeSVGDocument
    {
        public static void Run()
        {
            RenderSvgWithDefaultPage();
            RenderSvgWithFitContent();
            RenderSvgWithScaleContent();
            RenderSvgWithContainSizing();
            RenderSvgWithCropSizing();
        }

        public static void RenderSvgWithDefaultPage()
        {
            // Convert SVG to PNG in C# with default rendering options.
            // This baseline example shows the default page setup used by ImageRenderingOptions.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "rendering.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "resize-default.png");

            using (var document = new SVGDocument(inputPath))
            using (var device = new ImageDevice(new ImageRenderingOptions(), outputPath))
            {
                document.RenderTo(device);
            }

            Console.WriteLine($"Rendered SVG with default page setup: {outputPath}");
        }

        public static void RenderSvgWithFitContent()
        {
            // Resize SVG output with FitContent sizing in C#.
            // FitContent adjusts the output page to fit the rendered SVG content.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "rendering.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "resize-fit-content.jpg");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new ImageRenderingOptions(ImageFormat.Jpeg);
                options.PageSetup.Sizing = SizingType.FitContent;

                using (var device = new ImageDevice(options, outputPath))
                {
                    document.RenderTo(device);
                }
            }

            Console.WriteLine($"Rendered SVG with FitContent sizing: {outputPath}");
        }

        public static void RenderSvgWithScaleContent()
        {
            // Resize SVG output with ScaleContent sizing in C#.
            // ScaleContent scales the SVG content to the page size configured in PageSetup.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "rendering.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "resize-scale-content.png");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new ImageRenderingOptions();
                options.PageSetup.AnyPage = new Page(new Size(1500, 3000));
                options.PageSetup.Sizing = SizingType.ScaleContent;

                using (var device = new ImageDevice(options, outputPath))
                {
                    document.RenderTo(device);
                }
            }

            Console.WriteLine($"Rendered SVG with ScaleContent sizing: {outputPath}");
        }

        public static void RenderSvgWithContainSizing()
        {
            // Resize SVG output with Contain sizing in C#.
            // Contain fits the SVG into the target page while preserving the aspect ratio.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "rendering.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "resize-contain.png");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new ImageRenderingOptions();
                options.PageSetup.AnyPage = new Page(new Size(2000, 2500));
                options.PageSetup.Sizing = SizingType.Contain;

                using (var device = new ImageDevice(options, outputPath))
                {
                    document.RenderTo(device);
                }
            }

            Console.WriteLine($"Rendered SVG with Contain sizing: {outputPath}");
        }

        public static void RenderSvgWithCropSizing()
        {
            // Resize SVG output with Crop sizing in C#.
            // Crop renders content into the target page and cuts content outside the page bounds.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "rendering.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "resize-crop.jpg");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new ImageRenderingOptions(ImageFormat.Jpeg);
                options.PageSetup.AnyPage = new Page(new Size(500, 1000));
                options.PageSetup.Sizing = SizingType.Crop;

                using (var device = new ImageDevice(options, outputPath))
                {
                    document.RenderTo(device);
                }
            }

            Console.WriteLine($"Rendered SVG with Crop sizing: {outputPath}");
        }
    }
}
