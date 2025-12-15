using Aspose.Svg;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering.Pdf;
using System.IO;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGToPDF
    {
        public static void Run()
        {
            //ExStart: ConvertSVGToPDF
            string dataDir = RunExamples.GetDataDir_Convert();
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var options = new PdfRenderingOptions()
                {
                    PageSetup =
                    {
                        AnyPage = new Page(new Size(500, 500))
                    }
                };
                using (var device = new PdfDevice(options, outputDir + "paths_out.pdf"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToPDF
        }
    }
}
