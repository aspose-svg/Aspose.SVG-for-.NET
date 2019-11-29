using Aspose.Svg;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering.Xps;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class RenderingOptions
    {
        public static void Run()
        {
            //ExStart: RenderingOptions
            string dataDir = RunExamples.GetDataDir_Data();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                var options = new XpsRenderingOptions()
                {
                    PageSetup =
                    {
                        AnyPage = new Page(new Aspose.Svg.Drawing.Size(500, 500), new Margin(50, 50, 50, 50))
                    },
                    BackgroundColor = Color.Blue
                };
                using (XpsDevice device = new XpsDevice(options, dataDir + "RenderingOptions_out.xps"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: RenderingOptions
        }
    }
}
