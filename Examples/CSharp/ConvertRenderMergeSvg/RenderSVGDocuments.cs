using Aspose.Svg;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Rendering.Xps;
using System;
using System.IO;

namespace CSharp.ConvertRenderMergeSvg
{
    class RenderSVGDocuments
    {
        public static void Run()
        {
            RenderSvgToPngWithSvgRenderer();
            RenderSvgToJpegWithSvgRenderer();
            RenderSvgToXpsWithSvgRenderer();
        }

        public static void RenderSvgToPngWithSvgRenderer()
        {
            // Render SVG to PNG in C# with SvgRenderer and ImageDevice.
            // SvgRenderer is useful when rendering one or more SVGDocument instances to a rendering device.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "owl.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "owl-renderer.png");

            using (var document = new SVGDocument(inputPath))
            using (var renderer = new SvgRenderer())
            using (var device = new ImageDevice(outputPath))
            {
                renderer.Render(device, document);
            }

            Console.WriteLine($"Rendered SVG to PNG with SvgRenderer: {outputPath}");
        }

        public static void RenderSvgToJpegWithSvgRenderer()
        {
            // Render SVG to JPEG in C# with SvgRenderer.
            // ImageRenderingOptions specifies JPEG output while SvgRenderer performs the rendering operation.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "owl.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "owl-renderer.jpg");

            using (var document = new SVGDocument(inputPath))
            using (var renderer = new SvgRenderer())
            using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Jpeg), outputPath))
            {
                renderer.Render(device, document);
            }

            Console.WriteLine($"Rendered SVG to JPEG with SvgRenderer: {outputPath}");
        }

        public static void RenderSvgToXpsWithSvgRenderer()
        {
            // Render SVG to XPS in C# using SvgRenderer and XpsDevice.
            // This renderer-based workflow mirrors lower-level rendering pipelines used by advanced applications.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "paths.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "paths-renderer.xps");

            using (var document = new SVGDocument(inputPath))
            using (var renderer = new SvgRenderer())
            using (var device = new XpsDevice(outputPath))
            {
                renderer.Render(device, document);
            }

            Console.WriteLine($"Rendered SVG to XPS with SvgRenderer: {outputPath}");
        }
    }
}
