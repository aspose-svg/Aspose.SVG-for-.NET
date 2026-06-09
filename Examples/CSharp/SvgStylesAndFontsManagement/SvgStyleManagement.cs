using Aspose.Svg;
using Aspose.Svg.Dom;
using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp.SvgStylesAndFontsManagement
{
    class SvgStyleManagement
    {
        public static void Run()
        {
            ApplyPresentationAttributesToText();
            ApplyInlineCssStylesToText();
            AddStyleElementWithCssRules();
            SelectAndFillShapeElements();
            FindElementsWithInlineStyles();
            NormalizeInlineFillStyles();
        }

        public static void ApplyPresentationAttributesToText()
        {
            // Apply SVG presentation attributes to a text element in C#.
            // Presentation attributes such as fill, font-size, and font-family are simple DOM-level styling options.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "input.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "text-presentation-attributes.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var text = document.QuerySelector("text") as SVGTextElement;
                if (text != null)
                {
                    text.SetAttribute("fill", "#2c3e50");
                    text.SetAttribute("font-size", "36");
                    text.SetAttribute("font-family", "Montserrat, Arial, sans-serif");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Applied presentation attributes to SVG text: {outputPath}");
        }

        public static void ApplyInlineCssStylesToText()
        {
            // Apply inline CSS styles to SVG text in C#.
            // Inline style attributes have high priority and are useful for targeted element-level changes.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "input.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "text-inline-styles.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var text = document.QuerySelector("text") as SVGTextElement;
                if (text != null)
                {
                    text.SetAttribute("style", "font-size: 36px; fill: #034586; font-family: Arial, sans-serif;");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Applied inline CSS styles to SVG text: {outputPath}");
        }

        public static void AddStyleElementWithCssRules()
        {
            // Add a <style> element with CSS rules to an SVG document in C#.
            // Embedded CSS centralizes styling and can affect multiple matching SVG elements.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "input.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "text-style-element.svg");
            const string svgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument(inputPath))
            {
                var style = (SVGStyleElement)document.CreateElementNS(svgNamespace, "style");
                style.TextContent = "text { font-family: 'Montserrat', Arial, sans-serif; font-size: 36px; fill: #1abc9c; }";
                document.RootElement.InsertBefore(style, document.RootElement.FirstChild);

                document.Save(outputPath);
            }

            Console.WriteLine($"Added embedded CSS rules to SVG: {outputPath}");
        }

        public static void SelectAndFillShapeElements()
        {
            // Select SVG shape elements and apply a uniform fill color in C#.
            // QuerySelectorAll() can target several SVG shape types in one selector.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "shapes.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "shapes-filled.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var shapes = document.QuerySelectorAll("path, rect, circle, ellipse, polygon");

                foreach (Node node in shapes)
                {
                    var element = (Element)node;
                    element.SetAttribute("fill", "#FF7A00");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Applied fill color to SVG shape elements: {outputPath}");
        }

        public static void FindElementsWithInlineStyles()
        {
            // Find SVG elements with inline style attributes in C#.
            // Inspecting inline styles helps diagnose why global CSS or presentation attributes may not apply.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "shapes.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var styledNodes = document.QuerySelectorAll("[style]");
                Console.WriteLine($"Found {styledNodes.Length} SVG element(s) with inline style attributes.");

                foreach (Node node in styledNodes)
                {
                    var element = (Element)node;
                    Console.WriteLine($"<{element.TagName}> style=\"{element.GetAttribute("style")}\"");
                }
            }
        }

        public static void NormalizeInlineFillStyles()
        {
            // Remove fill declarations from inline SVG styles and replace them with presentation attributes.
            // This keeps other inline declarations intact while making fill color predictable.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "input.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputStylesAndFonts(), "style-normalized-fill.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var nodes = document.QuerySelectorAll("[style]");
                foreach (Node node in nodes)
                {
                    var element = (Element)node;
                    string style = element.GetAttribute("style");
                    if (string.IsNullOrEmpty(style))
                    {
                        continue;
                    }

                    string cleanedStyle = RemoveStyleProperty(style, "fill");
                    if (string.IsNullOrWhiteSpace(cleanedStyle))
                    {
                        element.RemoveAttribute("style");
                    }
                    else
                    {
                        element.SetAttribute("style", cleanedStyle);
                    }

                    element.SetAttribute("fill", "#FF7A00");
                }

                document.Save(outputPath);
            }

            Console.WriteLine($"Normalized inline fill styles: {outputPath}");
        }

        private static string RemoveStyleProperty(string style, string property)
        {
            var declarations = style.Split(';');
            var result = new List<string>();

            foreach (string declaration in declarations)
            {
                string trimmed = declaration.Trim();
                if (!string.IsNullOrEmpty(trimmed)
                    && !trimmed.StartsWith(property + ":", StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(trimmed);
                }
            }

            return string.Join("; ", result);
        }
    }
}
