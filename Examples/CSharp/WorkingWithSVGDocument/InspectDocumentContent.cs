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
            string dataDir = RunExamples.GetDataDir_Data();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                var svg = document.DocumentElement;
                var g = svg.GetElementsByTagName("g").First() as SVGGElement;
                var rect = g.FirstElementChild as SVGRectElement;

                Console.WriteLine(rect.Width); // 90%
                Console.WriteLine(rect.Height); // 90%
            }
            //ExEnd: InspectDocumentContent
        }
    }
}
