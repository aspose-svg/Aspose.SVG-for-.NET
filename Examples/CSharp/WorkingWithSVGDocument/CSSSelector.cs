using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.WorkingWithSVGDocument
{
    class CSSSelector
    {
        public static void Run()
        {
            //ExStart: CSSSelector
            string dataDir = RunExamples.GetDataDir_Data();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                var element = document.QuerySelector("g > :last-child");
                Console.WriteLine(element.OuterHTML);
            }
            //ExEnd: CSSSelector
        }
    }
}
