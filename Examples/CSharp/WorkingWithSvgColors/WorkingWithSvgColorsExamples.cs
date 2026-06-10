using System;

namespace CSharp.WorkingWithSvgColors
{
    class WorkingWithSvgColorsExamples
    {
        public static void RunAll()
        {
            Console.WriteLine("Running WorkingWithSvgColors examples...");

            SvgElementColors.Run();
            SvgBackgroundColors.Run();
            SvgColorCodeConversion.Run();

            Console.WriteLine("WorkingWithSvgColors examples finished.");
        }
    }
}
