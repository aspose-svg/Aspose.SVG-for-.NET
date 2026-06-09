using Aspose.Svg;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class CreateSVGWithViewBox
    {
        public static void Run()
        {
            // Create an SVG document with a viewBox, shapes, and text using Aspose.SVG for .NET.
            // This example demonstrates how the SVG viewBox controls the coordinate system of a document.
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "viewbox-shapes.svg");
            const string svgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svg = document.RootElement;
                svg.SetAttribute("viewBox", "0 0 400 300");
                svg.SetAttribute("width", "800");
                svg.SetAttribute("height", "600");

                var rect = document.CreateElementNS(svgNamespace, "rect");
                rect.SetAttribute("x", "20");
                rect.SetAttribute("y", "20");
                rect.SetAttribute("width", "160");
                rect.SetAttribute("height", "100");
                rect.SetAttribute("fill", "#8ECAE6");
                rect.SetAttribute("stroke", "#0d47a1");
                rect.SetAttribute("stroke-width", "2");
                svg.AppendChild(rect);

                var circle = document.CreateElementNS(svgNamespace, "circle");
                circle.SetAttribute("cx", "280");
                circle.SetAttribute("cy", "70");
                circle.SetAttribute("r", "50");
                circle.SetAttribute("fill", "#ff9800");
                svg.AppendChild(circle);

                var path = document.CreateElementNS(svgNamespace, "path");
                path.SetAttribute("d", "M 50 250 Q 150 150 250 250 T 450 250");
                path.SetAttribute("fill", "none");
                path.SetAttribute("stroke", "#4caf50");
                path.SetAttribute("stroke-width", "5");
                path.SetAttribute("stroke-linecap", "round");
                svg.AppendChild(path);

                var text = document.CreateElementNS(svgNamespace, "text");
                text.SetAttribute("x", "20");
                text.SetAttribute("y", "280");
                text.SetAttribute("font-family", "Arial");
                text.SetAttribute("font-size", "24");
                text.SetAttribute("fill", "#333");
                text.SetAttribute("font-weight", "bold");
                text.TextContent = "SVG ViewBox Demo";
                svg.AppendChild(text);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG with viewBox: {outputPath}");
        }
    }
}
