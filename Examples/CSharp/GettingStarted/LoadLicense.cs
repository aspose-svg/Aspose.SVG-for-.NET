using Aspose.Svg;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CSharp.GettingStarted
{
    public class LoadLicense
    {
        private const string LicenseFileName = "Aspose.SVG.lic";
        private const string PublicKeyVariable = "ASPOSE_SVG_METERED_PUBLIC_KEY";
        private const string PrivateKeyVariable = "ASPOSE_SVG_METERED_PRIVATE_KEY";

        public static void LoadLicenseFromFile()
        {
            // Apply an Aspose.SVG for .NET license from a file in C#.
            // Put Aspose.SVG.lic into Examples/Data/ before running this example.
            string licensePath = GetLicenseFilePath();
            if (!File.Exists(licensePath))
            {
                PrintMissingLicenseFileMessage(licensePath);
                return;
            }

            var license = new License();
            license.SetLicense(licensePath);

            Console.WriteLine($"Aspose.SVG license loaded from file: {licensePath}");
        }

        public static void LoadLicenseFromStream()
        {
            // Apply an Aspose.SVG for .NET license from a FileStream in C#.
            // This pattern is useful when your application stores the license outside the default probing path.
            string licensePath = GetLicenseFilePath();
            if (!File.Exists(licensePath))
            {
                PrintMissingLicenseFileMessage(licensePath);
                return;
            }

            var license = new License();
            using (var stream = new FileStream(licensePath, FileMode.Open, FileAccess.Read))
            {
                license.SetLicense(stream);
            }

            Console.WriteLine($"Aspose.SVG license loaded from stream: {licensePath}");
        }

        public static void ApplyLicenseUsingEmbeddedResource()
        {
            // Apply an Aspose.SVG for .NET license embedded as an assembly resource.
            // Set the license file Build Action to Embedded Resource and pass the full resource name to SetLicense().
            string resourceName = Assembly.GetExecutingAssembly()
                .GetManifestResourceNames()
                .FirstOrDefault(name => name.EndsWith(LicenseFileName, StringComparison.OrdinalIgnoreCase));

            if (string.IsNullOrEmpty(resourceName))
            {
                Console.WriteLine("Embedded license resource was not found.");
                Console.WriteLine("Add Aspose.SVG.lic to the project, set Build Action to Embedded Resource, and run this example again.");
                return;
            }

            var license = new License();
            license.SetLicense(resourceName);

            Console.WriteLine($"Aspose.SVG license loaded from embedded resource: {resourceName}");
        }

        public static void ApplyMeteredLicense()
        {
            // Apply an Aspose.SVG metered license in C#.
            // Store metered keys in environment variables instead of hard-coding credentials in source code.
            string publicKey = Environment.GetEnvironmentVariable(PublicKeyVariable);
            string privateKey = Environment.GetEnvironmentVariable(PrivateKeyVariable);

            if (string.IsNullOrWhiteSpace(publicKey) || string.IsNullOrWhiteSpace(privateKey))
            {
                Console.WriteLine("Metered license keys were not found.");
                Console.WriteLine($"Set {PublicKeyVariable} and {PrivateKeyVariable} environment variables before running this example.");
                return;
            }

            var metered = new Metered();
            decimal amountBefore = Metered.GetConsumptionQuantity();

            metered.SetMeteredKey(publicKey, privateKey);

            decimal amountAfter = Metered.GetConsumptionQuantity();
            Console.WriteLine($"Metered consumption before API call: {amountBefore}");
            Console.WriteLine($"Metered consumption after API call: {amountAfter}");
        }

        private static string GetLicenseFilePath()
        {
            return Path.Combine(RunExamples.GetDataDir_Data(), LicenseFileName);
        }

        private static void PrintMissingLicenseFileMessage(string licensePath)
        {
            Console.WriteLine("Aspose.SVG license file was not found.");
            Console.WriteLine($"Expected path: {licensePath}");
            Console.WriteLine("The example was skipped. Add a valid Aspose.SVG.lic file to run it.");
        }
    }
}
