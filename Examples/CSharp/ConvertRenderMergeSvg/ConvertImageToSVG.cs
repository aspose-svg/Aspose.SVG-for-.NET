using Aspose.Svg.Converters;
using Aspose.Svg.ImageVectorization;
using System;
using System.IO;

namespace CSharp.ConvertRenderMergeSvg
{
    class ConvertImageToSVG
    {
        public static void Run()
        {
            ConvertPngToSvg();
            ConvertJpgStreamToSvg();
        }

        public static void ConvertPngToSvg()
        {
            // Convert PNG to SVG in C# using Aspose.SVG for .NET.
            // Converter.ConvertImageToSVG() traces a raster PNG image and saves vector SVG output.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "png-to-svg.png");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "png-to-svg.svg");

            var configuration = new ImageVectorizerConfiguration
            {
                PathBuilder = new BezierPathBuilder
                {
                    TraceSmoother = new ImageTraceSmoother(3),
                    ErrorThreshold = 5,
                    MaxIterations = 5
                },
                ColorsLimit = 20,
                LineWidth = 1
            };

            Converter.ConvertImageToSVG(configuration, inputPath, outputPath);

            Console.WriteLine($"Converted PNG to SVG: {outputPath}");
        }

        public static void ConvertJpgStreamToSvg()
        {
            // Convert JPG stream to SVG in C# using ConvertImageToSVG().
            // This example opens a raster image as a stream before creating vector SVG output.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "tulip.jpg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "tulip-from-stream.svg");

            var configuration = new ImageVectorizerConfiguration
            {
                PathBuilder = new BezierPathBuilder
                {
                    TraceSmoother = new ImageTraceSmoother(1),
                    ErrorThreshold = 10,
                    MaxIterations = 1
                },
                ColorsLimit = 30,
                LineWidth = 1
            };

            using (var stream = File.Open(inputPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Converter.ConvertImageToSVG(configuration, stream, outputPath);
            }

            Console.WriteLine($"Converted JPG stream to SVG: {outputPath}");
        }
    }
}
