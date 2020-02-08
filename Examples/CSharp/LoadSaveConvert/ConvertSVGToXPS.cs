using Aspose.Svg;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering.Xps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGToXPS
    {
        public static void Run()
        {
            //ExStart: ConvertSVGToXPS
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                var options = new XpsRenderingOptions()
                {
                    PageSetup =
                    {
                        AnyPage = new Page(new Size(500, 500))
                    }
                };
                using (var device = new XpsDevice(options, dataDir + "smiley_out.xps"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToXPS
        }
    }
}
