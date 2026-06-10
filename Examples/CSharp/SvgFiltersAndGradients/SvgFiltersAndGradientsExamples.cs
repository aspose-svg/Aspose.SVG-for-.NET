using System;

namespace CSharp.SvgFiltersAndGradients
{
    public class SvgFiltersAndGradientsExamples
    {
        public static void RunAll()
        {
            // Run all SVG Filters and Gradients examples from one place.
            // Users can comment out individual calls below when they want to focus on one scenario.
            Console.WriteLine("Running SvgFiltersAndGradients examples...");

            SvgFilterEffects.Run();
            SvgGradients.Run();

            Console.WriteLine("SvgFiltersAndGradients examples finished.");
        }
    }
}
