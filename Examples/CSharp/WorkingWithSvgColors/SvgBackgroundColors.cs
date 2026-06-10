using Aspose.Svg;
using Aspose.Svg.Dom;
using System;
using System.IO;

namespace CSharp.WorkingWithSvgColors
{
    class SvgBackgroundColors
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            AddBackgroundRectangleToSvg();
            ChangeExistingBackgroundColor();
            SetSvgBackgroundWithStyleAttribute();
            AddBackgroundWithCssStyleElement();
            EmbedScriptThatAddsBackgroundColor();
        }

        public static void AddBackgroundRectangleToSvg()
        {
            // Add a background color rectangle to an existing SVG in C#.
            // SVG does not have a dedicated background-color property for its canvas, so a full-size rectangle is often used.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "tree.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "add-background-rectangle.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var background = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
                background.X.BaseVal.Value = 3;
                background.Y.BaseVal.Value = 3;
                background.SetAttribute("width", "100%");
                background.SetAttribute("height", "100%");
                background.SetAttribute("fill", "#ebf3f6");

                document.RootElement.InsertBefore(background, document.RootElement.FirstChild);
                document.Save(outputPath);
            }

            Console.WriteLine($"Added SVG background rectangle: {outputPath}");
        }

        public static void ChangeExistingBackgroundColor()
        {
            // Change the fill color of an existing SVG background rectangle in C#.
            // This is useful when an SVG already contains a background shape that only needs a new color.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "add-background-color.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "change-existing-background-color.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var rect = document.RootElement.QuerySelector("rect") as SVGRectElement;
                if (rect != null)
                {
                    rect.SetAttribute("fill", "#fef4fd");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Changed existing SVG background color: {outputPath}");
        }

        public static void SetSvgBackgroundWithStyleAttribute()
        {
            // Set an SVG background color with the style attribute in C#.
            // This method is concise, but a rectangle background is usually more portable for rendering and conversion.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "tulips.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "background-style-attribute.svg");

            using (var document = new SVGDocument(inputPath))
            {
                document.RootElement.SetAttribute("style", "background: grey");
                document.Save(outputPath);
            }

            Console.WriteLine($"Set SVG background with style attribute: {outputPath}");
        }

        public static void AddBackgroundWithCssStyleElement()
        {
            // Add an SVG background color using a CSS style element and a class.
            // This separates the background rule from the rectangle that applies it.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "tulips.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "background-css-style-element.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var svg = document.RootElement;

                var style = (SVGStyleElement)document.CreateElementNS(SvgNamespace, "style");
                style.TextContent = ".background { fill: grey; }";
                svg.InsertBefore(style, svg.FirstChild);

                var background = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
                background.X.BaseVal.Value = -120;
                background.Y.BaseVal.Value = 0;
                background.SetAttribute("width", "100%");
                background.SetAttribute("height", "100%");
                background.SetAttribute("class", "background");
                svg.InsertBefore(background, svg.ChildNodes[1]);

                document.Save(outputPath);
            }

            Console.WriteLine($"Added SVG background with CSS style element: {outputPath}");
        }

        public static void EmbedScriptThatAddsBackgroundColor()
        {
            // Add an SVG script element that creates a background rectangle when script execution is enabled.
            // The saved SVG contains the script; for static conversion workflows, prefer DOM or CSS background examples above.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "tree.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "background-script-element.svg");

            using (var document = new SVGDocument(inputPath))
            {
                Element script = document.CreateElementNS(SvgNamespace, "script");
                script.TextContent = @"
                    var svgElement = document.getElementsByTagName('svg')[0];
                    if (svgElement) {
                        var rectElement = document.createElementNS('http://www.w3.org/2000/svg', 'rect');
                        rectElement.setAttribute('x', '0');
                        rectElement.setAttribute('y', '0');
                        rectElement.setAttribute('width', '100%');
                        rectElement.setAttribute('height', '100%');
                        rectElement.setAttribute('fill', '#fef4fd');
                        svgElement.insertBefore(rectElement, svgElement.firstChild);
                    }";

                document.RootElement.AppendChild(script);
                document.Save(outputPath);
            }

            Console.WriteLine($"Embedded SVG script for background color: {outputPath}");
        }
    }
}
