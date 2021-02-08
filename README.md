![Nuget](https://img.shields.io/nuget/v/Aspose.Svg) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Svg) ![GitHub](https://img.shields.io/github/license/aspose-svg/Aspose.Svg-for-.NET)

# Process & Manipulate SVG via .NET API

[Aspose.SVG for .NET](https://products.aspose.com/svg/net) is an API to create, read, update and convert SVG files to several different file format. It facilitates .NET application developers to work with SVG files without the need of installing any other application on server or client machines.

<p align="center">

  <a title="Download complete Aspose.SVG for .NET source code" href="https://github.com/aspose-svg/Aspose.SVG-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>


Directory | Description
--------- | -----------
[Demos](Demos)  | Source code for the live demos hosted at https://products.aspose.app/svg/family.
[Examples](Examples)  | A collection of .NET examples that help you learn the product features.


## SVG File Processing

- [Create, read](https://docs.aspose.com/svg/net/create-and-read-svg-documents/) and [write SVG](https://docs.aspose.com/svg/net/save-svg-files/) files.
- [Convert SVG](https://docs.aspose.com/svg/net/how-to-convert-svg-files/) to other [supported file formats](https://docs.aspose.com/svg/net/supported-file-formats/).
- DOM Tree manipulation as per official SVG specs.
- Support for content navigation via [XPath Query](https://docs.aspose.com/svg/net/traverse-svg-dom/), CSS Selectors, Element and Document Traversal features.
- Support for quality rendering.

## Read Supported Formats

SVG

## Save SVG As

**Fixed Layout:** PDF, XPS
**Image:** TIFF, BMP, PNG, JPEG, GIF

## Platform Independence

Any operating system that can install Mono (.NET 4.0 Framework support) or use .NET core can use Aspose.SVG for .NET. This includes Windows, Linux, and MacOS.

## Get Started with Aspose.SVG for .NET

Are you ready to give Aspose.SVG for .NET a try? Simply execute `Install-Package Aspose.SVG` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.SVG for .NET and want to upgrade the version, please execute `Update-Package Aspose.SVG` to get the latest version.

## Use C# to Convert SVG to PNG format

```csharp
string dataDir = RunExamples.GetDataDir_Data();
using (var document = new SVGDocument(Path.Combine(dataDir, "template.svg"))){
    using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Png), dataDir + "output.png")){
        document.RenderTo(device);
    }
}
```

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/svg/net) | [Docs](https://docs.aspose.com/svg/net/) | [API Reference](https://apireference.aspose.com/svg/net) | [Examples](https://github.com/aspose-svg/Aspose.SVG-for-.NET) | [Blog](https://blog.aspose.com/category/svg/) | [Free Support](https://forum.aspose.com/c/svg) |  [Temporary License](https://purchase.aspose.com/temporary-license)
