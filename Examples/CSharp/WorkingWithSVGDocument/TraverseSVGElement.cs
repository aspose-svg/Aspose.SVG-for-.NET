using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.WorkingWithSVGDocument
{
    class TraverseSVGElement
    {
        public static void Run()
        {
            //ExStart: TraverseSVGElement
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var element = document.DocumentElement;
                Console.WriteLine(element.TagName); // SVG

                element = element.FirstElementChild;
                Console.WriteLine(element.TagName); // d:SVGTestCase

                element = element.FirstElementChild;
                Console.WriteLine(element.TagName); // d:testDescription
            }
            //ExEnd: TraverseSVGElement
        }
    }
}
