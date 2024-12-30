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
                var circle = svg.GetElementsByTagName("circle").First() as SVGCircleElement;

                Console.WriteLine(circle.Cx); // 204
                Console.WriteLine(circle.Cy); // 209
                Console.WriteLine(circle.R); // 3
            }
            //ExEnd: InspectDocumentContent
        }
    }
}
