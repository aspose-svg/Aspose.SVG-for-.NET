using Aspose.Svg;
using Aspose.Svg.ImageVectorization;
using System;
using System.IO;

namespace CSharp.ImageAndTextVectorization
{
    class ImageVectorization
    {
        public static void Run()
        {
            VectorizePngWithDefaultSettings();
            VectorizePngWithBezierPathBuilder();
            VectorizePngWithSplinePathBuilder();
            CompareTraceSimplifierSettings();
            VectorizeJpegPhoto();
        }

        public static void VectorizePngWithDefaultSettings()
        {
            // Vectorize PNG to SVG in C# using Aspose.SVG for .NET.
            // ImageVectorizer traces raster pixels and creates an SVG document with vector paths.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "png-to-svg.png");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputVectorization(), "png-vectorized-default.svg");

            var configuration = new ImageVectorizerConfiguration();
            var vectorizer = new ImageVectorizer(configuration);

            using (SVGDocument document = vectorizer.Vectorize(inputPath))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Vectorized PNG with default settings: {outputPath}");
        }

        public static void VectorizePngWithBezierPathBuilder()
        {
            // Vectorize PNG to SVG with BezierPathBuilder in C#.
            // BezierPathBuilder lets you control smoothing, error threshold, iteration count, and line width.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "flower.png");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputVectorization(), "flower-bezier-vectorized.svg");

            var pathBuilder = new BezierPathBuilder
            {
                TraceSmoother = new ImageTraceSmoother(1),
                ErrorThreshold = 30,
                MaxIterations = 30
            };

            var configuration = new ImageVectorizerConfiguration
            {
                PathBuilder = pathBuilder,
                ColorsLimit = 10,
                LineWidth = 1
            };

            var vectorizer = new ImageVectorizer(configuration);

            using (SVGDocument document = vectorizer.Vectorize(inputPath))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Vectorized PNG with BezierPathBuilder: {outputPath}");
        }

        public static void VectorizePngWithSplinePathBuilder()
        {
            // Vectorize PNG to SVG with SplinePathBuilder in C#.
            // SplinePathBuilder creates smoother vector paths and can simplify traced contours.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "flower.png");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputVectorization(), "flower-spline-vectorized.svg");

            var pathBuilder = new SplinePathBuilder
            {
                TraceSmoother = new ImageTraceSmoother(2),
                TraceSimplifier = new ImageTraceSimplifier(0.1f)
            };

            var configuration = new ImageVectorizerConfiguration
            {
                PathBuilder = pathBuilder,
                ColorsLimit = 8
            };

            var vectorizer = new ImageVectorizer(configuration);

            using (SVGDocument document = vectorizer.Vectorize(inputPath))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Vectorized PNG with SplinePathBuilder: {outputPath}");
        }

        public static void CompareTraceSimplifierSettings()
        {
            // Compare SVG vectorization with different trace simplification settings.
            // Lower simplification values preserve more detail; higher values produce simpler SVG paths.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "flower.png");
            string outputDir = RunExamples.GetDataDir_OutputVectorization();

            VectorizeWithSimplifier(inputPath, Path.Combine(outputDir, "flower-simplifier-0-1.svg"), 0.1f);
            VectorizeWithSimplifier(inputPath, Path.Combine(outputDir, "flower-simplifier-1.svg"), 1f);
            VectorizeWithSimplifier(inputPath, Path.Combine(outputDir, "flower-simplifier-2.svg"), 2f);

            Console.WriteLine($"Created SVG vectorization comparison files: {outputDir}");
        }

        public static void VectorizeJpegPhoto()
        {
            // Vectorize JPG photo to SVG in C# with custom tracing settings.
            // Photo vectorization usually needs a higher color limit than simple icon or stencil images.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "horses.jpg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputVectorization(), "horses-vectorized.svg");

            var configuration = new ImageVectorizerConfiguration
            {
                PathBuilder = new SplinePathBuilder
                {
                    TraceSmoother = new ImageTraceSmoother(1),
                    TraceSimplifier = new ImageTraceSimplifier(0.3f)
                },
                ColorsLimit = 25,
                LineWidth = 1
            };

            var vectorizer = new ImageVectorizer(configuration);

            using (SVGDocument document = vectorizer.Vectorize(inputPath))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Vectorized JPG photo to SVG: {outputPath}");
        }

        private static void VectorizeWithSimplifier(string inputPath, string outputPath, float simplifierValue)
        {
            var configuration = new ImageVectorizerConfiguration
            {
                PathBuilder = new SplinePathBuilder
                {
                    TraceSmoother = new ImageTraceSmoother(2),
                    TraceSimplifier = new ImageTraceSimplifier(simplifierValue)
                },
                ColorsLimit = 8
            };

            var vectorizer = new ImageVectorizer(configuration);

            using (SVGDocument document = vectorizer.Vectorize(inputPath))
            {
                document.Save(outputPath);
            }
        }
    }
}
