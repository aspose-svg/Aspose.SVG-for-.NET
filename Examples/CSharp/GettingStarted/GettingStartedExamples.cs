using System;

namespace CSharp.GettingStarted
{
    class GettingStartedExamples
    {
        public static void RunAll()
        {
            Console.WriteLine("Running GettingStarted examples...");
            Console.WriteLine("These examples demonstrate Aspose.SVG license setup patterns.");
            Console.WriteLine("They are safe to run without a license file; missing credentials are reported and skipped.");

            LoadLicense.LoadLicenseFromFile();
            LoadLicense.LoadLicenseFromStream();
            LoadLicense.ApplyLicenseUsingEmbeddedResource();
            LoadLicense.ApplyMeteredLicense();

            Console.WriteLine("GettingStarted examples finished.");
        }
    }
}
