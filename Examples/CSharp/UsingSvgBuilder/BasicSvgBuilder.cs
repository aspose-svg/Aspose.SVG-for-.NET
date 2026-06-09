using Aspose.Svg;
using Aspose.Svg.Builder;
using System;
using System.Drawing;
using System.IO;

namespace CSharp.UsingSvgBuilder
{
    class BasicSvgBuilder
    {
        public static void Run()
        {
            CreateSvgFromScratch();
            CreateComplexSvgWithBuilderApi();
            AddShapesToExistingSvg();
            ModifyExistingSvgElement();
        }

        public static void CreateSvgFromScratch()
        {
            // Create an SVG document from scratch in C# with the Aspose.SVG Builder API.
            // This example shows how to define the root <svg>, a group, a circle, and text in fluent code.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "svg-from-scratch.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(700).Height(300)
                    .ViewBox(0, 0, 700, 300)
                    .AddG(g => g
                        .AddCircle(circle => circle
                            .Cx(130).Cy(130).R(60)
                            .Fill(Paint.None)
                            .Stroke(Color.FromArgb(200, 0, 0))
                            .StrokeWidth(70)
                            .StrokeDashArray(2, 14))
                        .AddText("Create SVG from scratch with Builder API", x: 270, y: 140, fontSize: 30, fill: Color.Teal))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG from scratch: {outputPath}");
        }

        public static void CreateComplexSvgWithBuilderApi()
        {
            // Create a more complex SVG image with gradients, reusable groups, paths, and <use> elements.
            // The Builder API keeps nested SVG structure readable even when the document contains <defs> and references.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "complex-face-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(100).Height(100)
                    .ViewBox(-21, -21, 42, 42)
                    .AddDefs(def => def
                        .AddRadialGradient(id: "highlight", cx: .2, cy: .2, r: .5, fx: .2, fy: .2, extend: gradient => gradient
                            .AddStop(offset: 0, stopColor: Color.White, stopOpacity: .7)
                            .AddStop(offset: 1, stopColor: Color.White, stopOpacity: 0))
                        .AddRadialGradient(id: "faceFill", cx: .5, cy: .5, r: .5, extend: gradient => gradient
                            .AddStop(offset: 0, stopColor: Color.Gold)
                            .AddStop(offset: .75, stopColor: Color.Gold)
                            .AddStop(offset: .95, stopColor: Color.FromArgb(238, 238, 0))
                            .AddStop(offset: 1, stopColor: Color.FromArgb(232, 232, 0))))
                    .AddCircle(r: 20, fill: "url(#faceFill)", stroke: Color.Black, extend: circle => circle.StrokeWidth(.15))
                    .AddCircle(r: 20, fill: "url(#highlight)")
                    .AddG(group => group.Id("eyeAndSmile")
                        .AddEllipse(cx: -6, cy: -7, rx: 2.5, ry: 4)
                        .AddPath(fill: Paint.None, stroke: Color.Black, d: "M10.6 2.7a4 4 0 0 0 4 3", extend: path => path
                            .StrokeWidth(.5)
                            .StrokeLineCap(StrokeLineCap.Round)))
                    .AddUse(href: "#eyeAndSmile", extend: use => use.Transform(transform => transform.Scale(-1, 1)))
                    .AddPath(d: "M-12 5a13.5 13.5 0 0 0 24 0 13 13 0 0 1-24 0", fill: Paint.None, stroke: Color.Black, extend: path => path.StrokeWidth(.75))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created complex SVG with Builder API: {outputPath}");
        }

        public static void AddShapesToExistingSvg()
        {
            // Add new SVG elements to an existing document with element-specific builders.
            // This pattern is useful when you need to enhance an SVG file without manually creating DOM attributes.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "circles.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "circles-add-shapes-builder.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var circle = new SVGCircleElementBuilder()
                    .Cx(350).Cy(70).R(50)
                    .Fill(Paint.None)
                    .Stroke(Color.FromArgb(80, 132, 132))
                    .StrokeWidth(10)
                    .Build(document);

                var polyline = new SVGPolylineElementBuilder()
                    .Points(new double[] { 125, 130, 275, 180, 425, 130 })
                    .Stroke(Color.FromArgb(80, 132, 132))
                    .Fill(Paint.None)
                    .StrokeWidth(10)
                    .Build(document);

                document.RootElement.AppendChild(circle);
                document.RootElement.AppendChild(polyline);
                document.Save(outputPath);
            }

            Console.WriteLine($"Added SVG shapes with Builder API: {outputPath}");
        }

        public static void ModifyExistingSvgElement()
        {
            // Modify an existing SVG element with a builder instead of editing each attribute separately.
            // The builder can be used both for creating new nodes and for updating nodes already in the DOM.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "circles.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "circles-modified-builder.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var circle = document.QuerySelector("circle") as SVGCircleElement;
                if (circle != null)
                {
                    new SVGCircleElementBuilder()
                        .Stroke(Color.DarkRed)
                        .Fill(Color.LightGray)
                        .StrokeWidth(8)
                        .Build(circle);
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Modified existing SVG element with Builder API: {outputPath}");
        }
    }
}
