using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GettingStarted
{
    public class LoadLicense
    {
        

        public static void LoadLicenseFromFile()
        {
            //ExStart: LoadLicenseFromFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Data();

            string fileName = dataDir + "Aspose.SVG.lic.Lic";

            License svgLicense = new License();

            svgLicense.SetLicense(fileName);
            //ExEnd: LoadLicenseFromFile
        }

        public static void LoadLicenseFromStream()
        {
            //ExStart: LoadLicenseFromStream
            string dataDir = RunExamples.GetDataDir_Data();
            // Initialize license object
            License svgLicense = new License();
            // Load license in FileStream
            FileStream myStream = new FileStream("Aspose.SVG.lic", FileMode.Open);
            // Set license
            svgLicense.SetLicense(myStream);
            //ExEnd: LoadLicenseFromStream
        }


        public static void ApplyLicenseUsingEmbeddedResource()
        {
            //ExStart: ApplyLicenseUsingEmbeddedResource
            
            License svgLicense = new License();

            // Pass the name of the embedded license file
            svgLicense.SetLicense("Aspose.SVG.lic");
            //ExEnd: ApplyLicenseUsingEmbeddedResource
        }

        public static void ApplyMeteredLicense()
        {
            //ExStart: ApplyMeteredLicense

            // Create an instance of CAD Metered class
           Metered metered = new Metered();

            // Access the setMeteredKey property and pass public and private keys as parameters
            metered.SetMeteredKey("*****", "*****");

            // Get metered data amount before calling API
            decimal amountbefore = Metered.GetConsumptionQuantity();

            // Display information
            Console.WriteLine("Amount Consumed Before: " + amountbefore.ToString());
            // Get metered data amount After calling API
            decimal amountafter = Metered.GetConsumptionQuantity();

            // Display information
            Console.WriteLine("Amount Consumed After: " + amountafter.ToString());
            //ExEnd: ApplyMeteredLicense
        }
    }
}
