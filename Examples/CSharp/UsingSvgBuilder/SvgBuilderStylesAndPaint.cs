using Aspose.Svg;
using Aspose.Svg.Builder;
using System;
using System.Drawing;
using System.IO;

namespace CSharp.UsingSvgBuilder
{
    class SvgBuilderStylesAndPaint
    {
        public static void Run()
        {
            CreateCssRulesWithRuleBuilder();
            CreatePatternFillWithPaintBuilder();
            CreateLinearGradientFill();
            AddBackgroundToExistingSvg();
            AddSvgTextWithBuilderApi();
        }

        public static void CreateCssRulesWithRuleBuilder()
        {
            // Create SVG CSS rules in C# with Rule Builder.
            // Rule Builder keeps style declarations close to the SVG elements that use them.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "rule-builder-styles.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(800).Height(520)
                    .ViewBox(0, 0, 800, 520)
                    .AddStyle(style =>
                    {
                        style.Type("text/css");
                        style.AddRule(".canvas", rule => rule.Attribute("fill", "#f5f7fb"));
                        style.AddRule(".accent-card", rule =>
                        {
                            rule.Attribute("fill", "url(#cardGradient)");
                            rule.Attribute("stroke", "#1f4e79");
                            rule.Attribute("stroke-width", "4");
                            rule.Attribute("rx", "18");
                            rule.Attribute("ry", "18");
                        });
                        style.AddRule(".signal", rule =>
                        {
                            rule.Attribute("fill", "#ff9800");
                            rule.Attribute("stroke", "#7a3b00");
                            rule.Attribute("stroke-width", "3");
                            rule.Attribute("opacity", "0.9");
                        });
                    })
                    .AddDefs(defs => defs
                        .AddLinearGradient(gradient => gradient
                            .Id("cardGradient")
                            .X1(0).Y1(0).X2(1).Y2(1)
                            .AddStop(stop => stop.Offset(0).StopColor(Color.FromArgb(100, 181, 246)))
                            .AddStop(stop => stop.Offset(1).StopColor(Color.FromArgb(21, 101, 192)))))
                    .AddRect(rect => rect.X(0).Y(0).Width(800).Height(520).Attribute("class", "canvas"))
                    .AddRect(rect => rect.X(80).Y(80).Width(420).Height(240).Attribute("class", "accent-card"))
                    .AddCircle(circle => circle.Cx(590).Cy(180).R(70).Attribute("class", "signal"))
                    .AddEllipse(ellipse => ellipse.Cx(600).Cy(340).Rx(120).Ry(45).Fill(Color.Teal).Stroke(Color.FromArgb(80, 132, 132)).StrokeWidth(3))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG CSS rules with Rule Builder: {outputPath}");
        }

        public static void CreatePatternFillWithPaintBuilder()
        {
            // Create reusable SVG patterns and use them as paint servers in C#.
            // Paint Builder can reference pattern, gradient, and other paint server IDs without hand-writing url(#id).
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "pattern-fill-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(100, LengthType.Percentage)
                    .Height(100, LengthType.Percentage)
                    .ViewBox(0, 0, 600, 260)
                    .AddG(group => group
                        .FontFamily("Arial")
                        .FontSize(10)
                        .AddPattern(pattern => pattern.Id("checker")
                            .Rect(0, 0, 20, 20)
                            .PatternUnits(CoordinateUnits.UserSpaceOnUse)
                            .AddRect(rect => rect.Rect(0, 0, 10, 10).Fill(Color.LightSlateGray))
                            .AddRect(rect => rect.Rect(10, 0, 10, 10).Fill(Color.Teal))
                            .AddRect(rect => rect.Rect(0, 10, 10, 10).Fill(Color.DarkRed))
                            .AddRect(rect => rect.Rect(10, 10, 10, 10).Fill(Color.Gold)))
                        .AddPattern(pattern => pattern.Id("checkerLarge").Href("#checker").Width(28).Height(28))
                        .AddCircle(circle => circle.Cx(120).Cy(130).R(80).Fill(paint => paint.PaintServerId("checker")))
                        .AddCircle(circle => circle.Cx(320).Cy(130).R(80).Fill(paint => paint.PaintServerId("checkerLarge")))
                        .AddText(text => text.X(75).Y(35).AddContent("Pattern #checker"))
                        .AddText(text => text.X(265).Y(35).AddContent("Pattern #checkerLarge")))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG pattern fill with Paint Builder: {outputPath}");
        }

        public static void CreateLinearGradientFill()
        {
            // Create an SVG linear gradient fill with the Builder API.
            // The gradient is defined in <defs> and then used by a rectangle through PaintServerId().
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "linear-gradient-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(400).Height(200)
                    .ViewBox(0, 0, 400, 200)
                    .AddDefs(defs => defs
                        .AddLinearGradient(gradient => gradient
                            .Id("gradientFill")
                            .X1(0, LengthType.Percentage).Y1(0, LengthType.Percentage)
                            .X2(100, LengthType.Percentage).Y2(0, LengthType.Percentage)
                            .AddStop(stop => stop.Offset(0, StopUnitType.Percentage).Attribute("stop-color", "gold"))
                            .AddStop(stop => stop.Offset(100, StopUnitType.Percentage).Attribute("stop-color", "teal"))))
                    .AddRect(rect => rect
                        .Rect(20, 20, 360, 160)
                        .Fill(paint => paint.PaintServerId("gradientFill"))
                        .Stroke(Color.Black)
                        .StrokeWidth(2))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG linear gradient with Builder API: {outputPath}");
        }

        public static void AddBackgroundToExistingSvg()
        {
            // Change an SVG background color in C# by inserting a Builder-created group.
            // The original SVG content remains in place while the background layer is inserted before it.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "tulips.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "background-builder.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var svg = new SVGSVGElementBuilder()
                    .Width(100, LengthType.Percentage)
                    .Height(100, LengthType.Percentage)
                    .Build(document.RootElement);

                var background = new SVGGElementBuilder()
                    .Id("background")
                    .AddStyle(style => style
                        .Type("text/css")
                        .AddRule(".background", rule => rule.Fill(Color.LightGray)))
                    .AddRect(rect => rect
                        .X(-120).Y(0)
                        .Width(100, LengthType.Percentage)
                        .Height(100, LengthType.Percentage)
                        .Class("background"))
                    .BuildElement(document);

                svg.InsertBefore(background, svg.FirstElementChild);
                document.Save(outputPath);
            }

            Console.WriteLine($"Added SVG background with Builder API: {outputPath}");
        }

        public static void AddSvgTextWithBuilderApi()
        {
            // Add SVG text nodes with Builder API overloads.
            // This example uses both the short AddText() overload and the fluent text element builder.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "text-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(640).Height(260)
                    .ViewBox(0, 0, 640, 260)
                    .AddRect(rect => rect.X(0).Y(0).Width(640).Height(260).Fill(Color.FromArgb(245, 247, 251)))
                    .AddText(
                        "Aspose.SVG Builder Text",
                        60,
                        110,
                        34,
                        null,
                        "Arial",
                        null,
                        Color.Teal,
                        Color.FromArgb(0, 96, 96),
                        "headline",
                        text => text.TextAnchor(TextAnchor.Start))
                    .AddText(text => text
                        .X(60)
                        .Y(170)
                        .FontSize(22)
                        .FontFamily("Arial")
                        .Fill(Color.FromArgb(80, 80, 80))
                        .AddContent("Text content added through AddContent."))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Added SVG text with Builder API: {outputPath}");
        }
    }
}
