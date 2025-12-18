using Aspose.Svg;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Xps;
using System.IO;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGFilesUsingRenderer
    {
        public static void Run()
        {
            //ExStart: ConvertSVGFilesUsingRenderer
            string dataDir = RunExamples.GetDataDir_Convert();
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                using (SvgRenderer renderer = new SvgRenderer())
                using (XpsDevice device = new XpsDevice(outputDir + "ConvertSVGFilesUsingRenderer_out.xps"))
                {
                    renderer.Render(device, document);
                }
            }
            //ExEnd: ConvertSVGFilesUsingRenderer
        }
    }
}
