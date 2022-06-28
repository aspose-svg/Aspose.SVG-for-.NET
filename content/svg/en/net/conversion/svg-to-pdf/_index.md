---
template: true
title: Convert SVG to PDF with C# Core
description: Load and Convert SVG to PDF using .NET Core API on Windows, macOS & Linux
url: /net/conversion/svg-to-pdf/
family: svg
platformtag: net
feature: conversion
informat: SVG
outformat: PDF
otherformats: GIF JPEG PNG TIFF BMP PDF XPS
---
<!-- template1.md -->

{{< blocks/products/pf/main-wrap-class isAutogenPage="true" >}}

{{< blocks/products/pf/upper-banner h1="Convert SVG to PDF via C#" h2="High-speed .NET API for converting SVG to PDF on Windows, macOS & Linux" logoImageSrc="https://www.aspose.cloud/templates/aspose/img/products/svg/headers/aspose_svg-for-net.svg" pfName="Aspose.SVG " subTitlepfName="for .NET" downloadUrl="https://downloads.aspose.com/svg/net" >}}

{{< blocks/products/pf/main-container >}}

{{% blocks/products/pf/agp/content h2="SVG to PDF Conversion via .NET Core" %}}

SVG is one of the most used formats for website building and print graphics to achieve scalability. But sometimes, you need to convert SVG and save it in another file format.  With [Aspose.SVG for .NET](https://products.aspose.com/svg/net/) API, you can transform SVG to PDF programmatically with full control over a wide range of conversion parameters. Powerful C# API allows you to convert SVG to popular formats with high speed and high quality.



<br>

<h2>Free Online Converter Live Demos</h2>

Test the quality of SVG to PDF conversion right in your browser! The following C# example demonstrates how to convert an SVG document using ConvertSVG() method. We describe the source code for reading SVG from a file and then converting SVG to PDF with default saving options. Please load SVG from the local file system, select the output format and run the example. You will immediately get the result as a separate file.



{{% /blocks/products/pf/agp/content %}}


{{< app/svg/converter SVG PDF "JPG|JPEG" BMP XPS TIFF PNG GIF >}}
using Aspose.Svg;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;

    using var document = new SVGDocument("image.svg");
{{#if_output 'PDF'}}
    var options = new PdfSaveOptions();
{{/if_output}}
{{#if_output 'XPS'}}
    var options = new XpsSaveOptions();
{{/if_output}}
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output param2 camel}});
{{/if_output}}
    Converter.ConvertSVG(document, options, "output.{{output lower}}");   
{{< /app/svg/converter>}} 

 

{{% blocks/products/pf/agp/content %}}


Please visit <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/" target="_blank">our documentation</a> to learn more about using Aspose.SVG API conversion functions and to consider C# examples for the most common SVG conversion scenarios. In the documentation chapter <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/" target="_blank">How to Convert SVG Files</a>, you can consider C# examples of how to convert SVG to PDF in different ways. Let's consider some of them: 


<br>

<h2>Steps to Convert SVG to PDF using ConvertSVG() Method</h2>

1.  Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) class.
1.  Create a new  [PdfSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/pdfsaveoptions) object.
1.  Use the [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/convertsvg/) method to save SVG as a PDF file. You need to pass the SVGDocument, PdfSaveOptions, and output file path to the ConvertSVG() method.
1.  The PDF file will be saved to the specified path.


<br>

<h2>Steps to Convert SVG to PDF using RenderTo() Method</h2>

1. Initialize [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) with your SVG file.
1. Create an object of the PdfRenderingOptions class. Use the [PdfRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/constructors/1) constructor and specify the `Format` property of the document.
1. Initialize [PdfDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfdevice) class and specify the output file name to render. 
1. Call [RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method & pass the instance of the PdfDevice.



{{% blocks/products/pf/agp/code-block title="Convert SVG to PDF" offSpacer="true" %}}


```cs
using (var document = new SVGDocument("input.svg"))
{
	var options = new PdfRenderingOptions();
	using (IDevice device = new PdfDevice(options, "output.pdf"))
	{
		document.RenderTo(device);                    
	}
}
```

 

{{% /blocks/products/pf/agp/code-block %}}

{{% /blocks/products/pf/agp/content %}}

{{% blocks/products/pf/agp/content h2="Get Started with .NET SVG API" %}}

Install from command line as ```nuget install Aspose.SVG``` or via Package Manager Console of Visual Studio with ```Install-Package Aspose.SVG```.
Alternatively, get the offline MSI installer or DLLs in a ZIP file from [downloads](https://downloads.aspose.com/svg/net). Aspose.SVG for .NET API is a standalone library and does not depend on any software for SVG document processing.
 For more details about C# library installation and system requirements, please refer to [Aspose.SVG Documentation](https://docs.aspose.com/svg/net/getting-started/).



{{% /blocks/products/pf/agp/content %}}

{{< blocks/products/pf/agp/other-supported-section title="Other Supported SVG Conversions" subTitle="You can also convert SVG to many other file formats:" >}}

{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-pdf/" name="SVG TO PDF" description="Portable Document Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-xps/" name="SVG TO XPS" description="XML Paper Specifications" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-bmp/" name="SVG TO BMP" description="Bitmap Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-image/" name="SVG TO IMAGE" description="Image formats" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-jpeg/" name="SVG TO JPEG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-gif/" name="SVG TO GIF" description="Graphical Interchange Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-png/" name="SVG TO PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-tiff/" name="SVG TO TIFF" description="Tagged Image Format" >}}

{{< /blocks/products/pf/agp/other-supported-section >}}
{{< /blocks/products/pf/main-container >}}
{{< /blocks/products/pf/main-wrap-class >}}