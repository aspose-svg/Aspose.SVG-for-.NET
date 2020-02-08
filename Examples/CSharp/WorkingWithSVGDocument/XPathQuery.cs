using Aspose.Svg;
using Aspose.Svg.Dom;
using Aspose.Svg.Dom.XPath;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.WorkingWithSVGDocument
{
    class XPathQuery
    {
        public static void Run()
        {
            //ExStart: XPathQuery
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                //  Evaluate XPath expression
                var xpathResult = document.Evaluate("//rect[@x='100']", document, null, XPathResultType.Any, null);

                //  Get the next evaluated node
                Console.WriteLine((xpathResult.IterateNext() as Element)?.OuterHTML);
            }
            //ExEnd: XPathQuery
        }
    }
}
