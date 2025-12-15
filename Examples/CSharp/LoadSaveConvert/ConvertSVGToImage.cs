using Aspose.Svg;
using Aspose.Svg.Rendering.Image;
using System.IO;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGToImage
    {
        public static void ConvertSVGToBMP()
        {
            //ExStart: ConvertSVGToBMP
            string dataDir = RunExamples.GetDataDir_Convert();
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Bmp), outputDir + "paths_out.bmp"))
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
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Gif), outputDir + "paths_out.gif"))
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
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Jpeg), outputDir + "paths_out.jpg"))
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
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Png), outputDir + "paths_out.png"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToPNG
        }

        public static void ConvertSVGToPNGFromFile()
        {
            //ExStart: ConvertSVGToPNG
            // Prepare an SVG code and save it to the file
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx='50' cy='50' r='40' stroke='black' stroke-width='2' fill='red' />" +
                       "<circle cx='80' cy='80' r='30' stroke='black' stroke-width='1' fill='green' />" +
                       "</svg>";
            File.WriteAllText("example.svg", code);

            // Initialize an SVG document from the file
            using (var document = new SVGDocument("example.svg"))
            {
                var saveOptions = new Aspose.Svg.Saving.ImageSaveOptions(ImageFormat.Png);
                // Convert SVG to PNG
                Aspose.Svg.Converters.Converter.ConvertSVG(document, saveOptions, "output.png");
            }
            //ExEnd: ConvertSVGToPNG
        }

        public static void ConvertSVGToPNGFromString()
        {
            //ExStart: ConvertSVGToPNG
            // Prepare an SVG code and save it to the string
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<rect width='300' height='100' style='fill:rgb(0,0,255);stroke-width:3;stroke:rgb(0,0,0)'/>" +
                       "</svg>";
            // Initialize an SVG document from the string
            using (var document = new SVGDocument(code, ""))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Png), "output.png"))
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
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Tiff), outputDir + "paths_out.tiff"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToTIFF
        }
    }
}
