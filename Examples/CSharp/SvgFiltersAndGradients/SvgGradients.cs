using Aspose.Svg;
using System;
using System.IO;

namespace CSharp.SvgFiltersAndGradients
{
    class SvgGradients
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            CreateLinearGradient();
            CreateRadialGradient();
            CreateMultipleGradientShapes();
        }

        public static void CreateLinearGradient()
        {
            // Create an SVG linear gradient in C#.
            // The gradient is defined in <defs> and referenced from a rectangle with fill="url(#linearGradient)".
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "linear-gradient.svg");

            using (var document = CreateDocument(460, 220))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var gradient = AppendElement(document, defs, "linearGradient");
                gradient.SetAttribute("id", "linearGradient");
                gradient.SetAttribute("x1", "0%");
                gradient.SetAttribute("y1", "0%");
                gradient.SetAttribute("x2", "100%");
                gradient.SetAttribute("y2", "0%");

                AppendStop(document, gradient, "10%", "#c71700");
                AppendStop(document, gradient, "70%", "orange");
                AppendStop(document, gradient, "100%", "#5a2100");

                var rect = AppendElement(document, svg, "rect");
                rect.SetAttribute("x", "30");
                rect.SetAttribute("y", "35");
                rect.SetAttribute("width", "390");
                rect.SetAttribute("height", "150");
                rect.SetAttribute("fill", "url(#linearGradient)");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG linear gradient: {outputPath}");
        }

        public static void CreateRadialGradient()
        {
            // Create an SVG radial gradient in C#.
            // A single radial gradient can be reused by different SVG shapes in the same document.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "radial-gradient.svg");

            using (var document = CreateDocument(680, 260))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var gradient = AppendElement(document, defs, "radialGradient");
                gradient.SetAttribute("id", "radialGradient");
                gradient.SetAttribute("r", "70%");

                AppendStop(document, gradient, "0%", "silver");
                AppendStop(document, gradient, "55%", "darkgreen");
                AppendStop(document, gradient, "100%", "black");

                var rect = AppendElement(document, svg, "rect");
                rect.SetAttribute("x", "50");
                rect.SetAttribute("y", "55");
                rect.SetAttribute("width", "220");
                rect.SetAttribute("height", "150");
                rect.SetAttribute("fill", "url(#radialGradient)");

                var circle = AppendElement(document, svg, "circle");
                circle.SetAttribute("cx", "500");
                circle.SetAttribute("cy", "130");
                circle.SetAttribute("r", "90");
                circle.SetAttribute("fill", "url(#radialGradient)");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG radial gradient: {outputPath}");
        }

        public static void CreateMultipleGradientShapes()
        {
            // Create an SVG document with linear and radial gradients in C#.
            // This example demonstrates how to define several paint servers and reuse them on multiple shapes.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "multiple-gradients.svg");

            using (var document = CreateDocument(720, 320))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");

                var sky = AppendElement(document, defs, "linearGradient");
                sky.SetAttribute("id", "sky");
                sky.SetAttribute("x1", "0%");
                sky.SetAttribute("y1", "0%");
                sky.SetAttribute("x2", "100%");
                sky.SetAttribute("y2", "100%");
                AppendStop(document, sky, "0%", "#8ECAE6");
                AppendStop(document, sky, "100%", "#219EBC");

                var sun = AppendElement(document, defs, "radialGradient");
                sun.SetAttribute("id", "sun");
                sun.SetAttribute("cx", "35%");
                sun.SetAttribute("cy", "30%");
                sun.SetAttribute("r", "70%");
                AppendStop(document, sun, "0%", "#fff3b0");
                AppendStop(document, sun, "70%", "#ffb703");
                AppendStop(document, sun, "100%", "#fb8500");

                var background = AppendElement(document, svg, "rect");
                background.SetAttribute("width", "720");
                background.SetAttribute("height", "320");
                background.SetAttribute("fill", "url(#sky)");

                var circle = AppendElement(document, svg, "circle");
                circle.SetAttribute("cx", "190");
                circle.SetAttribute("cy", "130");
                circle.SetAttribute("r", "85");
                circle.SetAttribute("fill", "url(#sun)");

                var rect = AppendElement(document, svg, "rect");
                rect.SetAttribute("x", "370");
                rect.SetAttribute("y", "80");
                rect.SetAttribute("width", "210");
                rect.SetAttribute("height", "150");
                rect.SetAttribute("rx", "22");
                rect.SetAttribute("fill", "url(#sun)");
                rect.SetAttribute("stroke", "#023047");
                rect.SetAttribute("stroke-width", "6");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG with multiple gradients: {outputPath}");
        }

        private static SVGDocument CreateDocument(int width, int height)
        {
            var document = new SVGDocument();
            document.RootElement.SetAttribute("width", width.ToString());
            document.RootElement.SetAttribute("height", height.ToString());
            document.RootElement.SetAttribute("viewBox", $"0 0 {width} {height}");
            return document;
        }

        private static SVGElement AppendElement(SVGDocument document, SVGElement parent, string tagName)
        {
            var element = (SVGElement)document.CreateElementNS(SvgNamespace, tagName);
            parent.AppendChild(element);
            return element;
        }

        private static void AppendStop(SVGDocument document, SVGElement gradient, string offset, string color)
        {
            var stop = AppendElement(document, gradient, "stop");
            stop.SetAttribute("offset", offset);
            stop.SetAttribute("stop-color", color);
        }
    }
}
