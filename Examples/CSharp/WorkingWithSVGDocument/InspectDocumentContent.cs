using Aspose.Svg;
using System;
using System.IO;
using System.Linq;

namespace CSharp.WorkingWithSVGDocument
{
    class InspectDocumentContent
    {
        public static void Run()
        {
            InspectRootElement();
            InspectCircleGeometry();
            InspectSpecificRectangle();
        }

        public static void InspectRootElement()
        {
            // Inspect root SVG element attributes with Aspose.SVG for .NET.
            // This example reads document-level values such as width, height, and tag name.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "basic-shapes.svg")))
            {
                var svg = document.DocumentElement;
                Console.WriteLine($"Tag: {svg.TagName}");
                Console.WriteLine($"Width: {svg.GetAttribute("width")}");
                Console.WriteLine($"Height: {svg.GetAttribute("height")}");
            }
        }

        public static void InspectCircleGeometry()
        {
            // Inspect SVG circle geometry with strongly typed DOM properties.
            // SVGCircleElement exposes cx, cy, and r through animated length values.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var svg = document.DocumentElement;
                var circle = svg.GetElementsByTagName("circle").First() as SVGCircleElement;

                Console.WriteLine(circle.Cx);
                Console.WriteLine(circle.Cy);
                Console.WriteLine(circle.R);
            }
        }

        public static void InspectSpecificRectangle()
        {
            // Extract information from a specific SVG rectangle.
            // This example combines DOM selection with typed SVGRectElement geometry properties.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                var rectangle = document.QuerySelector("rect[x='120']") as SVGRectElement;
                Console.WriteLine($"Rectangle width: {rectangle.Width.BaseVal.Value}");
                Console.WriteLine($"Rectangle height: {rectangle.Height.BaseVal.Value}");
                Console.WriteLine($"Rectangle style: {rectangle.GetAttribute("style")}");
            }
        }
    }
}
