// Copyright (c) 2001-2026 Aspose Pty Ltd. All Rights Reserved.

using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Rendering;
using Aspose.Svg.Saving;
using CommandLine;
using System;
using System.IO;

namespace PhotoEffects
{
    // This console example demonstrates how to apply SVG filter effects to raster images
    // with Aspose.SVG for .NET. It builds an SVG document in memory, references a source
    // bitmap through an <image> element, applies a selected SVG filter, and renders the
    // filtered result to an output image file.
    class Program
    {
        public class Options
        {
            [Option('s', "source", Required = true, HelpText = "A source image file")]
            public string Source { get; set; }
            [Option('o', "output", Required = true, HelpText = "An output image file")]
            public string Output { get; set; }
            [Option('f', "filter", Required = true, HelpText = "A filter name from the list: Instagram, DistortionMirror, Vintage, Retro, BlurredLights, BrushStrokes, Movie")]
            public string Filter { get; set; }

        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                  .WithParsed<Options>(o =>
                  {
                      ApplyFilter(o.Source, o.Filter, o.Output);
                  });
        }

        private static void ApplyFilter(string srcFile, string filterId, string outputFile)
        {
            // Create a new SVG document that will be used as an image-processing canvas.
            using (var svgDoc = new SVGDocument())
            {
                // Create a <g> element. Applying the SVG filter to the group lets the filter
                // affect the embedded raster image as a single visual object.
                var g = svgDoc.CreateElementNS("http://www.w3.org/2000/svg", "g");
                svgDoc.RootElement.AppendChild(g);
                var sourcePath = Path.GetFullPath(srcFile);

                using (var image = System.Drawing.Image.FromFile(sourcePath))
                {
                    // Create an SVG <image> element that references the source bitmap file.
                    var imageElement = (SVGImageElement)svgDoc.CreateElementNS("http://www.w3.org/2000/svg", "image");
                    imageElement.SetAttribute("href", sourcePath);
                    var w = image.Width;
                    var h = image.Height;

                    const int maxSize = 2000;
                    var size = (float)Math.Max(w, h);
                    if (size > maxSize)
                    {
                        w = (int)(maxSize * w / size);
                        h = (int)(maxSize * h / size);
                    }
                    // Set the dimensions of the <image> and root <svg> elements so Aspose.SVG
                    // renders the filtered raster image at the expected output size.
                    imageElement.Height.BaseVal.ValueAsString = $"{h}px";
                    imageElement.Width.BaseVal.ValueAsString = $"{w}px";

                    svgDoc.RootElement.Height.BaseVal.ValueAsString = $"{h}px";
                    svgDoc.RootElement.Width.BaseVal.ValueAsString = $"{w}px";

                    // Add the raster image to the filtered SVG group.
                    g.AppendChild(imageElement);
                }
                // Load filters.svg, a reusable SVG filter library for image effects such as
                // Vintage, Retro, Instagram, Blur, Brush Strokes, and Movie-style color grading.
                var filtersPath = Path.Combine(AppContext.BaseDirectory, "filters.svg");

                using (var filtersStream = File.Open(filtersPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var filtersDoc = new SVGDocument(filtersStream, AppContext.BaseDirectory))
                {
                    var filter = filtersDoc.GetElementById(filterId);
                    if (filter == null)
                    {
                        throw new ArgumentException($"Filter '{filterId}' was not found in filters.svg.", nameof(filterId));
                    }

                    svgDoc.RootElement.AppendChild(filter);
                    g.SetAttribute("filter", $"url(#{filter.Id})");
                    var options = new ImageSaveOptions() { HorizontalResolution = 96, VerticalResolution = 96 };
                    options.PageSetup.Sizing = SizingType.FitContent;
                    // Convert the generated SVG document to a raster image. Aspose.SVG renders
                    // the <image> element together with the selected SVG filter effect.
                    Converter.ConvertSVG(svgDoc, options, outputFile);
                }

            }
        }
    }
}
