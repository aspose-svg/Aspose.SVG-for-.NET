using Aspose.Svg;
using Aspose.Svg.Dom;
using Aspose.Svg.Dom.XPath;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class XPathQuery
    {
        public static void Run()
        {
            //ExStart: XPathQuery
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                //  Evaluate XPath expression
                var xpathResult = document.Evaluate("//g[@fill='yellow']", document, null, XPathResultType.Any, null);

                //  Get the next evaluated node
                Console.WriteLine((xpathResult.IterateNext() as Element)?.OuterHTML);
            }
            //ExEnd: XPathQuery
        }
    }
}
