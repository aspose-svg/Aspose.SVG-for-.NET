using System;

namespace CSharp.SvgStylesAndFontsManagement
{
    public class SvgStylesAndFontsManagementExamples
    {
        public static void RunAll()
        {
            // Run all SVG Styles and Fonts Management examples from one place.
            // Users can comment out individual calls below when they want to focus on one scenario.
            Console.WriteLine("Running SvgStylesAndFontsManagement examples...");

            SvgStyleManagement.Run();
            SvgTextAndFonts.Run();
            SvgStyleAndFontTroubleshooting.Run();

            Console.WriteLine("SvgStylesAndFontsManagement examples finished.");
        }
    }
}
