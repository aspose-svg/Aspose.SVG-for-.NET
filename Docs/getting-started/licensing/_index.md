---
title: Licensing
type: docs
weight: 70
url: /net/licensing/
---

## **Evaluation Version Limitations**
A free evaluation version of Aspose.SVG for .NET can be downloaded from the downloads section of Aspose's website at: [Download Aspose.SVG API](https://www.nuget.org/packages/Aspose.SVG).
### **Limitation**
The evaluation version provides all the features except the following:

- Watermark is added to the output files
- Only the first four pages of the SVG document can be converted.
- Only 50% of SVG Document's nodes will be saved during serialization

{{% alert color="primary" %}} 

If you want to try Aspose.SVG without evaluation limitations, request a 30 day temporary license. Please refer to [How to get a Temporary License?](http://www.aspose.com/corporate/purchase/faqs/temporary-license.aspx) For more information.

{{% /alert %}} 
## **Apply License using File or Stream Object**
The license can be loaded from a [file](/svg/net/licensing/#licensing-loadingalicensefromfile) or [stream object](/svg/net/licensing/#licensing-loadingalicensefromastreamobject). Aspose.SVG for .NET will try to find the license in the following locations:

1. Explicit path.
1. The folder that contains Aspose.SVG.dll.
1. The folder that contains the assembly that called Aspose.SVG.dll.
1. The folder that contains the entry assembly (your .exe).
1. An embedded resource in the assembly that called Aspose.SVG.dll.

The easiest way to set a license is to put the license file in the same folder as the Aspose.SVG.dll file and specify the file name, without a path, as shown in the example below.

If you are using any other Aspose for .NET API along with Aspose.SVG for .NET, please specify the namespace for the license like Aspose.ThreeD.License.
### **Loading a License from File**
The easiest way to apply a license is to put the license file in the same folder as the Aspose.SVG.dll file and specify just the file name without a path.

{{% alert color="primary" %}} 

When you call the SetLicense method, the license name that you pass should be that of the license file. For example, if you change the license file name to "Aspose.SVG.lic.xml" pass that filename to threeD.SetLicense(…) method.

{{% /alert %}} 

**Example:**

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-GettingStarted-LoadLicense-LoadLicenseFromFile.cs" >}}
### ` `**Loading a License  from a Stream Object**
The following example shows how to load a license from a stream.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-GettingStarted-LoadLicense-LoadLicenseFromStream.cs" >}}
## **Apply License using Embedded Resource**
One way of applying a license is to set it using a file or stream object. Another neat way of packaging the license with your application and making sure it will not be lost is to include it as an embedded resource into one of the assemblies that calls the component's DLL (included in Aspose.SVG).

To include the license file as an embedded resource:

1. In Visual Studio .NET, include the license (.lic) file into the project by selecting **File**, then **Add Existing Item** and finally **Add**.
1. Select the file in the Solution Explorer.
1. Set the **Build Action** to **Embedded Resource** in the Properties window.
1. To access the license embedded in the assembly (as an embedded resource), just add the license file as an embedded resource to the project and pass the name of the license file to the SetLicense method. The License class automatically finds the license file in the embedded resources. There's no need to call the GetExecutingAssembly and GetManifestResourceStream methods of the System.Reflection.Assembly class in the Microsoft .NET Framework.

The following code snippet is used to set the license.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-GettingStarted-LoadLicense-ApplyLicenseUsingEmbeddedResource.cs" >}}
## **Apply Metered License**
Aspose.SVG for .NET API allows developers to apply the metered license. It is a new licensing mechanism. The new licensing mechanism will be used along with the existing licensing method. Those customers who want to be billed based on the usage of the API features can use the metered licensing. For more details, please refer to [Metered Licensing FAQ](http://www.aspose.com/corporate/purchase/policies/Licensing-Faqs/metered-faq.aspx) section.

A new class [Metered](https://apireference.aspose.com/net/3d/aspose.threed/metered/) has been added to apply the metered key. This code example demonstrates how to set metered public and private keys:

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-GettingStarted-LoadLicense-ApplyMeteredLicense.cs" >}}



