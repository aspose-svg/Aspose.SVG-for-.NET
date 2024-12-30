using Aspose.Svg;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Xps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGFilesUsingRenderer
    {
        public static void Run()
        {
            //ExStart: ConvertSVGFilesUsingRenderer
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                using (SvgRenderer renderer = new SvgRenderer())
                using (XpsDevice device = new XpsDevice(dataDir + "ConvertSVGFilesUsingRenderer_out.xps"))
                {
                    renderer.Render(device, document);
                }
            }
            //ExEnd: ConvertSVGFilesUsingRenderer
        }
    }
}
