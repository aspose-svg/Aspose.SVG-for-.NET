using Aspose.Svg;
using System;

namespace CSharp.WorkingWithSVGDocument
{
    class ViewDocumentContentAsString
    {
        public static void Run()
        {
            //ExStart: ViewDocumentContentAsString
            using (var document = new SVGDocument("http://www1.plurib.us/1shot/2008/circle_design/circles_single.svg"))
            {
                Console.WriteLine(document.DocumentElement.OuterHTML);
            }
            //ExEnd: ViewDocumentContentAsString
        }
    }
}
