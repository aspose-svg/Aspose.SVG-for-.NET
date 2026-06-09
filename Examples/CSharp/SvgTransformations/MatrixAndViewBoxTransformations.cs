using Aspose.Svg;
using Aspose.Svg.DataTypes;
using System;
using System.Globalization;
using System.IO;

namespace CSharp.SvgTransformations
{
    class MatrixAndViewBoxTransformations
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            RotateRectangleWithMatrix();
            TranslateRectangleWithMatrix();
            CombineScaleTranslateRotateMatrix();
            CropSvgWithViewBox();
            SkewExistingSvgImage();
        }

        public static void RotateRectangleWithMatrix()
        {
            // Rotate an SVG rectangle in C# using an SVGMatrix.
            // Matrix transforms are useful when transforms must be calculated programmatically.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "rotate-rectangle-matrix.svg");

            using (var document = CreateDocument(360, 240))
            {
                var rect = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
                rect.X.BaseVal.Value = 150;
                rect.Y.BaseVal.Value = 50;
                rect.Width.BaseVal.Value = 100;
                rect.Height.BaseVal.Value = 100;
                rect.SetAttribute("fill", "purple");
                document.RootElement.AppendChild(rect);

                SVGMatrix matrix = rect.GetCTM().Rotate(45);
                rect.SetAttribute("transform", ToMatrixTransform(matrix));

                document.Save(outputPath);
            }

            Console.WriteLine($"Rotated SVG rectangle with matrix: {outputPath}");
        }

        public static void TranslateRectangleWithMatrix()
        {
            // Move an SVG rectangle in C# using a transformation matrix.
            // The SVGMatrix.Translate() method creates the same type of transform as translate(x, y).
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "translate-rectangle-matrix.svg");

            using (var document = CreateDocument(420, 240))
            {
                var rect = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
                rect.X.BaseVal.Value = 80;
                rect.Y.BaseVal.Value = 60;
                rect.Width.BaseVal.Value = 100;
                rect.Height.BaseVal.Value = 100;
                rect.SetAttribute("fill", "blue");
                document.RootElement.AppendChild(rect);

                SVGMatrix matrix = rect.GetCTM().Translate(150, 40);
                rect.SetAttribute("transform", ToMatrixTransform(matrix));

                document.Save(outputPath);
            }

            Console.WriteLine($"Translated SVG rectangle with matrix: {outputPath}");
        }

        public static void CombineScaleTranslateRotateMatrix()
        {
            // Combine scale, translate, and rotate transforms with SVGMatrix in C#.
            // Chained matrix operations make it possible to build complex transform values in code.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "snowflake.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "combined-transform-matrix.svg");

            using (var document = new SVGDocument(inputPath))
            {
                SVGMatrix matrix = document.RootElement.GetCTM()
                    .Scale(0.5F)
                    .Translate(250, 250)
                    .Rotate(20);

                document.RootElement.SetAttribute("transform", ToMatrixTransform(matrix));
                document.Save(outputPath);
            }

            Console.WriteLine($"Combined SVG transforms with matrix: {outputPath}");
        }

        public static void CropSvgWithViewBox()
        {
            // Crop an SVG image in C# by updating the viewBox attribute.
            // viewBox changes the visible coordinate area without deleting SVG content.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "shapes.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "crop-with-viewbox.svg");

            using (var document = new SVGDocument(inputPath))
            {
                document.RootElement.SetAttribute("viewBox", "20 20 200 220");
                document.Save(outputPath);
            }

            Console.WriteLine($"Cropped SVG with viewBox: {outputPath}");
        }

        public static void SkewExistingSvgImage()
        {
            // Skew an SVG image in C# using skewX().
            // Skew transforms slant the coordinate system and can be applied to the root SVG element or a child element.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "flower.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputTransformations(), "skew-flower.svg");

            using (var document = new SVGDocument(inputPath))
            {
                document.RootElement.SetAttribute("transform", "skewX(25)");
                document.Save(outputPath);
            }

            Console.WriteLine($"Skewed SVG image: {outputPath}");
        }

        private static SVGDocument CreateDocument(int width, int height)
        {
            var document = new SVGDocument();
            document.RootElement.SetAttribute("width", width.ToString());
            document.RootElement.SetAttribute("height", height.ToString());
            document.RootElement.SetAttribute("viewBox", $"0 0 {width} {height}");
            return document;
        }

        private static string ToMatrixTransform(SVGMatrix matrix)
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "matrix({0},{1},{2},{3},{4},{5})",
                matrix.A,
                matrix.B,
                matrix.C,
                matrix.D,
                matrix.E,
                matrix.F);
        }
    }
}
