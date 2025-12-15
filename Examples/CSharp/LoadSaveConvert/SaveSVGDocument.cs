using Aspose.Svg;
using System.IO;


namespace CSharp.LoadSaveConvert
{
    class SaveSVGDocument
    {
        public static void Run()
        {
            //ExStart: SaveSVGDocument
            // Input files for save examples are located in Examples/Data/save/
            string dataDir = Path.Combine(RunExamples.GetDataDir_Data(), "save\\");
            // Output files for save examples are stored in Examples/output/save/
            string outputDir = RunExamples.GetDataDir_Save();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                const string @namespace = "http://www.w3.org/2000/svg";
                var circle = (SVGCircleElement)document.CreateElementNS(@namespace, "circle");
                circle.Cx.BaseVal.Value = 50;
                circle.Cy.BaseVal.Value = 50;
                circle.R.BaseVal.Value = 40;

                var g = document.QuerySelector("g");
                g.InsertBefore(circle, g.FirstChild);

                document.Save(outputDir + "SaveSVGDocument_out.svg");
            }
            //ExEnd: SaveSVGDocument
        }
    }
}
