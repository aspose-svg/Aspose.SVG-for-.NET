using System;

namespace CSharp.WorkingWithSVGDocument
{
    public class WorkingWithSVGDocumentExamples
    {
        public static void RunAll()
        {
            // Run all Working with SVG Document examples from one place.
            // Users can comment out individual calls below when they want to focus on one scenario.
            Console.WriteLine("Running WorkingWithSVGDocument examples...");

            CreateAndLoadSVGDocument.Run();
            ViewDocumentContentAsString.Run();
            InspectDocumentContent.Run();
            TraverseSVGElement.Run();
            CSSSelector.Run();
            XPathQuery.Run();
            NodeIterator.Run();
            EditSVGFile.Run();
            EditSVGPathData.Run();
            CreateSVGWithViewBox.Run();
            SaveSVGDocumentExamples.Run();

            Console.WriteLine("WorkingWithSVGDocument examples finished.");
        }
    }
}
