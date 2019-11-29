using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class LoadSVGDocumentFromFile
    {
        public static void Run()
        {
            //ExStart: LoadDocumentFromFile
            string dataDir = RunExamples.GetDataDir_Data();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                // do some actions over the document here... 
            }
            //ExEnd: LoadDocumentFromFile
        }
    }
}
