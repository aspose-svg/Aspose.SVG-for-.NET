---
template: true
title: Merge SVG to XPS via C# - Aspose.SVG
description: Merge SVG to XPS using C# on Windows, macOS & Linux
url: /net/merger/svg-to-xps/
family: svg
platformtag: net
feature: conversion
informat: SVG
outformat: XPS
otherformats: XPS PDF GIF JPEG PNG TIFF BMP
---
<!-- template1.md -->

{{< blocks/products/pf/main-wrap-class isAutogenPage="true" >}}

{{< blocks/products/pf/upper-banner h1="Merge SVG to XPS via C#" h2="High-speed .NET API to combine SVG files on Windows, macOS & Linux" logoImageSrc="https://www.aspose.cloud/templates/aspose/img/products/svg/headers/aspose_svg-for-net.svg" pfName="Aspose.SVG " subTitlepfName="for .NET" downloadUrl="https://downloads.aspose.com/svg/net" >}}

{{< blocks/products/pf/main-container >}}

{{% blocks/products/pf/agp/content h2="Merge SVG to XPS in C#" %}}

SVG is one of the most used formats for website building and print graphics to achieve scalability. But sometimes, you need to merge SVG files and save them as one document in another file format. XPS format has a set of advantages that support security features and more. With [Aspose.SVG for .NET](https://products.aspose.com/svg/net/) API, you can merge SVG to XPS programmatically. Powerful C# API helps you to combine SVG files quickly and in high quality!


<br>

<h2>C# code example to merge SVG to XPS</h2>

A high-speed C# library allows .NET developers to merge SVG files and convert the combined result into other popular formats such as PDF, XPS, JPEG, PNG, BMP, GIF, and TIFF quickly and efficiently. Documents merging can be done with a few lines of code:

<br>

{{% blocks/products/pf/agp/code-block title="Merge SVG to XPS - C#" offSpacer="true" %}}


```cs
// Initialize SVG documents from files to merge 
using (var document1 = new SVGDocument("document1.svg"))
using (var document2 = new SVGDocument("document2.svg"))
using (var document3 = new SVGDocument("document3.svg"))
{
    // Create an instance of SvgRenderer
    using var renderer = new Aspose.Svg.Rendering.SvgRenderer();	
    // Create an instance of XpsDevice
    using var device = new Aspose.Svg.Rendering.Xps.XpsDevice("result.xps");
    // Merge SVG to XPS
    renderer.Render(device, document1, document2, document3);                
}
```

 

<p></p></br></br>

{{% /blocks/products/pf/agp/code-block %}}

<h2>Steps to Merge SVG to XPS using C#</h2>

1.  Load an SVG document using one of the [SVGDocument()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/svgdocument/) constructors.
1.  Create a new instance of the [SvgRenderer](https://reference.aspose.com/svg/net/aspose.svg.rendering/svgrenderer/) class.
1.  Use the [XpsDevice()](https://reference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsdevice/xpsdevice/#constructor_5) constructor to initialize a new instance of the XpsDevice class.
1.  Call the [Render()](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderer-1/) method to merge SVGs into a single XPS file.
1.  Multiple SVG files will be saved into one XPS file at the specified path.


<br>


The [Aspose.Svg.Rendering](https://reference.aspose.com/svg/net/aspose.svg.rendering/) namespace implements easy access to Render() methods. You can quickly perform SVG merge and export the combining result to popular formats, such as PDF, XPS, JPEG, PNG, BMP, TIFF, and GIF. Please visit <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/" target="_blank">our documentation</a> to learn more about using Aspose.SVG API functions. In the documentation article <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-merge-svg-files/" target="_blank">How to Merge SVG Files</a>, you can consider C# examples of how to merge SVG.


<br>

<h2>Online SVG Merger</h2>

Aspose.SVG offers a free online <a href="https://products.aspose.app/svg/merger/svg" target="_blank">Merge SVG</a> app that combines multiple SVGs into a single file. You can choose a kind of SVG Merger for different output files such as SVG, JPG or PNG. Our application is multifunctional. You can create image collages, edit and manipulate SVG images before merging. SVG Merger allows you to freely add images, rotate, scale, add backgrounds, filters and move each image until you are happy with the end result of your design.



{{% /blocks/products/pf/agp/content %}}

{{% blocks/products/pf/agp/content h2="Get Started with .NET SVG API" %}}

Install from command line as ```nuget install Aspose.SVG``` or via Package Manager Console of Visual Studio with ```Install-Package Aspose.SVG```.
Alternatively, get the offline MSI installer or DLLs in a ZIP file from [downloads](https://downloads.aspose.com/svg/net). Aspose.SVG for .NET API is a standalone library and does not depend on any software for SVG document processing.
 For more details about C# library installation and system requirements, please refer to [Aspose.SVG Documentation](https://docs.aspose.com/svg/net/getting-started/).



{{% /blocks/products/pf/agp/content %}}

{{< blocks/products/pf/agp/other-supported-section title="Other Supported Mergers" subTitle="You can merge SVG & Images into other file formats:" >}}

{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-jpg/" name="JPG to JPG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-png/" name="JPG to PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-bmp/" name="JPG to BMP" description="Bitmap Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-gif/" name="JPG to GIF" description="Graphical Interchange Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-tiff/" name="JPG to TIFF" description="Tagged Image Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-png/" name="PNG TO PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-jpg/" name="PNG to JPG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-bmp/" name="PNG to BMP" description="Bitmap Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-gif/" name="PNG to GIF" description="Graphical Interchange Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-tiff/" name="PNG to TIFF" description="Tagged Image Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/gif-to-jpg/" name="GIF to JPG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/gif-to-png/" name="GIF to PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-pdf/" name="SVG TO PDF" description="Portable Document Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-xps/" name="SVG TO XPS" description="XML Paper Specifications" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-bmp/" name="SVG TO BMP" description="Bitmap Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-image/" name="SVG TO IMAGE" description="Image formats" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-jpeg/" name="SVG TO JPEG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-gif/" name="SVG TO GIF" description="Graphical Interchange Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-png/" name="SVG to PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-tiff/" name="SVG TO TIFF" description="Tagged Image Format" >}}

{{< /blocks/products/pf/agp/other-supported-section >}}
{{< /blocks/products/pf/main-container >}}
{{< /blocks/products/pf/main-wrap-class >}}