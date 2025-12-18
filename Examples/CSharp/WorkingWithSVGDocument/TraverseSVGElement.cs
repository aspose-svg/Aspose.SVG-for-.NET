using Aspose.Svg;
using System;
using System.IO;

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
                Console.WriteLine(element.TagName); // svg

                element = element.FirstElementChild;
                Console.WriteLine(element.TagName); // g

                element = element.FirstElementChild;
                Console.WriteLine(element.TagName); // path
            }
            //ExEnd: TraverseSVGElement
        }
    }
}
