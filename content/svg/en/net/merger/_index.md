---
template: true
title: Combine SVG into popular formats Using C#
description: Combine Images or SVG to PDF, XPS, PNG, JPEG, etc. with few lines of C# code.
url: /net/merger/
---

{{< blocks/products/pf/main-wrap-class isAutogenPage="true">}}
{{< blocks/products/pf/feature-page-wrap >}}
{{< blocks/products/pf/feature-page-header h1="Combine SVG, JPEG, PNG or other Images using C#"  h2="Merge SVG or Image files together and save the result to popular formats including PDF, XPS, BMP, JPEG, PNG, GIF, and TIFF using C#" >}}

{{% blocks/products/pf/feature-page-section  h2="How to Merge SVG & Images Using C#" %}}

There are a lot of reasons why you need to combine several SVGs or Images into one document. To merge SVG files, we will use <a href="https://products.aspose.com/svg/net/" target="_blank">Aspose.SVG for .NET API</a> which is a feature-rich, powerful and easy-to-use document manipulation and merging API for the C# platform. Our C# library provides the <a href="https://reference.aspose.com/svg/net/aspose.svg.rendering/svgrenderer/" target="_blank">SvgRenderer </a>class for rendering and merging SVG documents. The Render() method gives you the ability to send multiple documents at once to the output rendering device and merge them. 



<h2>C# example to combine SVG to PDF</h2>

<p>A high-speed C# library allows .NET developers to merge SVG files and convert the combined result into many popular formats such as PDF, XPS, JPEG, PNG, BMP, GIF, and TIFF with high quality and efficiency. Documents merging can be done with a few lines of code:

</p>

{{% blocks/products/pf/agp/code-block title="Merge SVG to PDF - C#" offSpacer="true" %}}


```cs
// Initialize SVG documents from files to merge 
using (var document1 = new SVGDocument("document1.svg"))
using (var document2 = new SVGDocument("document2.svg"))
using (var document3 = new SVGDocument("document3.svg"))
{
    // Create an instance of SvgRenderer
    using var renderer = new Aspose.Svg.Rendering.SvgRenderer();	
    // Create an instance of SvgRenderer
    using var device = new Aspose.Svg.Rendering.Pdf.PdfDevice("result.pdf");
    //Merge all SVG documents to PDF
    renderer.Render(device, document1, document2, document3);                
}
```



{{% /blocks/products/pf/agp/code-block %}}
{{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="SVG Merger in Documentation" %}}

Aspose.SVG for .NET library lets you create, edit, read, convert, and merge SVG files programmatically using C#. The [Aspose.Svg.Rendering](https://reference.aspose.com/svg/net/aspose.svg.rendering/) namespace implements easy access to convert and merge methods. In addition, it provides combining SVG  files into popular formats, such as PDF, XPS, JPEG, PNG, BMP, TIFF, and GIF.  Please visit the documentation chapter <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-merge-svg-files/" target="_blank">How to Merge SVG Files</a> to learn more about SVG C# API merging features.



 {{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="Installing Aspose.SVG for .NET library" %}}

Aspose.SVG for .NET is a cross-platform flexible library that is designed to provide a wide range of features for processing and rendering SVG documents. It seamlessly integrates into your .NET Apps to work with SVG files without installing any 3rd party software.  Our SVG .NET API can be used with any .NET language, such as C#, VB.NET, ASP.NET, etc. It works equally well on any OS that can install Mono (.NET 4.0 Framework support) or use .NET core.  This includes Windows, Linux, and macOS.

Installing <a href="https://www.nuget.org/packages/Aspose.SVG" target="_blank">Aspose.SVG for .NET through NuGet</a>:

1. Using the Package Manager Console. 
2. Using the NuGet Package Manager GUI.</br>  

  For more details about C# library installation, please refer to [Aspose.SVG Documentation](https://docs.aspose.com/svg/net/getting-started/installation/).



{{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="Other Supported Mergers" %}}

You can combine SVG files into many other file formats including few listed below:

{{% /blocks/products/pf/feature-page-section %}}
{{< /blocks/products/pf/feature-page-wrap >}}
{{< /blocks/products/pf/main-wrap-class >}}
{{< blocks/products/pf/feature-page-options pairs="svg-to-pdf svg-to-xps svg-to-bmp jpg-to-jpg png-to-png gif-to-gif svg-to-png svg-to-jpeg svg-to-tiff jpg-to-png png-to-jpg gif-to-jpg svg-to-gif svg-to-image jpg-to-tiff jpg-to-gif png-to-gif gif-to-png" >}}