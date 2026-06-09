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
            // Iterate through SVG nodes with a custom NodeFilter in Aspose.SVG for .NET.
            // The iterator visits only nodes accepted by RectFilter.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                using (var iterator = document.CreateNodeIterator(document, NodeFilter.SHOW_ALL, new RectFilter()))
                {
                    Node node;
                    while ((node = iterator.NextNode()) != null)
                    {
                        Console.WriteLine((node as Element)?.OuterHTML);
                    }
                }
            }
        }

        // Custom NodeFilter for SVG DOM traversal. It accepts only <rect> elements
        // and is passed to CreateNodeIterator() to filter the nodes returned by the iterator.
        private class RectFilter : NodeFilter
        {
            public override short AcceptNode(Node n)
            {
                return string.Equals("rect", n.NodeName)
                    ? FILTER_ACCEPT
                    : FILTER_REJECT;
            }
        }
    }
}
