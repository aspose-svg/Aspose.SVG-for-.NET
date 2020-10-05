using System;
using Aspose.Svg;
using Aspose.Svg.Saving;

namespace CSharp.LoadSaveConvert
{
    class VectorizeText
    {
        public static void Run()
        {
            //ExStart: 1
            string dataDir = RunExamples.GetDataDir_Save();

            SVGDocument document = new SVGDocument(dataDir + "complex.svg");

            SVGSaveOptions saveOptions = new SVGSaveOptions
            {
                VectorizeText = true
            };

            document.Save(dataDir + @"vectorized_text_out.svg", saveOptions);
            //ExEnd: 1
        }
    }
}
