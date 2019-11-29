using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    public class CreateSVGDocumentFromContent
    {
        public static void Run()
        {
            //ExStart: CreateSVGDocumentFromContent
            using (var document = new SVGDocument("<svg xmlns='http://www.w3.org/2000/svg'><circle cx='50' cy='50' r='40'/></svg>", "."))
            {
                // do some actions over the document here... 
            }
            //ExEnd: CreateSVGDocumentFromContent
        }
    }
}
