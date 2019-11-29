using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class LoadSVGDocumentFromUrl
    {
        public static void Run()
        {
            //ExStart: LoadDocumentFromUrl
            using (var document = new SVGDocument("http://www1.plurib.us/1shot/2008/circle_design/circles_single.svg"))
            {
                // do some actions over the document here... 
            }
            //ExEnd: LoadDocumentFromUrl
        }
    }
}
