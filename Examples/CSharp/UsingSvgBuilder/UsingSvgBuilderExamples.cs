using System;

namespace CSharp.UsingSvgBuilder
{
    class UsingSvgBuilderExamples
    {
        public static void RunAll()
        {
            Console.WriteLine("Running UsingSvgBuilder examples...");

            BasicSvgBuilder.Run();
            SvgBuilderShapesAndPaths.Run();
            SvgBuilderStylesAndPaint.Run();
            SvgBuilderFiltersAndClipping.Run();

            Console.WriteLine("UsingSvgBuilder examples finished.");
        }
    }
}
