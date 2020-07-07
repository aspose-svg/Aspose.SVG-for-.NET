using Aspose.Svg;
using Aspose.Svg.Rendering.Image;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGToImage
    {
        public static void ConvertSVGToBMP()
        {
            //ExStart: ConvertSVGToBMP
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Bmp), dataDir + "smiley_out.bmp"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToBMP
        }

        public static void ConvertSVGToGIF()
        {
            //ExStart: ConvertSVGToGIF
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Gif), dataDir + "smiley_out.gif"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToGIF
        }

        public static void ConvertSVGToJPEG()
        {
            //ExStart: ConvertSVGToJPEG
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Jpeg), dataDir + "smiley_out.jpg"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToJPEG
        }

        public static void ConvertSVGToPNG()
        {
            //ExStart: ConvertSVGToPNG
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Png), dataDir + "smiley_out.png"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToPNG
        }

        public static void ConvertSVGToPNG_1()
        {
            //ExStart: ConvertSVGToPNG
            // Prepare an SVG code and save it to the file.
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx='50' cy='50' r='40' stroke='black' stroke-width='2' fill='red' />" +
                       "<circle cx='80' cy='80' r='30' stroke='black' stroke-width='1' fill='green' />" +
                       "</svg>";
            System.IO.File.WriteAllText("example.svg", code);

            // Initialize an SVG document from the file.
            using (var document = new Aspose.Svg.SVGDocument("example.svg"))
            {
                var saveOptions = new Aspose.Svg.Saving.ImageSaveOptions(Aspose.Svg.Rendering.Image.ImageFormat.Png);
                // Convert SVG to PNG
                Aspose.Svg.Converters.Converter.ConvertSVG(document, saveOptions, "output.png");
            }
            //ExEnd: ConvertSVGToPNG
        }

        public static void ConvertSVGToPNG_2()
        {
            //ExStart: ConvertSVGToPNG
            // Prepare an SVG code and save it to the string.
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<rect width='300' height='100' style='fill:rgb(0,0,255);stroke-width:3;stroke:rgb(0,0,0)'/>" +
                       "</svg>";
            // Initialize an SVG document from the string.
            using (var document = new Aspose.Svg.SVGDocument(code, ""))
            {
                using (var device = new Aspose.Svg.Rendering.Image.ImageDevice(new Aspose.Svg.Rendering.Image.ImageRenderingOptions(Aspose.Svg.Rendering.Image.ImageFormat.Png), "output.png"))
                {
                    //render SVG to PNG
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToPNG
        }

        public static void ConvertSVGToTIFF()
        {
            //ExStart: ConvertSVGToTIFF
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Tiff), dataDir + "smiley_out.tiff"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToTIFF
        }
    }
}
