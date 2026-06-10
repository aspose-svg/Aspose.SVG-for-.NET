[Home](https://metrics.aspose.com/) | [Product Page](https://products.aspose.com/svg/net/) | [Docs](https://docs.aspose.com/svg/net/) | [API Reference](https://reference.aspose.com/svg/net/) | [NuGet](https://www.nuget.org/packages/Aspose.SVG/) | [Blog](https://blog.aspose.com/categories/aspose.svg-product-family/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/svg/28) | [Temporary License](https://purchase.aspose.com/temporary-license/)

![NuGet](https://img.shields.io/nuget/v/Aspose.SVG) ![NuGet](https://img.shields.io/nuget/dt/Aspose.SVG) ![GitHub](https://img.shields.io/github/license/aspose-svg/Aspose.SVG-for-.NET)

# Aspose.SVG for .NET – Process and Manipulate SVG via .NET API

[**Aspose.SVG for .NET**](https://products.aspose.com/svg/net/) is an API for working with Scalable Vector Graphics (SVG) in .NET applications. It enables developers to programmatically create, load, edit, traverse, render, vectorize, save, and convert SVG documents without relying on external graphics tools.

This repository provides practical developer documentation and ready-to-run C# examples to help you integrate SVG processing into .NET applications.

<p align="center">
  <a title="Download complete Aspose.SVG for .NET examples and docs" href="https://github.com/aspose-svg/Aspose.SVG-for-.NET/archive/master.zip">
    <img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

## Repository Structure

This repository is organized to help you find what you need quickly:

Directory | Description
--------- | -----------
[Docs](Docs/README.md) | Short developer guides and getting-started articles for Aspose.SVG for .NET.
[Examples](Examples/README.md) | Ready-to-run C# examples and shared sample data.

The `Docs` and `Examples` folders are designed to be used together: documentation explains the concepts, while examples demonstrate working code.

## Key Capabilities

Aspose.SVG for .NET covers common SVG workflows required in real-world .NET applications:

* **Create and load SVG documents** from files, streams, URLs, or memory strings.
* **Edit SVG content** using DOM APIs for elements, attributes, paths, styles, colors, and text.
* **Traverse and inspect the SVG DOM** using DOM navigation, CSS selectors, and XPath.
* **Convert SVG to PDF** for document publishing and reporting scenarios.
* **Convert SVG to raster images** such as PNG, JPEG, BMP, TIFF, and GIF.
* **Save SVG as SVGZ** for compressed SVG storage and delivery.
* **Render SVG with configurable options** such as page setup, background color, resolution, and image quality.
* **Vectorize raster images and text** into SVG paths.
* **Build SVG programmatically** with the SVG Builder API.

The API is designed for automation, batch processing, backend services, desktop applications, and server-side SVG workflows.

## Quick Start

### Convert SVG to PDF in C#

Aspose.SVG for .NET allows you to convert SVG files to PDF documents using a single API call. This approach is useful for server-side applications, reporting systems, and document generation workflows.

```csharp
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;

Converter.ConvertSVG("image.svg", new PdfSaveOptions(), "image.pdf");
```

### Convert SVG to Image Formats in C#

You can convert SVG documents to raster image formats by loading the SVG into an `SVGDocument` and applying `ImageSaveOptions`. This is useful for previews, thumbnails, and bitmap-based output.

```csharp
using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("image.svg"))
{
    var saveOptions = new ImageSaveOptions(ImageFormat.Jpeg);
    Converter.ConvertSVG(document, saveOptions, "image.jpeg");
}
```

### Vectorize Images – Convert Raster Files to SVG

Aspose.SVG for .NET supports image vectorization, allowing you to convert raster images such as PNG or JPEG into scalable SVG graphics.

```csharp
using Aspose.Svg;
using Aspose.Svg.ImageVectorization;

var vectorizer = new ImageVectorizer();

using (SVGDocument document = vectorizer.Vectorize("flower.png"))
{
    document.Save("flower.svg");
}
```

## Getting Started with Aspose.SVG for .NET

1. Install Aspose.SVG for .NET using NuGet:

   ```powershell
   dotnet add package Aspose.SVG
   ```

   Or use Visual Studio Package Manager Console:

   ```powershell
   Install-Package Aspose.SVG
   ```

1. Review the [Docs/getting-started](Docs/getting-started/) section for installation, licensing, supported features, and supported file formats.
1. Explore the [Examples](Examples/README.md) folder to see common scenarios in action.
1. Use the [API Reference](https://reference.aspose.com/svg/net/) for detailed class and method descriptions.

## Run C# Examples

From the repository root, run a C# examples section:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSVGDocument
```

For the full section list and Visual Studio launch profile instructions, see [Examples/CSharp/README.md](Examples/CSharp/README.md).

## Contribution and Support

To contribute changes to this repository:

1. Create a branch with the proposed changes.
1. Update or add focused examples and documentation.
1. Open a pull request for review.

If you encounter issues, have questions, or need technical assistance:

* Use the [official documentation](https://docs.aspose.com/svg/net/) and [API reference](https://reference.aspose.com/svg/net/).
* Visit the [Aspose.SVG support forum](https://forum.aspose.com/c/svg/28).

## Licensing

Aspose.SVG for .NET is a commercial library. You can start with a free evaluation and later apply a license for production use. Licensing details and instructions are available in the [Licensing documentation](https://docs.aspose.com/svg/net/getting-started/licensing/).

[Home](https://metrics.aspose.com/) | [Product Page](https://products.aspose.com/svg/net/) | [Docs](https://docs.aspose.com/svg/net/) | [API Reference](https://reference.aspose.com/svg/net/) | [NuGet](https://www.nuget.org/packages/Aspose.SVG/) | [Blog](https://blog.aspose.com/categories/aspose.svg-product-family/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/svg/28) | [Temporary License](https://purchase.aspose.com/temporary-license/)
