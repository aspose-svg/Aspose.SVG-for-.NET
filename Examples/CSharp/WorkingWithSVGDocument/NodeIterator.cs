using Aspose.Svg;
using Aspose.Svg.Dom;
using Aspose.Svg.Dom.Traversal.Filters;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class NodeIterator
    {
        public static void Run()
        {
            //ExStart: NodeIterator
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                // Create a node iterator
                using (var iterator = document.CreateNodeIterator(document, NodeFilter.SHOW_ALL, new RectFilter()))
                {
                    Console.WriteLine((iterator.NextNode() as Element)?.OuterHTML);
                    Console.WriteLine((iterator.NextNode() as Element)?.OuterHTML);
                    Console.WriteLine((iterator.NextNode() as Element)?.OuterHTML);
                }
            }
            //ExEnd: NodeIterator
        }
    }
}
