using Aspose.Svg;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering.Xps;
using System.IO;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGToXPS
    {
        public static void Run()
        {
            //ExStart: ConvertSVGToXPS
            string dataDir = RunExamples.GetDataDir_Convert();
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var options = new XpsRenderingOptions()
                {
                    PageSetup =
                    {
                        AnyPage = new Page(new Size(500, 500))
                    }
                };
                using (var device = new XpsDevice(options, outputDir + "paths_out.xps"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToXPS
        }
    }
}
