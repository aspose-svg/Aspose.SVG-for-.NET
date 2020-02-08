using Aspose.Svg;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGToPDF
    {
        public static void Run()
        {
            //ExStart: ConvertSVGToPDF
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                var options = new PdfRenderingOptions()
                {
                    PageSetup =
                    {
                        AnyPage = new Page(new Size(500, 500))
                    }
                };
                using (var device = new PdfDevice(options, dataDir + "smiley_out.pdf"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToPDF
        }
    }
}
