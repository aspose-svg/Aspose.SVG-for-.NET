using Aspose.Svg;
using System.IO;

namespace CSharp.LoadSaveConvert
{
    class LoadSVGDocumentFromFile
    {
        public static void Run()
        {
            //ExStart: LoadDocumentFromFile
            // Input files for open examples are located in Examples/Data/open/
            string dataDir = Path.Combine(RunExamples.GetDataDir_Data(), "open\\");

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                // do some actions over the document here... 
            }
            //ExEnd: LoadDocumentFromFile
        }
    }
}
