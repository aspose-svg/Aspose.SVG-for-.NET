# Aspose.SVG for .NET

[Aspose.SVG for .NET](https://products.aspose.com/svg/net) is an API to create, read, update and convert SVG files to several different file format. It facilitates .NET application developers to work with .svg files without the need of installing any other application on server or client machines. With Aspose.SVG for .NET, you purely focus on your business logic instead of going into the underlying details of the .svg file format. It lets you save time and effort by allowing you to write short and simple lines of code in your applications quickly and easily.

<p align="center">

  <a title="Download complete Aspose.SVG for .NET source code" href="https://github.com/aspose-svg/Aspose.SVG-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

This repository contains [Demos](Demos) and [Examples](Examples) project for [Aspose.SVG for .NET](https://products.aspose.com/svg/net) to help you learn and write your own applications.

Directory | Description
--------- | -----------
[Demos](Demos)  | Aspose.SVG for .NET Live Demos Source Code
[Examples](Examples)  | A collection of .NET examples that help you learn the product features

# Process & Manipulate SVG via .NET API

This .NET on-premise API helps you [seamlessly integrate SVG file processing & manipulation](https://products.aspose.com/svg/net) functionality into your C#, VB.NET, ASP.NET & other .NET based apps.

## SVG File Processing Features

- [Create, read](https://docs.aspose.com/display/svgnet/Create+and+Read+SVG+Documents) and [write SVG](https://docs.aspose.com/display/svgnet/Save+SVG+Files) format files.
- [Convert SVG](https://docs.aspose.com/display/svgnet/How+to+Convert+SVG+Files) to other [supported file formats](https://docs.aspose.com/display/svgnet/Supported+File+Formats).
- DOM Tree manipulation as per official SVG specs.
- Support for content navigation via [XPath Query](https://docs.aspose.com/display/svgnet/Traverse+SVG+DOM#TraverseSVGDOM-UsingXPathQuery), [CSS Selectors](https://docs.aspose.com/display/svgnet/Traverse+SVG+DOM#TraverseSVGDOM-UsingCSSSelector), Element and Document Traversal features.
- Support for quality rendering.

## Read Supported Formats

SVG

## Save SVG As

**Fixed Layout:** PDF, XPS
**Image:** TIFF, BMP, PNG, JPEG, GIF

## Platform Independence

Any operating system that can install Mono (.NET 4.0 Framework support) or use .NET core can use Aspose.SVG for .NET. This includes Windows, Linux, and MacOS.

## Getting Started with Aspose.SVG for .NET

Are you ready to give Aspose.SVG for .NET a try? Simply execute `Install-Package Aspose.SVG` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.SVG for .NET and want to upgrade the version, please execute `Update-Package Aspose.SVG` to get the latest version.

## Use C# to Convert SVG to PNG format

```csharp
string dataDir = RunExamples.GetDataDir_Data();
using (var document = new SVGDocument(Path.Combine(dataDir, "sourcefile.svg"))){
    using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Png), dataDir + "targetfile.png")){
        document.RenderTo(device);
    }
}
```

[Product Page](https://products.aspose.com/svg/net) | [Docs](https://docs.aspose.com/display/svgnet/Home) | [API Reference](https://apireference.aspose.com/svg/net) | [Examples](https://github.com/aspose-svg/Aspose.SVG-for-.NET) | [Blog](https://blog.aspose.com/category/svg/) | [Free Support](https://forum.aspose.com/c/svg) |  [Temporary License](https://purchase.aspose.com/temporary-license)
