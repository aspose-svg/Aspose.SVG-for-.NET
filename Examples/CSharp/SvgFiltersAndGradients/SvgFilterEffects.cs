using Aspose.Svg;
using System;
using System.IO;

namespace CSharp.SvgFiltersAndGradients
{
    class SvgFilterEffects
    {
        private const string SvgNamespace = "http://www.w3.org/2000/svg";

        public static void Run()
        {
            ApplyGaussianBlurToImage();
            ApplyGaussianBlurToRectangle();
            ApplySaturationFilterToImage();
            ApplyHueRotateFilterToImage();
            ApplyRgbaComponentTransfer();
            AddDropShadowToRectangle();
            AddDropShadowToText();
            CreateSpecularLightingEffect();
        }

        public static void ApplyGaussianBlurToImage()
        {
            // Apply Gaussian blur to an SVG image in C#.
            // This example creates <filter> and <feGaussianBlur> elements and applies the filter to an <image>.
            string imageHref = GetOutputRelativeImageHref("seaside.jpg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "gaussian-blur-image.svg");

            using (var document = CreateDocument(700, 540))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var filter = AppendElement(document, defs, "filter");
                filter.SetAttribute("id", "blur");

                var blur = AppendElement(document, filter, "feGaussianBlur");
                blur.SetAttribute("in", "SourceGraphic");
                blur.SetAttribute("stdDeviation", "5");

                var image = AppendElement(document, svg, "image");
                image.SetAttribute("href", imageHref);
                image.SetAttribute("x", "20");
                image.SetAttribute("y", "20");
                image.SetAttribute("width", "640");
                image.SetAttribute("height", "480");
                image.SetAttribute("filter", "url(#blur)");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created Gaussian blur image filter: {outputPath}");
        }

        public static void ApplyGaussianBlurToRectangle()
        {
            // Apply Gaussian blur to an SVG rectangle in C#.
            // Filter region attributes control how far the blurred pixels may extend beyond the source shape.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "gaussian-blur-rectangle.svg");

            using (var document = CreateDocument(240, 180))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var filter = AppendElement(document, defs, "filter");
                filter.SetAttribute("id", "rectBlur");
                filter.SetAttribute("x", "-20%");
                filter.SetAttribute("y", "-20%");
                filter.SetAttribute("width", "140%");
                filter.SetAttribute("height", "140%");

                var blur = AppendElement(document, filter, "feGaussianBlur");
                blur.SetAttribute("in", "SourceGraphic");
                blur.SetAttribute("stdDeviation", "8");

                var rect = AppendElement(document, svg, "rect");
                rect.SetAttribute("x", "60");
                rect.SetAttribute("y", "45");
                rect.SetAttribute("width", "120");
                rect.SetAttribute("height", "80");
                rect.SetAttribute("fill", "#FB8500");
                rect.SetAttribute("filter", "url(#rectBlur)");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created Gaussian blur rectangle filter: {outputPath}");
        }

        public static void ApplySaturationFilterToImage()
        {
            // Apply an SVG saturation filter to an image in C#.
            // feColorMatrix with type="saturate" increases or decreases image color intensity.
            CreateColorMatrixImageFilter("saturation", "saturate", "2", "lighthouse.jpg", "saturation-filter.svg");
        }

        public static void ApplyHueRotateFilterToImage()
        {
            // Apply an SVG hue-rotate filter to an image in C#.
            // feColorMatrix with type="hueRotate" shifts image colors around the color wheel.
            CreateColorMatrixImageFilter("hueRotate", "hueRotate", "150", "lighthouse.jpg", "hue-rotate-filter.svg");
        }

        public static void ApplyRgbaComponentTransfer()
        {
            // Adjust SVG image RGBA channels in C# with feComponentTransfer.
            // Component transfer functions let you control red, green, blue, and alpha channels independently.
            string imageHref = GetOutputRelativeImageHref("seaside.jpg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "rgba-component-transfer.svg");

            using (var document = CreateDocument(540, 700))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var filter = AppendElement(document, defs, "filter");
                filter.SetAttribute("id", "rgba");

                var transfer = AppendElement(document, filter, "feComponentTransfer");
                AppendChannelFunction(document, transfer, "feFuncR", "1.1");
                AppendChannelFunction(document, transfer, "feFuncG", "1.5");
                AppendChannelFunction(document, transfer, "feFuncB", "2.0");
                var alpha = AppendElement(document, transfer, "feFuncA");
                alpha.SetAttribute("type", "identity");

                var image = AppendElement(document, svg, "image");
                image.SetAttribute("href", imageHref);
                image.SetAttribute("x", "20");
                image.SetAttribute("y", "20");
                image.SetAttribute("width", "480");
                image.SetAttribute("height", "640");
                image.SetAttribute("filter", "url(#rgba)");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created RGBA component transfer filter: {outputPath}");
        }

        public static void AddDropShadowToRectangle()
        {
            // Add a drop shadow filter to an SVG rectangle in C#.
            // feDropShadow is a compact primitive for offset, blur, and shadow color.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "rectangle-drop-shadow.svg");

            using (var document = CreateDocument(260, 200))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var filter = AppendElement(document, defs, "filter");
                filter.SetAttribute("id", "shadow");
                filter.SetAttribute("x", "-20%");
                filter.SetAttribute("y", "-20%");
                filter.SetAttribute("width", "140%");
                filter.SetAttribute("height", "140%");

                var shadow = AppendElement(document, filter, "feDropShadow");
                shadow.SetAttribute("dx", "10");
                shadow.SetAttribute("dy", "10");
                shadow.SetAttribute("stdDeviation", "3");
                shadow.SetAttribute("flood-color", "CornflowerBlue");

                var rect = AppendElement(document, svg, "rect");
                rect.SetAttribute("x", "50");
                rect.SetAttribute("y", "45");
                rect.SetAttribute("width", "120");
                rect.SetAttribute("height", "90");
                rect.SetAttribute("fill", "#ffa500");
                rect.SetAttribute("filter", "url(#shadow)");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created rectangle drop shadow: {outputPath}");
        }

        public static void AddDropShadowToText()
        {
            // Add a colored drop shadow to SVG text in C#.
            // Text filters are useful for headings, captions, labels, and generated SVG badges.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "text-drop-shadow.svg");

            using (var document = CreateDocument(560, 160))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var filter = AppendElement(document, defs, "filter");
                filter.SetAttribute("id", "textShadow");
                filter.SetAttribute("x", "-20%");
                filter.SetAttribute("y", "-20%");
                filter.SetAttribute("width", "140%");
                filter.SetAttribute("height", "140%");

                var shadow = AppendElement(document, filter, "feDropShadow");
                shadow.SetAttribute("dx", "3");
                shadow.SetAttribute("dy", "3");
                shadow.SetAttribute("stdDeviation", "3");
                shadow.SetAttribute("flood-color", "LightCoral");

                var text = AppendElement(document, svg, "text");
                text.SetAttribute("x", "24");
                text.SetAttribute("y", "95");
                text.SetAttribute("fill", "CornflowerBlue");
                text.SetAttribute("font-size", "48");
                text.SetAttribute("font-family", "Arial");
                text.SetAttribute("filter", "url(#textShadow)");
                text.TextContent = "Drop Shadow Effect";

                document.Save(outputPath);
            }

            Console.WriteLine($"Created text drop shadow: {outputPath}");
        }

        public static void CreateSpecularLightingEffect()
        {
            // Create an SVG specular lighting filter in C#.
            // feSpecularLighting and fePointLight can simulate a light source on SVG shapes.
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), "specular-lighting.svg");

            using (var document = CreateDocument(260, 240))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var filter = AppendElement(document, defs, "filter");
                filter.SetAttribute("id", "light");

                var blur = AppendElement(document, filter, "feGaussianBlur");
                blur.SetAttribute("in", "SourceAlpha");
                blur.SetAttribute("stdDeviation", "5");
                blur.SetAttribute("result", "blur");

                var lighting = AppendElement(document, filter, "feSpecularLighting");
                lighting.SetAttribute("in", "blur");
                lighting.SetAttribute("result", "light");
                lighting.SetAttribute("specularExponent", "30");
                lighting.SetAttribute("lighting-color", "#dddddd");

                var pointLight = AppendElement(document, lighting, "fePointLight");
                pointLight.SetAttribute("x", "70");
                pointLight.SetAttribute("y", "70");
                pointLight.SetAttribute("z", "150");

                var composite = AppendElement(document, filter, "feComposite");
                composite.SetAttribute("in", "SourceGraphic");
                composite.SetAttribute("in2", "light");
                composite.SetAttribute("operator", "arithmetic");
                composite.SetAttribute("k1", "0");
                composite.SetAttribute("k2", "1");
                composite.SetAttribute("k3", "1");
                composite.SetAttribute("k4", "0");

                var rect = AppendElement(document, svg, "rect");
                rect.SetAttribute("x", "45");
                rect.SetAttribute("y", "45");
                rect.SetAttribute("width", "150");
                rect.SetAttribute("height", "150");
                rect.SetAttribute("fill", "Teal");
                rect.SetAttribute("filter", "url(#light)");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created specular lighting filter: {outputPath}");
        }

        private static void CreateColorMatrixImageFilter(string filterId, string type, string values, string imageFileName, string outputFileName)
        {
            string imageHref = GetOutputRelativeImageHref(imageFileName);
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputFiltersAndGradients(), outputFileName);

            using (var document = CreateDocument(380, 500))
            {
                var svg = document.RootElement;
                var defs = AppendElement(document, svg, "defs");
                var filter = AppendElement(document, defs, "filter");
                filter.SetAttribute("id", filterId);

                var colorMatrix = AppendElement(document, filter, "feColorMatrix");
                colorMatrix.SetAttribute("in", "SourceGraphic");
                colorMatrix.SetAttribute("type", type);
                colorMatrix.SetAttribute("values", values);

                var image = AppendElement(document, svg, "image");
                image.SetAttribute("href", imageHref);
                image.SetAttribute("x", "20");
                image.SetAttribute("y", "20");
                image.SetAttribute("width", "330");
                image.SetAttribute("height", "440");
                image.SetAttribute("filter", $"url(#{filterId})");

                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG color matrix filter: {outputPath}");
        }

        private static SVGDocument CreateDocument(int width, int height)
        {
            var document = new SVGDocument();
            document.RootElement.SetAttribute("width", width.ToString());
            document.RootElement.SetAttribute("height", height.ToString());
            document.RootElement.SetAttribute("viewBox", $"0 0 {width} {height}");
            return document;
        }

        private static string GetOutputRelativeImageHref(string imageFileName)
        {
            string imagePath = Path.Combine(RunExamples.GetDataDir_SVG(), imageFileName);
            string outputDir = RunExamples.GetDataDir_OutputFiltersAndGradients();
            return Path.GetRelativePath(outputDir, imagePath).Replace(Path.DirectorySeparatorChar, '/');
        }

        private static SVGElement AppendElement(SVGDocument document, SVGElement parent, string tagName)
        {
            var element = (SVGElement)document.CreateElementNS(SvgNamespace, tagName);
            parent.AppendChild(element);
            return element;
        }

        private static void AppendChannelFunction(SVGDocument document, SVGElement transfer, string tagName, string slope)
        {
            var function = AppendElement(document, transfer, tagName);
            function.SetAttribute("type", "linear");
            function.SetAttribute("slope", slope);
        }
    }
}
