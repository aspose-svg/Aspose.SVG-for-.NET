---
template: true
title: Merge PNG to BMP via C# - Aspose.SVG
description: Merge PNG to BMP using C# on Windows, macOS & Linux
url: /net/merger/png-to-bmp/
family: svg
platformtag: net
feature: conversion
informat: PNG
outformat: BMP
otherformats: GIF JPEG PNG TIFF BMP
---
<!-- template1.md -->

{{< blocks/products/pf/main-wrap-class isAutogenPage="true" >}}

{{< blocks/products/pf/upper-banner h1="Merge PNG to BMP via C#" h2="High-speed .NET API to combine PNG files on Windows, macOS & Linux" logoImageSrc="https://www.aspose.cloud/templates/aspose/img/products/svg/headers/aspose_svg-for-net.svg" pfName="Aspose.SVG " subTitlepfName="for .NET" downloadUrl="https://downloads.aspose.com/svg/net" >}}

{{< blocks/products/pf/main-container >}}

{{% blocks/products/pf/agp/content h2="Merge PNG to BMP Using C#" %}}

PNG refers to a type of raster image file format that uses lossless compression, making it popular among users. Graphic files with a BMP format are uncompressed bitmapped images, so BMP pictures have a higher resolution than PNG ones. Both file formats have their own pros and cons, and in some cases, you may need to combine PNG images and save them as one BMP file. With [Aspose.SVG for .NET](https://products.aspose.com/svg/net/) API, you can merge PNG to BMP programmatically. Powerful C# API helps you to combine PNG files quickly and in high quality!


<br>

<h2>C# code example to merge PNG to BMP</h2>

Combine multiple PNG files and save the result as a single BMP file easily! Merging images can be done with a few lines of code:

<br>

{{% blocks/products/pf/agp/code-block title="Merge PNG to BMP - C#" offSpacer="true" %}}


```cs
// Images to merge 
var images = new string[] { @"image1.png", "image2.png" };
// Initialize a new instance of SVGDocument
using (var document = new SVGDocument())
{
    // Declare an image function
    SVGImageElement CreateThumbnail(string imagePath, int width, int height)
    {
        var image = (SVGImageElement)document.CreateElementNS("http://www.w3.org/2000/svg", "image");
        image.Href.BaseVal = imagePath;
        image.Width.BaseVal.Value = width;
        image.Height.BaseVal.Value = height;
        return image;
    }
    // Set a thumbnail size
    const int thumbnailWidth = 200;
    const int thumbnailHeight = 200;
    const int thumbnailMargin = 10;
    // Create thumbnails merging loop
    for (var i = 0; i < images.Length; i++)
    {
        // Create a thumbnail
        var thumbnail = CreateThumbnail(images[i], thumbnailWidth, thumbnailHeight);
        // Define coordinates 
        thumbnail.X.BaseVal.Value = 0;
        thumbnail.Y.BaseVal.Value = (thumbnailHeight + thumbnailMargin) * i;
        // Append the thumbnail to the document
        document.DocumentElement.AppendChild(thumbnail);
    }
    // Define saving options
    var options = new ImageRenderingOptions
    {
        Format = ImageFormat.Bmp,
        PageSetup =
        {
            Sizing = SizingType.FitContent
        }
    };    
    // Render document 
    document.RenderTo(new ImageDevice(options, "merged.bmp"));
}
```

 

<p></p></br></br>

{{% /blocks/products/pf/agp/code-block %}}

<h2>Steps to Merge PNG to BMP using C#</h2>

1. Define PNG images to merge. 
1. Initialize a new instance of the [SVGDocument](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/svgdocument/#constructor) class. 
1. Declare an image function. You should use the [CreateElementNS(`namespaceURI, qualifiedName`)](https://reference.aspose.com/svg/net/aspose.svg.dom/document/createelementns/#createelementns) method of the SVGDocument class to create an image instance. The `namespaceURI` sets the reference to W3C SVG specification. The `qualifiedName` must contain the string tag name of the image element.
1. Call the image function to create a thumbnail object.
1. To add thumbnails to the document, use [AppendChild()](https://reference.aspose.com/svg/net/aspose.svg.dom/node/appendchild/#appendchild) method.
1. Use one of the [ImageRenderingOptions()](https://reference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/) constructor to initialize a new instance of the ImageRenderingOptions class. You can customize the rendering process by specifying the page size, image format, etc. PNG is used as the default image format.
1. Create an instans of ImageDevice using the [ImageDevice()](https://reference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/imagedevice/#constructor_3) constructor.
1. Call the [RenderTo(`device`)](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/renderto/#renderto) method to send the current document to the output rendering device.
1. Multiple PNG images will be saved into one BMP file on the specified path.


<br>


A high-speed C# library allows .NET developers to merge PNG files into one BMP image quickly and efficiently. The [Aspose.Svg.Rendering.Image](https://reference.aspose.com/svg/net/aspose.svg.rendering.image/) namespace provides specific device classes as well as a few rendering options classes responsible for rendering to raster formats: JPEG, PNG, BMP, GIF, and TIFF. Please visit <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/" target="_blank">our documentation</a> to learn more about using Aspose.SVG API functions. 


<br>

<h2>Online Image Merger</h2>

Aspose.SVG offers a free online <a href="https://products.aspose.app/svg/merger" target="_blank">Image Merger</a> App that combines multiple images into a single file. You can choose a kind of Image Merger for different source files such as SVG, JPG, PNG, BMP, ICO, GIF, or TIFF, and save the result to one of the following output formats: JPG, PNG or SVG. Our application is multifunctional. You can create image collages, edit and manipulate images before merging. Image Merger allows you to freely add images, rotate, scale, add backgrounds, filters and move each image until you are happy with the end result of your design.



{{% /blocks/products/pf/agp/content %}}

{{% blocks/products/pf/agp/content h2="Get Started with .NET SVG API" %}}

Install from command line as ```nuget install Aspose.SVG``` or via Package Manager Console of Visual Studio with ```Install-Package Aspose.SVG```.
Alternatively, get the offline MSI installer or DLLs in a ZIP file from [downloads](https://downloads.aspose.com/svg/net). Aspose.SVG for .NET API is a standalone library and does not depend on any software for SVG document processing.
 For more details about C# library installation and system requirements, please refer to [Aspose.SVG Documentation](https://docs.aspose.com/svg/net/getting-started/).



{{% /blocks/products/pf/agp/content %}}

{{< blocks/products/pf/agp/other-supported-section title="Other Supported Mergers" subTitle="You can merge Images to many other file formats:" >}}

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