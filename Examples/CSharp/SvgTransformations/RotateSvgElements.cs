using Aspose.Svg;
using Aspose.Svg.Builder;
using Aspose.Svg.Dom;
using System;
using System.IO;
using System.Linq;

namespace CSharp.SvgTransformations
{
    class RotateSvgElements
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            RotateRectangleWithTransformAttribute();
            RotateExistingRectangleAroundPoint();
            RotateRectangleUsingBuilderApi();
        }

        public static void RotateRectangleWithTransformAttribute()
        {
            // Rotate an SVG rectangle in C# using the transform attribute.
            // The rotate(angle) transform changes how the rectangle is rendered without changing its geometry values.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "rotate-rectangle.svg");

            using (var document = CreateDocument(320, 240))
            {
                var rect = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
                rect.X.BaseVal.Value = 120;
                rect.Y.BaseVal.Value = 55;
                rect.Width.BaseVal.Value = 100;
                rect.Height.BaseVal.Value = 100;
                rect.SetAttribute("fill", "purple");
                rect.SetAttribute("transform", "rotate(45)");
                document.RootElement.AppendChild(rect);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created rotated rectangle: {outputPath}");
        }

        public static void RotateExistingRectangleAroundPoint()
        {
            // Rotate an existing SVG rectangle around a fixed point in C#.
            // The rotate(angle, cx, cy) syntax keeps the transformation centered around a chosen coordinate.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "shapes.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "rotate-existing-rectangle.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var rect = document.RootElement.QuerySelector("rect") as SVGRectElement;
                if (rect != null)
                {
                    rect.SetAttribute("transform", "rotate(45, 100, 140)");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Rotated existing SVG rectangle: {outputPath}");
        }

        public static void RotateRectangleUsingBuilderApi()
        {
            // Rotate an SVG rectangle with the Aspose.SVG Builder API.
            // Builder classes provide a fluent way to apply transform functions to existing SVG elements.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "shapes.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "rotate-rectangle-builder.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var rect = document.GetElementsByTagName("rect").First() as SVGRectElement;
                if (rect != null)
                {
                    new SVGRectElementBuilder()
                        .Transform(transform => transform.Rotate(45, 100, 140))
                        .Build(rect);
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Rotated SVG rectangle with Builder API: {outputPath}");
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
