using System;

namespace CSharp.ConvertRenderMergeSvg
{
    public class ConvertRenderMergeSvgExamples
    {
        public static void RunAll()
        {
            // Run all Convert, Render, and Merge SVG examples from one place.
            // Users can comment out individual calls below when they want to focus on one scenario.
            Console.WriteLine("Running ConvertRenderMergeSvg examples...");

            ConvertSVGToImage.Run();
            ConvertSVGToPDF.Run();
            ConvertSVGToXPS.Run();
            RenderSVGDocuments.Run();
            ResizeSVGDocument.Run();
            MergeSVGDocuments.Run();
            ConvertImageToSVG.Run();
            SupportForHtmlContentInSVG.Run();

            Console.WriteLine("ConvertRenderMergeSvg examples finished.");
        }
    }
}
