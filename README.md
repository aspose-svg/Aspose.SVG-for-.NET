[Home](https://metrics.aspose.com/) | [Product Page](https://products.aspose.com/svg/net/) | [Docs](https://docs.aspose.com/svg/net/) | [API Reference](https://apireference.aspose.com/svg/net/) | [NuGet](https://www.nuget.org/packages/Aspose.svg) | [Blog](https://blog.aspose.com/categories/aspose.svg-product-family/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/svg/42) | [Temporary License](https://purchase.aspose.com/temporary-license)

![Nuget](https://img.shields.io/nuget/v/Aspose.Svg) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Svg) ![GitHub](https://img.shields.io/github/license/aspose-svg/Aspose.Svg-for-.NET)

# Aspose.SVG for .NET – Process & Manipulate SVG via .NET API

[**Aspose.SVG for .NET**](https://products.aspose.com/svg/net) is a robust API for working with Scalable Vector Graphics (SVG) in .NET applications. It enables developers to programmatically create, load, edit, traverse, render, and convert SVG documents, without relying on external graphics tools.

This repository provides the .NET SDK, ready-to-run examples, and concise developer-oriented documentation to help you quickly integrate SVG processing into your applications.

<p align="center">

  <a title="Download complete Aspose.SVG for .NET source code" href="https://github.com/aspose-svg/Aspose.SVG-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

## Repository Structure

This repository is organized to help you find what you need quickly:

Directory | Description
--------- | -----------
[Docs](Docs) | Mini-articles intended to help developers quickly get started with Aspose.SVG for .NET.
[Examples](Examples) | A collection of .NET examples that help you learn the product features.

The `Docs` and `Examples` folders are designed to be used together: documentation explains the concepts, while examples demonstrate working code.

## Key Capabilities

Aspose.SVG for .NET covers the most common SVG workflows required in real-world applications:

* **Create and load SVG documents** from files, streams, URLs, or memory strings.
* **Edit SVG content** using a full DOM API (elements, attributes, paths, styles).
* **Traverse and inspect the SVG DOM** using standard navigation techniques.
* **Convert SVG to PDF** for document publishing and reporting scenarios.
* **Convert SVG to raster images** (PNG, JPG, BMP, TIFF, GIF).
* **Save SVG as SVGZ** (compressed SVG).
* **Render SVG with fine-grained control** over resolution, page size, background, and output settings.
* **Vectorize raster images** and text into SVG paths.

The API is designed for automation, batch processing, and backend services, as well as desktop and server-side applications.

## Quick Start

## Convert SVG to PDF in C#

Aspose.SVG for .NET allows you to convert SVG files to PDF documents using a single API call. This approach is ideal for server-side applications, reporting systems, and document generation workflows where vector graphics must be preserved in a fixed-layout format.

```c#
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;

    // Convert SVG to PDF
    Converter.ConvertSVG("image.svg", new PdfSaveOptions(), "image.pdf");
```

## Convert SVG to Image Formats (PNG, JPG, BMP, TIFF, GIF, WEBP)

You can convert SVG documents to raster image formats by loading the SVG into an` SVGDocument` and applying `ImageSaveOptions`. This method gives you more control over rendering parameters and is suitable for generating previews, thumbnails, and bitmap-based outputs.

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Saving;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Converters;

// Initialize an SVG document from a file
using (SVGDocument document = new SVGDocument(Path.Combine(DataDir, "image.svg")))
{
    // Initialize ImageSaveOptions
    ImageSaveOptions saveOptions = new ImageSaveOptions(ImageFormat.Jpeg);

    // Convert SVG to JPG
    Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "image.jpg"));
}
```

## Vectorize Images – Convert Raster Files to SVG

Aspose.SVG for .NET supports image vectorization, allowing you to convert raster images such as PNG or JPG into scalable SVG graphics. This is useful for creating resolution-independent graphics, optimizing assets, and transforming bitmap images into editable vector paths.

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;

// Initialize an instance of the ImageVectorizer class
ImageVectorizer vectorizer = new ImageVectorizer();

// Vectorize image from a specified file
SVGDocument document = vectorizer.Vectorize(Path.Combine(DataDir, "flower.png"));

// Save the vectorized image as an SVG file 
document.Save(Path.Combine(OutputDir, "flower.svg"));
```

## Getting Started with Aspose.SVG for .NET

1. Install Aspose.SVG for .NET using NuGet or download the library.

For example, run the following command in the Visual Studio Package Manager Console to download the NuGet package:
`Install-Package Aspose.SVG`

If you already have Aspose.SVG for NET installed and you want to update it, run the following command to get the latest version:
`Update-Package Aspose.SVG`

2. Review the **Docs/getting-started** section for installation and licensing basics. Any operating system that can install Mono (.NET 6.0+ Framework support) or use .NET Core can use Aspose.SVG for .NET. This includes Windows, Linux, and MacOS.
3. Explore the **Examples** folder to see common scenarios in action.
4. Use the API reference for detailed class and method descriptions.

## Contribution and Support

In order to make changes in the repository, you need to:

1. Create a branch with the proposed changes whose name matches the feature/* pattern.
2. Create a pull request for this branch. It will be automatically assigned to a suitable reviewer.
3. Once the request is approved, it can be merged.

If you encounter issues, have questions, or need technical assistance:

* Use the official documentation and API reference.
* Visit the Aspose support forums.

## Licensing

Aspose.SVG for .NET is a commercial library. You can start with a free evaluation and later apply a license for production use. Licensing details and instructions are available in the [documentation](https://docs.aspose.com/svg/net/getting-started/licensing/).

[Home](https://metrics.aspose.com/) | [Product Page](https://products.aspose.com/svg/net/) | [Docs](https://docs.aspose.com/svg/net/) | [API Reference](https://apireference.aspose.com/svg/net/) | [NuGet](https://www.nuget.org/packages/Aspose.svg) | [Blog](https://blog.aspose.com/categories/aspose.svg-product-family/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/svg/42) | [Temporary License](https://purchase.aspose.com/temporary-license)
