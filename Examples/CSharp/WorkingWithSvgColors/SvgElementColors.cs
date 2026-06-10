using Aspose.Svg;
using System;
using System.IO;

namespace CSharp.WorkingWithSvgColors
{
    class SvgElementColors
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            ChangeSvgCircleFillColor();
            ChangeSvgLineStrokeColor();
            RecolorSvgPathAndAddBackground();
            CreateColoredShapesSvg();
            ModifySvgStyleAttributesWithDom();
        }

        public static void ChangeSvgCircleFillColor()
        {
            // Change the fill color of an SVG circle in C#.
            // This example loads an SVG file, finds the first <circle>, and updates its fill attribute.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "basic-shapes.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "circle-fill-color.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var circle = document.RootElement.QuerySelector("circle") as SVGCircleElement;
                if (circle != null)
                {
                    circle.SetAttribute("fill", "green");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Changed SVG circle fill color: {outputPath}");
        }

        public static void ChangeSvgLineStrokeColor()
        {
            // Change the stroke color of an SVG line in C#.
            // Stroke color controls outlines and lines, while fill controls the inside of closed shapes.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "basic-shapes.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "line-stroke-color.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var line = document.RootElement.QuerySelector("line") as SVGLineElement;
                if (line != null)
                {
                    line.SetAttribute("stroke", "green");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Changed SVG line stroke color: {outputPath}");
        }

        public static void RecolorSvgPathAndAddBackground()
        {
            // Recolor SVG path strokes and add a colored background in C#.
            // This is a common workflow for adapting monochrome icons to a new design theme.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "snowflake-blue.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "recolor-snowflake.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var background = (SVGCircleElement)document.CreateElementNS(SvgNamespace, "circle");
                background.Cx.BaseVal.Value = 150F;
                background.Cy.BaseVal.Value = 100F;
                background.R.BaseVal.Value = 150F;
                background.SetAttribute("fill", "#03b6fd");
                document.RootElement.InsertBefore(background, document.RootElement.FirstChild);

                var snowflakePath = document.RootElement.QuerySelector("path") as SVGPathElement;
                if (snowflakePath != null)
                {
                    snowflakePath.SetAttribute("stroke", "white");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Recolored SVG path and background: {outputPath}");
        }

        public static void CreateColoredShapesSvg()
        {
            // Create an SVG image with several color formats in C#.
            // SVG accepts named colors, HEX values, RGB-like values, and paint server references.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "colored-shapes.svg");

            using (var document = new SVGDocument())
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "800");
                svg.SetAttribute("height", "600");
                svg.SetAttribute("viewBox", "0 0 800 600");

                var background = document.CreateElementNS(SvgNamespace, "rect");
                background.SetAttribute("x", "0");
                background.SetAttribute("y", "0");
                background.SetAttribute("width", "100%");
                background.SetAttribute("height", "100%");
                background.SetAttribute("fill", "#d7efff");
                svg.AppendChild(background);

                var rect = document.CreateElementNS(SvgNamespace, "rect");
                rect.SetAttribute("x", "60");
                rect.SetAttribute("y", "70");
                rect.SetAttribute("width", "280");
                rect.SetAttribute("height", "180");
                rect.SetAttribute("fill", "#ffd54f");
                rect.SetAttribute("stroke", "#f57f17");
                rect.SetAttribute("stroke-width", "4");
                svg.AppendChild(rect);

                var circle = document.CreateElementNS(SvgNamespace, "circle");
                circle.SetAttribute("cx", "520");
                circle.SetAttribute("cy", "220");
                circle.SetAttribute("r", "90");
                circle.SetAttribute("fill", "#ff6b6b");
                circle.SetAttribute("stroke", "#8b1a1a");
                circle.SetAttribute("stroke-width", "4");
                svg.AppendChild(circle);

                var path = document.CreateElementNS(SvgNamespace, "path");
                path.SetAttribute("d", "M 220 410 L 360 320 L 500 410 L 430 510 L 290 510 Z");
                path.SetAttribute("fill", "#6495ed");
                path.SetAttribute("stroke", "#1d3f8a");
                path.SetAttribute("stroke-width", "3");
                svg.AppendChild(path);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG with colored shapes: {outputPath}");
        }

        public static void ModifySvgStyleAttributesWithDom()
        {
            // Modify SVG style attributes with DOM methods in C#.
            // The example combines fill, stroke, opacity, gradient references, and filter references.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "modify-color-styles-dom.svg");

            using (var document = new SVGDocument())
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "800");
                svg.SetAttribute("height", "600");
                svg.SetAttribute("viewBox", "0 0 800 600");

                var defs = document.CreateElementNS(SvgNamespace, "defs");
                svg.AppendChild(defs);

                var gradient = document.CreateElementNS(SvgNamespace, "linearGradient");
                gradient.SetAttribute("id", "gradient1");
                gradient.SetAttribute("x1", "0%");
                gradient.SetAttribute("y1", "0%");
                gradient.SetAttribute("x2", "100%");
                gradient.SetAttribute("y2", "100%");
                defs.AppendChild(gradient);

                var stop1 = document.CreateElementNS(SvgNamespace, "stop");
                stop1.SetAttribute("offset", "0%");
                stop1.SetAttribute("stop-color", "#4fc3f7");
                gradient.AppendChild(stop1);

                var stop2 = document.CreateElementNS(SvgNamespace, "stop");
                stop2.SetAttribute("offset", "100%");
                stop2.SetAttribute("stop-color", "#0288d1");
                gradient.AppendChild(stop2);

                var rect = document.CreateElementNS(SvgNamespace, "rect");
                rect.SetAttribute("x", "50");
                rect.SetAttribute("y", "50");
                rect.SetAttribute("width", "300");
                rect.SetAttribute("height", "200");
                rect.SetAttribute("fill", "url(#gradient1)");
                rect.SetAttribute("stroke", "#0d47a1");
                rect.SetAttribute("stroke-width", "3");
                rect.SetAttribute("rx", "15");
                rect.SetAttribute("ry", "15");
                rect.SetAttribute("style", "opacity: 0.95;");
                svg.AppendChild(rect);

                var circle = document.CreateElementNS(SvgNamespace, "circle");
                circle.SetAttribute("cx", "550");
                circle.SetAttribute("cy", "200");
                circle.SetAttribute("r", "80");
                circle.SetAttribute("style", "fill: #ff7043; stroke: #bf360c; stroke-width: 5; opacity: 0.85;");
                svg.AppendChild(circle);

                var path = document.CreateElementNS(SvgNamespace, "path");
                path.SetAttribute("d", "M 100 450 Q 250 350 400 450 T 700 450");
                path.SetAttribute("fill", "none");
                path.SetAttribute("stroke", "#388e3c");
                path.SetAttribute("stroke-width", "8");
                path.SetAttribute("stroke-dasharray", "20,10");
                path.SetAttribute("stroke-linecap", "round");
                svg.AppendChild(path);

                document.Save(outputPath);
            }

            Console.WriteLine($"Modified SVG color styles with DOM: {outputPath}");
        }
    }
}
