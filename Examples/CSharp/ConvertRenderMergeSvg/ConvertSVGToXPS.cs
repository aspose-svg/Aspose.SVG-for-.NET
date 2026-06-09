using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Xps;
using Aspose.Svg.Saving;
using System;
using System.IO;

namespace CSharp.ConvertRenderMergeSvg
{
    class ConvertSVGToXPS
    {
        public static void Run()
        {
            ConvertSvgToXpsUsingConverter();
            RenderSvgToXpsUsingDevice();
        }

        public static void ConvertSvgToXpsUsingConverter()
        {
            // Convert SVG to XPS in C# using Converter.ConvertSVG().
            // XpsSaveOptions lets you configure document background, resolution, and page setup.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "owl.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "owl.xps");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new XpsSaveOptions
                {
                    BackgroundColor = System.Drawing.Color.White
                };

                Converter.ConvertSVG(document, options, outputPath);
            }

            Console.WriteLine($"Converted SVG to XPS: {outputPath}");
        }

        public static void RenderSvgToXpsUsingDevice()
        {
            // Render SVG to XPS in C# using XpsDevice.
            // This example demonstrates lower-level rendering when you need direct control over the device.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "light.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "light-rendered.xps");

            using (var document = new SVGDocument(inputPath))
            {
                var options = new XpsRenderingOptions();
                options.PageSetup.AnyPage = new Page(new Size(500, 500), new Margin(20, 20, 20, 20));

                using (IDevice device = new XpsDevice(options, outputPath))
                {
                    document.RenderTo(device);
                }
            }

            Console.WriteLine($"Rendered SVG to XPS: {outputPath}");
        }
    }
}
