// Copyright (c) 2001-2021 Aspose Pty Ltd. All Rights Reserved.

using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Rendering;
using Aspose.Svg.Saving;
using CommandLine;
using System;
using System.IO;

namespace PhotoEffects
{
    class Program
    {
        public class Options
        {
            [Option('s', "source", Required = true, HelpText = "A source image file")]
            public string Source { get; set; }
            [Option('o', "output", Required = true, HelpText = "An output image file")]
            public string Output { get; set; }
            [Option('f', "filter", Required = false, HelpText = "A filter name from the list: Instagram, DistortionMirror, Vintage, Retro, BlurredLights, BrushStrokes, Movie")]
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
            //Create a new svg document
            using (var svgDoc = new SVGDocument())
            {
                //Create an element <g> to which the filter will be applied.
                var g = svgDoc.CreateElementNS("http://www.w3.org/2000/svg", "g");
                svgDoc.RootElement.AppendChild(g);
                using (var image = System.Drawing.Image.FromFile(srcFile))
                {
                    //Create <image> element 
                    var imageElement = (SVGImageElement)svgDoc.CreateElementNS("http://www.w3.org/2000/svg", "image");
                    imageElement.SetAttribute("href", srcFile);
                    var w = image.Width;
                    var h = image.Height;

                    const int maxSize = 2000;
                    var size = (float)Math.Max(w, h);
                    if (size > maxSize)
                    {
                        w = (int)(maxSize * w / size);
                        h = (int)(maxSize * h / size);
                    }
                    //Set the dimensions of <image> and <svg> elements to keep the original image size.
                    imageElement.Height.BaseVal.ValueAsString = $"{h}px";
                    imageElement.Width.BaseVal.ValueAsString = $"{w}px";

                    svgDoc.RootElement.Height.BaseVal.ValueAsString = $"{h}px";
                    svgDoc.RootElement.Width.BaseVal.ValueAsString = $"{w}px";

                    //Append <image> into <g> element.
                    g.AppendChild(imageElement);
                }
                //Load svg file which contains the list of available filters.
                //We use the filters.svg file as a repository because it is easy to edit and add new filters.
                using (var filtersStream = new FileStream("filters.svg", FileMode.Open))
                using (var filtersDoc = new SVGDocument(filtersStream, Directory.GetCurrentDirectory()))
                {
                    var filter = filtersDoc.GetElementById(filterId);
                    svgDoc.RootElement.AppendChild(filter);
                    g.SetAttribute("filter", $"url(#{filter.Id})");
                    var options =new ImageSaveOptions() { HorizontalResolution = 96, VerticalResolution = 96 };
                    options.PageSetup.Sizing = SizingType.FitContent;
                    //Here we convert svg document with image and  graphic filter to the result image file.
                    Converter.ConvertSVG(svgDoc, options, outputFile);
                }

            }
        }
    }
}
