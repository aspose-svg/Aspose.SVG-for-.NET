using Aspose.Svg;
using Aspose.Svg.Rendering.Image;
using System;
using System.IO;

namespace CSharp.ConvertRenderMergeSvg
{
    public class SupportForHtmlContentInSVG
    {
        public static void Run()
        {
            // Render HTML content inside SVG in C# using <foreignObject>.
            // This example shows how Aspose.SVG renders XHTML markup embedded in an SVG document.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "svg-with-html-content.jpg");
            string svgCode =
                "<svg viewBox='0 0 200 200' xmlns='http://www.w3.org/2000/svg'>" +
                "<style>div { color: white; font: 18px serif; height: 100%; overflow: hidden; }</style>" +
                "<polygon points='5,5 195,10 185,185 10,195' />" +
                "<foreignObject x='20' y='20' width='160' height='160'>" +
                "<div xmlns='http://www.w3.org/1999/xhtml'>" +
                "Aspose.SVG for .NET can render HTML content inside an SVG foreignObject element." +
                "</div>" +
                "</foreignObject>" +
                "</svg>";

            using (var document = new SVGDocument(svgCode, "."))
            using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Jpeg), outputPath))
            {
                document.RenderTo(device);
            }

            Console.WriteLine($"Rendered SVG with HTML content: {outputPath}");
        }
    }
}
