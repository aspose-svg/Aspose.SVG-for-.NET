using Aspose.Svg;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class EditSVGFile
    {
        public static void Run()
        {
            CreateSVGFromScratch();
            AddCircleToSVGFile();
            AddPolylineAndUpdateShapes();
            DrawSVGOnExistingBitmap();
        }

        public static void CreateSVGFromScratch()
        {
            // Create an SVG document from scratch with shapes and text using Aspose.SVG for .NET.
            // This example demonstrates how to build a simple vector drawing by adding DOM elements.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputSVG(), "svg-from-scratch.svg");
            const string svgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "520");
                svg.SetAttribute("height", "220");
                svg.SetAttribute("viewBox", "0 0 520 220");

                var circle = (SVGCircleElement)document.CreateElementNS(svgNamespace, "circle");
                circle.Cx.BaseVal.Value = 120;
                circle.Cy.BaseVal.Value = 110;
                circle.R.BaseVal.Value = 60;
                circle.SetAttribute("stroke", "salmon");
                circle.SetAttribute("stroke-width", "32");
                circle.SetAttribute("fill", "none");
                circle.SetAttribute("stroke-dasharray", "2,14");

                var text = (SVGTextElement)document.CreateElementNS(svgNamespace, "text");
                text.SetAttribute("x", "220");
                text.SetAttribute("y", "125");
                text.SetAttribute("fill", "darkred");
                text.SetAttribute("font-size", "28");
                text.TextContent = "I can add elements to SVG!";

                svg.AppendChild(circle);
                svg.AppendChild(text);
                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG from scratch: {outputPath}");
        }

        public static void AddCircleToSVGFile()
        {
            // Edit an existing SVG file using the Aspose.SVG for .NET DOM API.
            // This example adds a new <circle> element to an SVG group and saves the updated document.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "basic-shapes.svg")))
            {
                const string svgNamespace = "http://www.w3.org/2000/svg";

                // Create a circle and set its SVG animated length values.
                var circle = (SVGCircleElement)document.CreateElementNS(svgNamespace, "circle");
                circle.Cx.BaseVal.Value = 50;
                circle.Cy.BaseVal.Value = 50;
                circle.R.BaseVal.Value = 40;
                circle.SetAttribute("fill", "#3A86FF");

                // Append the new shape to the first group in the document.
                var svgElement = document.RootElement;
                svgElement.InsertBefore(circle, svgElement.FirstChild);

                Console.WriteLine(circle.OuterHTML);
                document.Save(Path.Combine(outputDir, "basic-shapes-with-circle.svg"));
            }
        }

        public static void AddPolylineAndUpdateShapes()
        {
            // Add a polyline and update existing SVG shapes with Aspose.SVG for .NET.
            // This example demonstrates creating a new element and changing attributes on selected DOM nodes.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            const string svgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument(Path.Combine(dataDir, "basic-shapes.svg")))
            {
                var svgElement = document.RootElement;
                var polyline = (SVGPolylineElement)document.CreateElementNS(svgNamespace, "polyline");
                polyline.SetAttribute("points", "270,240 290,220 310,240");
                polyline.SetAttribute("stroke", "grey");
                polyline.SetAttribute("stroke-width", "5");
                polyline.SetAttribute("fill", "none");
                svgElement.AppendChild(polyline);

                foreach (var element in svgElement.Children)
                {
                    if (element is SVGCircleElement || element is SVGEllipseElement)
                    {
                        element.SetAttribute("stroke-width", "6");
                        element.SetAttribute("stroke", "#C8102E");
                    }
                }

                document.Save(Path.Combine(outputDir, "basic-shapes-updated.svg"));
            }
        }

        public static void DrawSVGOnExistingBitmap()
        {
            // Draw SVG shapes and text on an existing bitmap using Aspose.SVG for .NET.
            // This editing example references seaside.jpg with an <image> element and adds vector annotations.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "svg-drawing-on-bitmap.svg");
            const string svgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "680");
                svg.SetAttribute("height", "520");
                svg.SetAttribute("viewBox", "0 0 680 520");

                var image = (SVGImageElement)document.CreateElementNS(svgNamespace, "image");
                image.Href.BaseVal = Path.Combine(dataDir, "seaside.jpg");
                image.X.BaseVal.Value = 20;
                image.Y.BaseVal.Value = 20;
                image.Width.BaseVal.Value = 640;
                image.Height.BaseVal.Value = 480;
                svg.AppendChild(image);

                var text = (SVGTextElement)document.CreateElementNS(svgNamespace, "text");
                text.SetAttribute("x", "420");
                text.SetAttribute("y", "280");
                text.SetAttribute("fill", "gold");
                text.SetAttribute("font-size", "24");
                text.TextContent = "The beach is beautiful...";
                svg.AppendChild(text);

                var circle = (SVGCircleElement)document.CreateElementNS(svgNamespace, "circle");
                circle.Cx.BaseVal.Value = 520;
                circle.Cy.BaseVal.Value = 120;
                circle.R.BaseVal.Value = 60;
                circle.SetAttribute("stroke", "gold");
                circle.SetAttribute("stroke-width", "70");
                circle.SetAttribute("fill", "none");
                circle.SetAttribute("stroke-dasharray", "2,14");
                svg.AppendChild(circle);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG drawing on bitmap: {outputPath}");
        }
    }
}
