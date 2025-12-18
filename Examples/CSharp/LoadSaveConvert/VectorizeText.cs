using System;
using System.IO;
using Aspose.Svg;
using Aspose.Svg.Saving;

namespace CSharp.LoadSaveConvert
{
    class VectorizeText
    {
        public static void Run()
        {
            //ExStart: 1
            // Input files for save examples are located in Examples/Data/save/
            string dataDir = Path.Combine(RunExamples.GetDataDir_Data(), "save\\");
            // Output files for save examples are stored in Examples/output/save/
            string outputDir = RunExamples.GetDataDir_Save();

            SVGDocument document = new SVGDocument(dataDir + "complex.svg");

            SVGSaveOptions saveOptions = new SVGSaveOptions
            {
                VectorizeText = true
            };

            document.Save(outputDir + @"vectorized_text_out.svg", saveOptions);
            //ExEnd: 1
        }
    }
}
