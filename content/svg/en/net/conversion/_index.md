---
template: true
title: Convert SVG to popular formats Using C#
description: Convert SVG to PDF, XPS, and Images with few lines of C# code via .NET library.
url: /net/conversion/
---

{{< blocks/products/pf/main-wrap-class isAutogenPage="true">}}
{{< blocks/products/pf/feature-page-wrap >}}
{{< blocks/products/pf/feature-page-header h1="SVG Conversion Via C#"  h2="Convert SVG to PDF, XPS, and Images including BMP, JPEG, PNG, TIFF to build cross-platform .NET applications" >}}

{{% blocks/products/pf/feature-page-section  h2="How to Convert SVG Using C#" %}}

SVG (Scalable Vector Graphics) is an XML-based image format for two-dimensional graphics. It is a vector graphics format intended primarily for the Web. The main excellence of SVG is its unmatched ability to be scaled to any size without any shred of quality degradation. All modern browsers support SVG, and it would seem that the Web should already switch to vector graphics. However, there are some restrictions on the use of SVG and sometimes you need to convert SVG to other formats.
 
<a href="https://products.aspose.com/svg/net/" target="_blank">Aspose.SVG for .NET API</a> makes the conversion process easier for developers. Converting between formats can perform by using a few different approaches:
 - The static [Converter class](https://reference.aspose.com/svg/net/aspose.svg.converters/converter/) is a shared facade that provides SVG file conversions to the popular formats and allows to make these operations convenient and easy. 

 - The [RenderTo()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/renderto/) method is used to render SVG to another format and send a document to the output device. Aspose.SVG API provides the following output devices implementation: the PdfDevice, XpsDevice,  and ImageDevice classes, which perform rendering to PDF, XPS, and Image file formats respectively.



<h2>SVG Converter Live Demos</h2>

You can convert SVG with Aspose.SVG for .NET API in real-time.  The following C# example demonstrates how to convert an SVG document. Please load a file from the local file system, select the output format and run the example. You will immediately get the result as a separate file.



{{% /blocks/products/pf/feature-page-section %}}


{{< app/svg/converter SVG PDF BMP "JPG|JPEG" PNG GIF TIFF XPS>}}
using Aspose.Svg;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;

    using var document = new SVGDocument("input.{{input lower}}");
{{#if_output 'PDF'}}
    var options = new PdfSaveOptions();
{{/if_output}}
{{#if_output 'DOCX'}}
    var options = new DocSaveOptions();
{{/if_output}}
{{#if_output 'XPS'}}
    var options = new XpsSaveOptions();
{{/if_output}}
{{#if_output 'MD'}}
    var options = new MarkdownSaveOptions();
{{/if_output}}
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output camel}});
{{/if_output}}
    Converter.ConvertSVG(document, options, "output.{{output lower}}");
{{< /app/svg/converter>}}



{{% blocks/products/pf/feature-page-section  h2="Popular SVG Conversions in Documentation" %}}

Aspose.SVG for .NET library lets you create, edit, read and convert SVG files programmatically using C#. The main highlight of SVG C# API is a conversion feature. The [Aspose.SVG.Converters](https://reference.aspose.com/svg/net/aspose.svg.converters/) namespace implements easy access to conversion methods. It provides a wide range of SVG conversions to popular formats, such as PDF, XPS, JPEG, PNG, BMP, TIFF, and GIF. Please visit the documentation chapter <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/" target="_blank">How to Convert SVG Files</a> to learn more about SVG C# API conversion features.

<div>
	<ul>
		<li><a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/convert-svg-to-pdf/" target="_blank">Convert SVG to PDF</a></li>
		<li><a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/convert-svg-to-xps/" target="_blank">Convert SVG to XPS</a></li>
		<li><a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/convert-svg-to-image/" target="_blank">Convert SVG to Image</a></li>							
	</ul>
</div>



 {{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="Installing Aspose.SVG for .NET library" %}}

Aspose.SVG for .NET is a cross-platform flexible library that is designed to provide a wide range of features for processing and rendering SVG documents. It seamlessly integrates into your .NET Apps to work with SVG files without installing any 3rd party software.  Our SVG .NET API can be used with any .NET language, such as C#, VB.NET, ASP.NET, etc. It works equally well on any OS that can install Mono (.NET 4.0 Framework support) or use .NET core.  This includes Windows, Linux, and macOS.

Installing <a href="https://www.nuget.org/packages/Aspose.SVG" target="_blank">Aspose.SVG for .NET through NuGet</a>:

1. Using the Package Manager Console. 
1. Using the NuGet Package Manager GUI.  

For more details about C# library installation, please refer to [Aspose.SVG Documentation](https://docs.aspose.com/svg/net/getting-started/installation/).



{{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="Other Supported Conversions" %}}

You can also convert SVG files into many other file formats including few listed below:

{{% /blocks/products/pf/feature-page-section %}}
{{< /blocks/products/pf/feature-page-wrap >}}
{{< /blocks/products/pf/main-wrap-class >}}
{{< blocks/products/pf/feature-page-options pairs="svg-to-pdf svg-to-xps svg-to-bmp svg-to-png svg-to-jpeg svg-to-tiff svg-to-gif svg-to-image" >}}