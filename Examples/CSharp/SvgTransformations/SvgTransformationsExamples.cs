using System;

namespace CSharp.SvgTransformations
{
    public class SvgTransformationsExamples
    {
        public static void RunAll()
        {
            // Run all SVG Transformation examples from one place.
            // Users can comment out individual calls below when they want to focus on one scenario.
            Console.WriteLine("Running SvgTransformations examples...");

            RotateSvgElements.Run();
            TranslateAndScaleSvgElements.Run();
            MatrixAndViewBoxTransformations.Run();

            Console.WriteLine("SvgTransformations examples finished.");
        }
    }
}
