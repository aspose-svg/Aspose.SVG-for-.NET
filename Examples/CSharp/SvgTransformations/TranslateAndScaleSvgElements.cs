using Aspose.Svg;
using Aspose.Svg.Builder;
using System;
using System.IO;

namespace CSharp.SvgTransformations
{
    class TranslateAndScaleSvgElements
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            TranslateRectangle();
            TranslateExistingPath();
            ScaleCircle();
            ScaleExistingSvgDocument();
            ScaleSvgUsingBuilderApi();
        }

        public static void TranslateRectangle()
        {
            // Move an SVG rectangle in C# with translate().
            // The translate(x, y) transform shifts the rendered element by the specified offset.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "translate-rectangle.svg");

            using (var document = CreateDocument(360, 220))
            {
                var rect = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
                rect.X.BaseVal.Value = 50;
                rect.Y.BaseVal.Value = 50;
                rect.Width.BaseVal.Value = 100;
                rect.Height.BaseVal.Value = 100;
                rect.SetAttribute("fill", "blue");
                rect.SetAttribute("transform", "translate(150, 40)");
                document.RootElement.AppendChild(rect);

                document.Save(outputPath);
            }

            Console.WriteLine($"Translated SVG rectangle: {outputPath}");
        }

        public static void TranslateExistingPath()
        {
            // Move an existing SVG path element in C# with translate().
            // This example edits the transform attribute on the first <path> element in lineto.svg.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "lineto.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "translate-path.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var path = document.RootElement.QuerySelector("path") as SVGPathElement;
                if (path != null)
                {
                    path.SetAttribute("transform", "translate(80, 0)");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Translated SVG path element: {outputPath}");
        }

        public static void ScaleCircle()
        {
            // Scale an SVG circle in C# with scale().
            // Scaling affects the rendered size of the element while its original radius value remains unchanged.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "scale-circle.svg");

            using (var document = CreateDocument(420, 360))
            {
                var circle = (SVGCircleElement)document.CreateElementNS(SvgNamespace, "circle");
                circle.Cx.BaseVal.Value = 120;
                circle.Cy.BaseVal.Value = 120;
                circle.R.BaseVal.Value = 50;
                circle.SetAttribute("fill", "salmon");
                circle.SetAttribute("transform", "scale(2)");
                document.RootElement.AppendChild(circle);

                document.Save(outputPath);
            }

            Console.WriteLine($"Scaled SVG circle: {outputPath}");
        }

        public static void ScaleExistingSvgDocument()
        {
            // Scale an entire SVG document in C# by transforming the root <svg> element.
            // This approach is useful when you need to make all content render smaller or larger together.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "tree.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "scale-tree.svg");

            using (var document = new SVGDocument(inputPath))
            {
                document.RootElement.SetAttribute("transform", "scale(0.7)");
                document.Save(outputPath);
            }

            Console.WriteLine($"Scaled existing SVG document: {outputPath}");
        }

        public static void ScaleSvgUsingBuilderApi()
        {
            // Scale an SVG document with the Aspose.SVG Builder API.
            // The Transform builder creates the scale() transform for the root SVG element.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "shapes.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "scale-shapes-builder.svg");

            using (var document = new SVGDocument(inputPath))
            {
                new SVGSVGElementBuilder()
                    .Transform(transform => transform.Scale(0.5))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Scaled SVG document with Builder API: {outputPath}");
        }

        private static SVGDocument CreateDocument(int width, int height)
        {
            var document = new SVGDocument();
            document.RootElement.SetAttribute("width", width.ToString());
            document.RootElement.SetAttribute("height", height.ToString());
            document.RootElement.SetAttribute("viewBox", $"0 0 {width} {height}");
            return document;
        }
    }
}
