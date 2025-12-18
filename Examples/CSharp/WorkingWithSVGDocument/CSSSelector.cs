using Aspose.Svg;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class CSSSelector
    {
        public static void Run()
        {
            //ExStart: CSSSelector
            // Input SVG files for working with SVG document examples are located in Examples/Data/svg/
            string dataDir = Path.Combine(RunExamples.GetDataDir_Data(), "svg\\");

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var element = document.QuerySelector("g > :last-child");
                Console.WriteLine(element.OuterHTML);
            }
            //ExEnd: CSSSelector
        }
    }
}
