using Aspose.Svg;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering.Xps;
using System.IO;

namespace CSharp.LoadSaveConvert
{
    class RenderingOptions
    {
        public static void Run()
        {
            //ExStart: RenderingOptions
            // Input files for save examples are located in Examples/Data/save/
            string dataDir = Path.Combine(RunExamples.GetDataDir_Data(), "save\\");
            // Output files for save examples are stored in Examples/output/save/
            string outputDir = RunExamples.GetDataDir_Save();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var options = new XpsRenderingOptions()
                {
                    PageSetup =
                    {
                        AnyPage = new Page(new Size(500, 500), new Margin(50, 50, 50, 50))
                    },
                    BackgroundColor = System.Drawing.Color.Blue
                };
                using (XpsDevice device = new XpsDevice(options, outputDir + "RenderingOptions_out.xps"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: RenderingOptions
        }
    }
}
