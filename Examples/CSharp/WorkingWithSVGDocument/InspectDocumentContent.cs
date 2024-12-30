using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.WorkingWithSVGDocument
{
    class InspectDocumentContent
    {
        public static void Run()
        {
            //ExStart: InspectDocumentContent
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var svg = document.DocumentElement;
                var rect = svg.GetElementsByTagName("rect").First() as SVGRectElement;

                Console.WriteLine(rect.Width); // 4
                Console.WriteLine(rect.Height); // 4
            }
            //ExEnd: InspectDocumentContent
        }
    }
}
