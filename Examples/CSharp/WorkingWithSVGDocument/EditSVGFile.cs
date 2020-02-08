using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.WorkingWithSVGDocument
{
    class EditSVGFile
    {
        public static void Run()
        {
            //ExStart: EditSVGFile
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                const string @namespace = "http://www.w3.org/2000/svg";
                var circle = (SVGCircleElement)document.CreateElementNS(@namespace, "circle");
                circle.Cx.BaseVal.Value = 50;
                circle.Cy.BaseVal.Value = 50;
                circle.R.BaseVal.Value = 40;

                var g = document.QuerySelector("g");
                g.AppendChild(circle);

                Console.WriteLine(g.OuterHTML);
            }
            //ExEnd: EditSVGFile
        }
    }
}
