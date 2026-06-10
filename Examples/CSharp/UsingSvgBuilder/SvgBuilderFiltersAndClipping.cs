using Aspose.Svg;
using Aspose.Svg.Builder;
using System;
using System.Drawing;
using System.IO;

namespace CSharp.UsingSvgBuilder
{
    class SvgBuilderFiltersAndClipping
    {
        public static void Run()
        {
            ApplyGaussianBlurWithBuilder();
            CreateDropShadowFilterWithBuilder();
            CreateClipPathWithBuilderApi();
            CreateCircularClipPathWithBuilder();
        }

        public static void ApplyGaussianBlurWithBuilder()
        {
            // Apply an SVG Gaussian blur filter with the Builder API.
            // The filter is created in <defs> and applied to selected shapes by FilterId().
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "gaussian-blur-builder.svg");

            using (var document = new SVGDocument("<svg xmlns=\"http://www.w3.org/2000/svg\"></svg>", "."))
            {
                var builder = new SVGSVGElementBuilder();
                builder.Attribute("width", "760");
                builder.Attribute("height", "220");
                builder.Attribute("viewBox", "0 0 760 220");

                builder.AddDefs(defs => defs
                    .AddFilter(filter => filter
                        .Id("soft-blur")
                        .AddFeGaussianBlur(blur => blur.StdDeviation(8, 8))));

                builder.AddRect(rect => rect
                    .X(30).Y(40).Width(150).Height(110)
                    .Fill(Color.FromArgb(255, 152, 0))
                    .Stroke(Color.FromArgb(121, 85, 72))
                    .StrokeWidth(3));

                builder.AddRect(rect => rect
                    .X(230).Y(40).Width(150).Height(110)
                    .Fill(Color.FromArgb(255, 152, 0))
                    .Stroke(Color.FromArgb(121, 85, 72))
                    .StrokeWidth(3)
                    .Filter(filter => filter.FilterId("soft-blur")));

                builder.AddCircle(circle => circle
                    .Cx(550).Cy(95).R(55)
                    .Fill(Color.Teal)
                    .Filter(filter => filter.FilterId("soft-blur")));

                builder.Build(document.RootElement);
                document.Save(outputPath);
            }

            Console.WriteLine($"Applied Gaussian blur with Builder API: {outputPath}");
        }

        public static void CreateDropShadowFilterWithBuilder()
        {
            // Create an SVG drop shadow filter with the Builder API.
            // This is a compact example of building filter primitives and applying the result to a shape.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "drop-shadow-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(340).Height(220)
                    .ViewBox(0, 0, 340, 220)
                    .AddDefs(defs => defs
                        .AddFilter(filter => filter
                            .Id("drop-shadow")
                            .AddFeDropShadow(dropShadow => dropShadow
                                .Dx(4)
                                .Dy(4)
                                .StdDeviation(5, 5))))
                    .AddRect(rect => rect
                        .X(50).Y(50).Width(200).Height(100)
                        .Fill(Color.FromArgb(255, 152, 0))
                        .Filter(filter => filter.FilterId("drop-shadow")))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created drop shadow with Builder API: {outputPath}");
        }

        public static void CreateClipPathWithBuilderApi()
        {
            // Create an SVG clip path with Builder API definitions.
            // The clip path is placed in <defs> and then referenced from a visible rectangle.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "clip-path-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(600).Height(400)
                    .ViewBox(0, 0, 600, 400)
                    .AddDefs(defs => defs
                        .AddClipPath(clipPath => clipPath
                            .Id("clip-circle")
                            .ClipPathUnits(CoordinateUnits.UserSpaceOnUse)
                            .AddCircle(circle => circle.Cx(150).Cy(150).R(100))))
                    .AddRect(rect => rect
                        .X(50).Y(70).Width(300).Height(200)
                        .Fill(Color.FromArgb(100, 181, 246))
                        .Stroke(Color.FromArgb(25, 118, 210))
                        .StrokeWidth(3)
                        .Attribute("clip-path", "url(#clip-circle)"))
                    .AddCircle(circle => circle
                        .Cx(300).Cy(150).R(80)
                        .Fill(Color.FromArgb(255, 152, 0))
                        .Stroke(Color.FromArgb(156, 39, 176))
                        .StrokeWidth(4))
                    .AddText(text => text
                        .X(100).Y(350)
                        .Fill(Color.FromArgb(33, 150, 243))
                        .FontSize(24)
                        .FontFamily("Arial")
                        .AddContent("Clip Path Example"))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG clip path with Builder API: {outputPath}");
        }

        public static void CreateCircularClipPathWithBuilder()
        {
            // Create a circular SVG clipping window with Builder API.
            // This example uses a manual builder variable, which is convenient when a document is assembled step by step.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "circular-clip-path-builder.svg");

            using (var document = new SVGDocument())
            {
                var builder = new SVGSVGElementBuilder();
                builder.Attribute("width", "440");
                builder.Attribute("height", "300");
                builder.Attribute("viewBox", "0 0 440 300");

                builder.AddDefs(defs => defs
                    .AddClipPath(clipPath => clipPath
                        .Id("circle-window")
                        .ClipPathUnits(CoordinateUnits.UserSpaceOnUse)
                        .AddCircle(circle => circle.Cx(220).Cy(150).R(110))));

                builder.AddRect(rect => rect.X(0).Y(10).Width(440).Height(300).Fill(Color.FromArgb(245, 247, 251)));
                builder.AddRect(rect => rect
                    .X(70).Y(60).Width(300).Height(220)
                    .Fill(Color.Teal)
                    .Attribute("clip-path", "url(#circle-window)"));

                builder.Build(document.RootElement);
                document.Save(outputPath);
            }

            Console.WriteLine($"Created circular SVG clip path with Builder API: {outputPath}");
        }
    }
}
