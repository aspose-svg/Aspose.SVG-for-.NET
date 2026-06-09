using Aspose.Svg;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Rendering.Pdf;
using System;
using System.IO;

namespace CSharp.ConvertRenderMergeSvg
{
    class MergeSVGDocuments
    {
        public static void Run()
        {
            MergeSvgDocumentsToPdf();
            MergeSvgDocumentsToPng();
        }

        public static void MergeSvgDocumentsToPdf()
        {
            // Merge multiple SVG documents into one PDF output in C#.
            // This does not create a combined SVG DOM; SvgRenderer renders several SVGDocument instances to one PdfDevice.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "merged-svg-documents.pdf");

            using (var document1 = new SVGDocument(Path.Combine(dataDir, "circle.svg")))
            using (var document2 = new SVGDocument(Path.Combine(dataDir, "flower.svg")))
            using (var document3 = new SVGDocument(Path.Combine(dataDir, "lineto.svg")))
            using (var renderer = new SvgRenderer())
            using (var device = new PdfDevice(outputPath))
            {
                renderer.Render(device, document1, document2, document3);
            }

            Console.WriteLine($"Merged SVG documents to PDF: {outputPath}");
        }

        public static void MergeSvgDocumentsToPng()
        {
            // Merge multiple SVG documents into one PNG output in C#.
            // The SVG files are rendered sequentially to one ImageDevice instead of being combined into a new SVG file.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputConvert(), "merged-svg-documents.png");

            using (var document1 = new SVGDocument(Path.Combine(dataDir, "circle.svg")))
            using (var document2 = new SVGDocument(Path.Combine(dataDir, "flower.svg")))
            using (var document3 = new SVGDocument(Path.Combine(dataDir, "lineto.svg")))
            using (var renderer = new SvgRenderer())
            using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Png), outputPath))
            {
                renderer.Render(device, document1, document2, document3);
            }

            Console.WriteLine($"Merged SVG documents to PNG: {outputPath}");
        }
    }
}
