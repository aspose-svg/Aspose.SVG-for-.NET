using Aspose.Svg;
using Aspose.Svg.Collections;
using Aspose.Svg.Dom;
using Aspose.Svg.Paths;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class CSSSelector
    {
        public static void Run()
        {
            FindFirstElementWithQuerySelector();
            FindElementsWithQuerySelectorAll();
            EditElementsSelectedByCss();
            ReplaceSelectedElements();
            ModifyPathDataSelectedByCss();
        }

        public static void FindFirstElementWithQuerySelector()
        {
            // Find a single SVG element with a CSS selector using Aspose.SVG for .NET.
            // QuerySelector() returns the first DOM element that matches the selector.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                var rectangle = document.QuerySelector("rect[style*='FireBrick']");
                Console.WriteLine(rectangle.OuterHTML);
            }
        }

        public static void FindElementsWithQuerySelectorAll()
        {
            // Find multiple SVG elements with QuerySelectorAll().
            // This example selects all rectangles whose style attribute contains a specific stroke color.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                NodeList rectangles = document.QuerySelectorAll("rect[style*='FireBrick']");

                foreach (Element rectangle in rectangles)
                {
                    Console.WriteLine(rectangle.OuterHTML);
                }
            }
        }

        public static void EditElementsSelectedByCss()
        {
            // Edit SVG nodes selected with CSS selectors.
            // This example finds circles in owl.svg, enlarges them, and saves the edited SVG document.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "css-selector-edited-circles.svg");

            using (var document = new SVGDocument(Path.Combine(dataDir, "owl.svg")))
            {
                NodeList circles = document.QuerySelectorAll("g > circle");

                foreach (Node node in circles)
                {
                    var circle = node as SVGCircleElement;
                    circle.R.BaseVal.Value *= 1.5F;
                    circle.SetAttribute("stroke", "#0057B8");
                    circle.SetAttribute("stroke-width", "4");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Edited SVG circles selected by CSS: {outputPath}");
        }

        public static void ReplaceSelectedElements()
        {
            // Replace SVG elements selected by CSS selectors.
            // This example selects circles in owl.svg, creates matching rectangles, and removes the circles.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "css-selector-replaced-circles.svg");
            const string svgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument(Path.Combine(dataDir, "owl.svg")))
            {
                var svg = document.RootElement;
                var replacementGroup = (SVGGElement)document.CreateElementNS(svgNamespace, "g");
                replacementGroup.SetAttribute("fill", "none");
                replacementGroup.SetAttribute("stroke-width", "3");
                svg.AppendChild(replacementGroup);

                NodeList circles = svg.QuerySelectorAll("g > circle");

                foreach (Node node in circles)
                {
                    var circle = node as SVGCircleElement;
                    float cx = circle.Cx.BaseVal.Value;
                    float cy = circle.Cy.BaseVal.Value;
                    float r = circle.R.BaseVal.Value;

                    var rectangle = (SVGRectElement)document.CreateElementNS(svgNamespace, "rect");
                    rectangle.X.BaseVal.Value = cx - r;
                    rectangle.Y.BaseVal.Value = cy - r;
                    rectangle.Width.BaseVal.Value = 2 * r;
                    rectangle.Height.BaseVal.Value = 2 * r;
                    rectangle.SetAttribute("stroke", "#FFB703");

                    replacementGroup.AppendChild(rectangle);
                    circle.Remove();
                }

                replacementGroup.LastElementChild.SetAttribute("stroke", "#C8102E");
                document.Save(outputPath);
            }

            Console.WriteLine($"Replaced SVG circles selected by CSS: {outputPath}");
        }

        public static void ModifyPathDataSelectedByCss()
        {
            // Modify SVG path data on an element selected with QuerySelector().
            // This example reads existing path segments, creates a simplified path, and saves the edited SVG.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "css-selector-edited-path.svg");

            using (var document = new SVGDocument(Path.Combine(dataDir, "owl.svg")))
            {
                var svg = document.RootElement;
                var wingPath = svg.QuerySelector("g:first-child > path:nth-child(2)") as SVGPathElement;

                if (wingPath == null)
                {
                    Console.WriteLine("The expected owl wing path was not found.");
                    return;
                }

                string pathData = string.Empty;
                foreach (SVGPathSeg pathSegment in wingPath.PathSegList)
                {
                    if (pathSegment is SVGPathSegMovetoAbs moveTo)
                    {
                        pathData += $" M {moveTo.X} {moveTo.Y}";
                    }
                    else if (pathSegment is SVGPathSegCurvetoCubicAbs curveTo)
                    {
                        float middleX = (curveTo.X1 + curveTo.X2) / 2F;
                        float middleY = (curveTo.Y1 + curveTo.Y2) / 2F;
                        pathData += $" L {middleX} {middleY} L {curveTo.X} {curveTo.Y}";
                    }
                }

                wingPath.SetAttribute("d", pathData.Trim());
                wingPath.SetAttribute("stroke", "Teal");
                wingPath.SetAttribute("stroke-width", "8");
                document.Save(outputPath);
            }

            Console.WriteLine($"Modified SVG path data selected by CSS: {outputPath}");
        }
    }
}
