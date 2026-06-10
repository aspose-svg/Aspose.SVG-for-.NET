using Aspose.Svg;
using Aspose.Svg.Saving;
using System;
using System.IO;

namespace CSharp.ImageAndTextVectorization
{
    class TextVectorization
    {
        public static void Run()
        {
            SaveSvgWithTextAsText();
            VectorizeSvgTextToPaths();
        }

        public static void SaveSvgWithTextAsText()
        {
            // Save SVG text as editable text in C#.
            // This comparison file keeps <text> elements unchanged before text vectorization is applied.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "text.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputVectorization(), "text-original.svg");

            using (var document = new SVGDocument(inputPath))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Saved SVG with editable text: {outputPath}");
        }

        public static void VectorizeSvgTextToPaths()
        {
            // Vectorize SVG text to paths in C# using Aspose.SVG for .NET.
            // SVGSaveOptions.VectorizeText converts text elements into path geometry for portable rendering.
            string inputPath = Path.Combine(RunExamples.GetDataDir_SVG(), "text.svg");
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputVectorization(), "text-vectorized.svg");

            using (var document = new SVGDocument(inputPath))
            {
                var saveOptions = new SVGSaveOptions
                {
                    VectorizeText = true
                };

                document.Save(outputPath, saveOptions);
            }

            Console.WriteLine($"Vectorized SVG text to paths: {outputPath}");
        }
    }
}
