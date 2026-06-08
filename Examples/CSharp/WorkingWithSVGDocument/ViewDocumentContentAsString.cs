using Aspose.Svg;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class ViewDocumentContentAsString
    {
        public static void Run()
        {
            ViewRootElementOuterHtml();
            ViewSelectedElementOuterHtml();
        }

        public static void ViewRootElementOuterHtml()
        {
            // View the full SVG document content as a string using Aspose.SVG for .NET.
            // OuterHTML is useful when you need to inspect generated, loaded, or edited SVG markup.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                Console.WriteLine(document.DocumentElement.OuterHTML);
            }
        }

        public static void ViewSelectedElementOuterHtml()
        {
            // View the markup of a selected SVG element.
            // This keeps console output focused when you only need to inspect one DOM node.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                var rectangle = document.QuerySelector("rect[style*='FireBrick']");
                Console.WriteLine(rectangle.OuterHTML);
            }
        }
    }
}
