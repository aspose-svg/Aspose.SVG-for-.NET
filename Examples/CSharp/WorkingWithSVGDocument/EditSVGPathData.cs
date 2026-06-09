using Aspose.Svg;
using Aspose.Svg.Paths;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class EditSVGPathData
    {
        public static void Run()
        {
            // Edit SVG path data programmatically with Aspose.SVG for .NET.
            // This example creates a <path>, reads its path segments, changes coordinates, and saves the SVG file.
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "edited-path-data.svg");
            const string svgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svgElement = document.RootElement;
                svgElement.SetAttribute("width", "520");
                svgElement.SetAttribute("height", "320");
                svgElement.SetAttribute("viewBox", "0 0 520 320");

                var pathElement = (SVGPathElement)document.CreateElementNS(svgNamespace, "path");
                pathElement.SetAttribute("d", "M 10 200 Q 25 110 180 200 T 300 250 T 420 250 T 490 150");

                // PathSegList exposes SVG path commands so coordinates can be adjusted from C# code.
                foreach (SVGPathSeg pathSeg in pathElement.PathSegList)
                {
                    if (pathSeg is SVGPathSegMovetoAbs moveTo)
                    {
                        moveTo.X = 200;
                        moveTo.Y = 100;
                    }

                    if (pathSeg is SVGPathSegCurvetoQuadraticSmoothAbs smoothCurve)
                    {
                        smoothCurve.X -= 60;
                        smoothCurve.Y -= 65;
                    }
                }

                pathElement.SetAttribute("stroke", "#C8102E");
                pathElement.SetAttribute("fill", "none");
                pathElement.SetAttribute("stroke-width", "4");
                svgElement.AppendChild(pathElement);

                document.Save(outputPath);
            }

            Console.WriteLine($"Edited SVG path data: {outputPath}");
        }
    }
}
