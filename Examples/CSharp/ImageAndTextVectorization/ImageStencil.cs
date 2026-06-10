using Aspose.Svg;
using Aspose.Svg.ImageVectorization;
using System;
using System.IO;

namespace CSharp.ImageAndTextVectorization
{
    class ImageStencil
    {
        public static void Run()
        {
            CreateMonoColorStencil();
        }

        public static void CreateMonoColorStencil()
        {
            // Convert PNG to SVG with a mono-color stencil effect in C#.
            // StencilConfiguration is useful for creating icon-like vector output from raster images.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "flower.png");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputVectorization(), "flower-blue-stencil.svg");

            var configuration = new ImageVectorizerConfiguration
            {
                PathBuilder = new BezierPathBuilder
                {
                    TraceSmoother = new ImageTraceSmoother(1),
                    ErrorThreshold = 30,
                    MaxIterations = 30
                },
                ColorsLimit = 10,
                LineWidth = 1,
                Stencil = new StencilConfiguration
                {
                    Type = StencilType.MonoColor,
                    Color = Aspose.Svg.Drawing.Color.FromRgb(0, 0, 255)
                }
            };

            var vectorizer = new ImageVectorizer(configuration);

            using (SVGDocument document = vectorizer.Vectorize(inputPath))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Created SVG stencil from PNG: {outputPath}");
        }
    }
}
