using Aspose.Svg;
using Aspose.Svg.Builder;
using System;
using System.Drawing;
using System.IO;

namespace CSharp.UsingSvgBuilder
{
    class SvgBuilderShapesAndPaths
    {
        public static void Run()
        {
            CreateBasicSvgShapes();
            CreateSvgPathWithPathBuilder();
            CreateBezierCurveWithPathBuilder();
            CombinePathSegments();
            CreateTextAlongPath();
        }

        public static void CreateBasicSvgShapes()
        {
            // Create basic SVG shapes in C# with element builders.
            // This example demonstrates rect, circle, ellipse, line, polygon, polyline, path, and text in one SVG.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "basic-shapes-builder.svg");

            using (var document = new SVGDocument("<svg xmlns=\"http://www.w3.org/2000/svg\"></svg>", "."))
            {
                new SVGSVGElementBuilder()
                    .Width(100, LengthType.Percentage)
                    .Height(100, LengthType.Percentage)
                    .ViewBox(0, 0, 800, 800)
                    .AddG(group => group.FontSize(20).TextAnchor(TextAnchor.End)
                        .AddText("<rect>", y: 30)
                        .AddText("<circle>", y: 70)
                        .AddText("<ellipse>", y: 110)
                        .AddText("<line>", y: 150)
                        .AddText("<polyline>", x: 300, y: 30)
                        .AddText("<polygon>", x: 300, y: 70)
                        .AddText("<path>", x: 300, y: 110))
                    .AddG(group => group.Fill(Color.Teal).StrokeWidth(3)
                        .AddRect(rect => rect.X(35).Y(5).Width(30).Height(30))
                        .AddCircle(circle => circle.Cx(50).Cy(60).R(17))
                        .AddEllipse(ellipse => ellipse.Cx(50).Cy(100).Rx(25).Ry(12))
                        .AddLine(line => line.X1(30).X2(70).Y1(140).Y2(140).Stroke(Color.Teal)))
                    .AddG(group => group.Fill(Paint.None).StrokeWidth(3).Stroke(Color.Teal).Transform(transform => transform.Translate(300, -160))
                        .AddPolygon(points: new double[] { 30, 215, 90, 215, 120, 230, 70, 240, 30, 215 }, fill: Color.Teal)
                        .AddPolyline(points: new double[] { 30, 200, 65, 170, 90, 190, 120, 180 })
                        .AddPath(d: path => path.M(30, 275).Q(55, 250, 70, 250).T(80, 275).T(120, 260)))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created basic SVG shapes with Builder API: {outputPath}");
        }

        public static void CreateSvgPathWithPathBuilder()
        {
            // Create an SVG path in C# with Path Builder commands.
            // The fluent D() builder maps directly to SVG path data commands such as M, L, Q, C, and Z.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "path-builder-line.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(200).Height(200)
                    .ViewBox(0, 0, 150, 150)
                    .AddPath(path => path
                        .D(d => d.M(50, 50).L(100, 50).L(100, 100).Z())
                        .Fill(Color.Teal))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG path with Path Builder: {outputPath}");
        }

        public static void CreateBezierCurveWithPathBuilder()
        {
            // Create SVG curves and Bezier paths with the Builder API.
            // This example combines cubic and smooth cubic commands in a calculated path.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "bezier-curve-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(640).Height(360)
                    .ViewBox(0, 0, 640, 360)
                    .AddRect(rect => rect.X(0).Y(0).Width(640).Height(360).Fill(Color.FromArgb(245, 245, 245)))
                    .AddPath(path => path
                        .D(d => d.M(60, 260).C(140, 80, 260, 80, 340, 260).S(520, 440, 580, 160))
                        .Fill(Paint.None)
                        .Stroke(Color.FromArgb(25, 118, 210))
                        .StrokeWidth(8))
                    .AddCircle(circle => circle.Cx(60).Cy(260).R(8).Fill(Color.FromArgb(255, 152, 0)))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created Bezier curve with Path Builder: {outputPath}");
        }

        public static void CombinePathSegments()
        {
            // Combine raw SVG path segments with Path Builder in C#.
            // AddPathSegment() is helpful when a path command is easier to reuse as SVG path syntax.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "combined-path-segments-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(400).Height(400)
                    .ViewBox(0, 0, 300, 300)
                    .AddPath(path => path
                        .Fill(Color.CadetBlue)
                        .Stroke(Color.Red)
                        .StrokeWidth(2)
                        .D(d => d
                            .AddPathSegment("M40 120")
                            .AddPathSegment("C70 20 140 20 170 120")
                            .AddPathSegment("S270 220 300 120")
                            .AddPathSegment("Q250 180 170 170")
                            .AddPathSegment("Q90 160 40 120")))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Combined SVG path segments with Builder API: {outputPath}");
        }

        public static void CreateTextAlongPath()
        {
            // Create SVG text along paths in C# with textPath and Path Builder.
            // The Builder API can define path geometry and then bind text to that path by href.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputBuilder(), "text-path-builder.svg");

            using (var document = new SVGDocument())
            {
                new SVGSVGElementBuilder()
                    .Width(1200).Height(300)
                    .ViewBox(0, 0, 1200, 300)
                    .AddPath(path => path.Id("Path1")
                        .Fill(Paint.None)
                        .Stroke(Color.IndianRed)
                        .Transform(transform => transform.Translate(-100, 40))
                        .D(d => d.AddPathSegment("M 199 89 C 206 66 235 25 270 30 286 38 298 59 310 73 321 87 338 99 356 103 387 111 396 90 410 85")))
                    .AddPath(path => path.Id("Path2")
                        .Fill(Paint.None)
                        .Stroke(Paint.None)
                        .Transform(transform => transform.Translate(400, -100))
                        .D(d => d.M(80, 210).Q(95, 110, 200, 200).T(400, 200)))
                    .AddText(text => text.FontSize(30).Fill(Color.Teal)
                        .AddTextPath(textPath => textPath.Href("#Path1").AddContent("SVG textPath element"))
                        .AddTextPath(textPath => textPath.Href("#Path2").AddContent("SVG can place text along a path")))
                    .Build(document.RootElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG text along a path with Builder API: {outputPath}");
        }
    }
}
