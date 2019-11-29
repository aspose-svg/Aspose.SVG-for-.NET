using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    public class CreateEmptySVGDocument
    {
        public static void Run()
        {
            //ExStart: CreateEmptySVGDocument
            using (var document = new SVGDocument())
            {
                // do some actions over the document here... 
            }
            //ExEnd: CreateEmptySVGDocument
        }
    }
}
