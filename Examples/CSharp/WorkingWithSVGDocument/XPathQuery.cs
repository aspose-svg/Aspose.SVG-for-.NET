using Aspose.Svg;
using Aspose.Svg.Dom;
using Aspose.Svg.Dom.XPath;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class XPathQuery
    {
        public static void Run()
        {
            SelectGroupByAttribute();
            SelectRectangleByCoordinate();
            IterateXPathResults();
            EditElementSelectedByXPath();
        }

        public static void SelectGroupByAttribute()
        {
            // Select SVG elements with XPath expressions using Aspose.SVG for .NET.
            // This example finds the group whose fill attribute is set to yellow.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var result = document.Evaluate("//g[@fill='yellow']", document, null, XPathResultType.Any, null);
                Console.WriteLine((result.IterateNext() as Element)?.OuterHTML);
            }
        }

        public static void SelectRectangleByCoordinate()
        {
            // Use XPath to find an SVG rectangle by attribute value.
            // XPath is useful when selecting nodes by exact structural or attribute conditions.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                var result = document.Evaluate("//rect[@x='120']", document, null, XPathResultType.Any, null);
                Console.WriteLine((result.IterateNext() as Element)?.OuterHTML);
            }
        }

        public static void IterateXPathResults()
        {
            // Iterate over all SVG nodes returned by an XPath expression.
            // This example prints every rectangle that has a stroke style.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                var result = document.Evaluate("//rect[contains(@style, 'stroke')]", document, null, XPathResultType.Any, null);

                Element rectangle;
                while ((rectangle = result.IterateNext() as Element) != null)
                {
                    Console.WriteLine(rectangle.OuterHTML);
                }
            }
        }

        public static void EditElementSelectedByXPath()
        {
            // Edit an SVG element selected by XPath and save the updated document.
            // This example changes the stroke of a specific rectangle in shapes_svg.svg.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "xpath-edited-rectangle.svg");

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                var result = document.Evaluate("//rect[@x='120' and @y='150']", document, null, XPathResultType.Any, null);
                var rectangle = result.IterateNext() as Element;

                if (rectangle != null)
                {
                    rectangle.SetAttribute("style", "fill:#d9edf7; stroke:#0057B8; stroke-width:8");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Edited SVG rectangle selected by XPath: {outputPath}");
        }
    }
}
