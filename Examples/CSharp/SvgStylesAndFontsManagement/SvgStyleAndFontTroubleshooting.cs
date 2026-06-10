using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Dom;
using Aspose.Svg.Dom.Css;
using Aspose.Svg.Saving;
using Aspose.Svg.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp.SvgStylesAndFontsManagement
{
    class SvgStyleAndFontTroubleshooting
    {
        public static void Run()
        {
            RemoveAllInlineStyles();
            RemoveConflictingInlineCssProperties();
            NormalizeNestedTspanStyles();
            ApplyStylesToTextAndTspanElements();
            RegisterFontsBeforePdfConversion();
        }

        public static void RemoveAllInlineStyles()
        {
            // Remove all inline style attributes from an SVG document in C#.
            // This is useful when design-tool SVG output blocks global CSS rules.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "text.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "inline-styles-removed.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var nodes = document.QuerySelectorAll("[style]");
                foreach (Node node in nodes)
                {
                    if (node is Element element)
                    {
                        element.RemoveAttribute("style");
                    }
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Removed all inline SVG styles: {outputPath}");
        }

        public static void RemoveConflictingInlineCssProperties()
        {
            // Remove specific conflicting inline CSS properties from SVG elements in C#.
            // Keeping non-conflicting declarations helps preserve design details while allowing new style rules.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "text.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "inline-css-properties-cleaned.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var nodes = document.QuerySelectorAll("[style]");
                foreach (Node node in nodes)
                {
                    if (node is IElementCSSInlineStyle styledElement)
                    {
                        ICSSStyleDeclaration style = styledElement.Style;
                        style.RemoveProperty("fill");
                        style.RemoveProperty("stroke");
                        style.RemoveProperty("font-family");
                        style.RemoveProperty("font-size");

                        if (style.Length == 0 && node is Element element)
                        {
                            element.RemoveAttribute("style");
                        }
                    }
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Removed conflicting inline CSS properties: {outputPath}");
        }

        public static void NormalizeNestedTspanStyles()
        {
            // Normalize inline styles in nested SVG <tspan> elements in C#.
            // Nested text spans may override parent text styling, so conflicting properties are removed selectively.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "text.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "tspan-styles-normalized.svg");

            using (var document = new SVGDocument(inputPath))
            {
                foreach (Node node in document.QuerySelectorAll("tspan"))
                {
                    if (node is Element element && element.HasAttribute("style"))
                    {
                        string style = element.GetAttribute("style");
                        style = RemoveCssProperty(style, "fill");
                        style = RemoveCssProperty(style, "font-family");
                        style = RemoveCssProperty(style, "font-size");

                        if (string.IsNullOrWhiteSpace(style))
                        {
                            element.RemoveAttribute("style");
                        }
                        else
                        {
                            element.SetAttribute("style", style);
                        }
                    }
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Normalized nested tspan styles: {outputPath}");
        }

        public static void ApplyStylesToTextAndTspanElements()
        {
            // Apply consistent presentation attributes to SVG <text> and <tspan> elements.
            // Styling both parent and child text elements avoids surprises when nested spans override parent values.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "text.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "text-and-tspan-styled.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var nodes = document.QuerySelectorAll("text, tspan");
                foreach (Node node in nodes)
                {
                    if (node is Element element)
                    {
                        element.SetAttribute("fill", "#034586");
                        element.SetAttribute("font-family", "Montserrat, Arial, sans-serif");
                        element.SetAttribute("font-size", "20px");
                    }
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Applied styles to text and tspan elements: {outputPath}");
        }

        public static void RegisterFontsBeforePdfConversion()
        {
            // Register a custom font folder before loading and converting SVG to PDF.
            // Font lookup must be configured before document loading for predictable SVG text rendering.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "input.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "registered-fonts.pdf");
            const string svgNamespace = "http://www.w3.org/2000/svg";

            using (var configuration = new Configuration())
            {
                IUserAgentService userAgentService = configuration.GetService<IUserAgentService>();
                userAgentService.FontsSettings.SetFontsLookupFolder(Path.Combine(RunExamples.GetDataDir_SVG(), "fonts"));

                using (var document = new SVGDocument(inputPath, configuration))
                {
                    var style = (SVGStyleElement)document.CreateElementNS(svgNamespace, "style");
                    style.TextContent =
                        "text { font-family: 'Montserrat', Arial, sans-serif; font-size: 32px; fill: #2c3e50; }";
                    document.RootElement.InsertBefore(style, document.RootElement.FirstChild);

                    Converter.ConvertSVG(document, new PdfSaveOptions(), outputPath);
                }
            }

            Console.WriteLine($"Converted SVG to PDF after registering fonts: {outputPath}");
        }

        private static string RemoveCssProperty(string style, string property)
        {
            if (string.IsNullOrWhiteSpace(style))
            {
                return string.Empty;
            }

            var result = new List<string>();
            foreach (string declaration in style.Split(';'))
            {
                string trimmed = declaration.Trim();
                if (!string.IsNullOrWhiteSpace(trimmed)
                    && !trimmed.StartsWith(property + ":", StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(trimmed);
                }
            }

            return string.Join("; ", result);
        }
    }
}
