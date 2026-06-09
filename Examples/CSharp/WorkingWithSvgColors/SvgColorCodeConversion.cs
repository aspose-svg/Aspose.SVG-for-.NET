using Aspose.Svg;
using Aspose.Svg.Drawing;
using System;
using System.IO;

namespace CSharp.WorkingWithSvgColors
{
    class SvgColorCodeConversion
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            ConvertHexToRgb();
            ConvertRgbaToHsla();
            ConvertLabToCmyk();
            CreateConvertedColorPaletteSvg();
        }

        public static void ConvertHexToRgb()
        {
            // Convert a HEX color value to RGB format in C#.
            // Aspose.SVG color utilities can parse CSS-like color strings and output another color notation.
            Color color = Color.FromString("#ff31ca");
            string rgbColor = color.ToRgbString();

            Console.WriteLine($"HEX #ff31ca -> {rgbColor}");
        }

        public static void ConvertRgbaToHsla()
        {
            // Convert an RGBA color value to HSLA format in C#.
            // This is useful when color editing is easier by hue, saturation, and lightness.
            Color color = Color.FromRgba(222f / 255f, 180f / 255f, 135f / 255f, 0.5f);
            string hslaColor = color.Convert(ColorModel.Hsl).ToString(true, false, 3);

            Console.WriteLine($"RGBA rgba(222, 180, 135, 0.5) -> {hslaColor}");
        }

        public static void ConvertLabToCmyk()
        {
            // Convert a LAB color value to CMYK format in C#.
            // Color model conversion helps prepare SVG colors for different publishing workflows.
            Color color = Color.FromLab(51.788f, 62.357f, 52.178f);
            string cmykColor = color.Convert(ColorModel.Cmyk).ToString(false, false, 0);

            Console.WriteLine($"LAB lab(51.788, 62.357, 52.178) -> {cmykColor}");
        }

        public static void CreateConvertedColorPaletteSvg()
        {
            // Create a small SVG palette after converting color values in C#.
            // The generated SVG stores visible swatches and text labels for converted color strings.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputColors(), "converted-color-palette.svg");

            Color hexColor = Color.FromString("#ff31ca");
            Color rgbaColor = Color.FromRgba(222f / 255f, 180f / 255f, 135f / 255f, 0.5f);
            Color labColor = Color.FromLab(51.788f, 62.357f, 52.178f);

            using (var document = new SVGDocument())
            {
                var svg = document.RootElement;
                svg.SetAttribute("width", "760");
                svg.SetAttribute("height", "260");
                svg.SetAttribute("viewBox", "0 0 760 260");

                AddSwatch(document, 40, 40, "#ff31ca", hexColor.ToRgbString());
                AddSwatch(document, 40, 110, "rgba(222, 180, 135, 0.5)", rgbaColor.Convert(ColorModel.Hsl).ToString(true, false, 3));
                AddSwatch(document, 40, 180, "#c7351f", labColor.Convert(ColorModel.Cmyk).ToString(false, false, 0));

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG color conversion palette: {outputPath}");
        }

        private static void AddSwatch(SVGDocument document, int x, int y, string fill, string label)
        {
            var rect = document.CreateElementNS(SvgNamespace, "rect");
            rect.SetAttribute("x", x.ToString());
            rect.SetAttribute("y", y.ToString());
            rect.SetAttribute("width", "120");
            rect.SetAttribute("height", "40");
            rect.SetAttribute("fill", fill);
            rect.SetAttribute("stroke", "#333333");
            document.RootElement.AppendChild(rect);

            var text = document.CreateElementNS(SvgNamespace, "text");
            text.SetAttribute("x", (x + 150).ToString());
            text.SetAttribute("y", (y + 27).ToString());
            text.SetAttribute("font-family", "Arial, sans-serif");
            text.SetAttribute("font-size", "18");
            text.SetAttribute("fill", "#333333");
            text.TextContent = label;
            document.RootElement.AppendChild(text);
        }
    }
}
