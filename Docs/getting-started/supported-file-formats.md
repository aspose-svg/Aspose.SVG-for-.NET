# Supported File Formats - Aspose.SVG for .NET

Aspose.SVG for .NET loads SVG documents and saves or converts them to common document and image formats such as SVG, SVGZ, PDF, XPS, PNG, JPEG, BMP, TIFF, and GIF.

Use this page when you need to check SVG input support, SVG output support, or conversion targets for C# applications.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Convert SVG Files](https://docs.aspose.com/svg/net/convert-svg/)
- [Convert SVG to PDF](https://docs.aspose.com/svg/net/convert-svg-to-pdf/)
- [Convert SVG to Image](https://docs.aspose.com/svg/net/convert-svg-to-image/)
- [Save SVG File](https://docs.aspose.com/svg/net/save-svg-file/)
- [Examples: ConvertRenderMergeSvg](../../Examples/CSharp/ConvertRenderMergeSvg/README.md)

## SVG Document Formats

| Format | Description | Load | Save |
| --- | --- | --- | --- |
| SVG | Scalable Vector Graphics | Yes | Yes |
| SVGZ | GZIP-compressed SVG | Yes | Yes |

## Conversion Output Formats

| Format | Description | Save or Convert |
| --- | --- | --- |
| PDF | Portable Document Format | Yes |
| XPS | XML Paper Specification | Yes |
| PNG | Portable Network Graphics | Yes |
| JPEG | Joint Photographic Experts Group image | Yes |
| BMP | Bitmap image | Yes |
| TIFF | Tagged Image File Format | Yes |
| GIF | Graphics Interchange Format | Yes |

## Raster Images as Input

Aspose.SVG for .NET also includes image vectorization workflows. In these scenarios, raster images such as PNG, JPEG, BMP, GIF, TIFF, and ICO can be used as input and converted into SVG vector output.

Useful links:

- [Image Vectorization](https://docs.aspose.com/svg/net/vectorization/)
- [Examples: ImageAndTextVectorization](../../Examples/CSharp/ImageAndTextVectorization/README.md)

## Common Conversion Scenarios

### Convert SVG to PDF

Use SVG to PDF conversion when you need printable, portable, paginated output.

```csharp
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;

Converter.ConvertSVG("input.svg", new PdfSaveOptions(), "output.pdf");
```

### Convert SVG to PNG

Use SVG to PNG conversion for web previews, thumbnails, reports, and raster image pipelines.

```csharp
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;

Converter.ConvertSVG("input.svg", new ImageSaveOptions(), "output.png");
```

### Save SVG as SVGZ

Use SVGZ when you need compressed SVG output for storage or delivery.

```csharp
using Aspose.Svg;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svg"))
{
    document.Save("output.svgz", SVGSaveFormat.SVGZ);
}
```

## Common Questions

### Can Aspose.SVG for .NET load PDF?

No. PDF is an output format for SVG conversion, not an SVG document input format.

### Can Aspose.SVG for .NET save SVGZ?

Yes. SVGZ is supported as a compressed SVG save format.

### Can Aspose.SVG for .NET convert SVG to images?

Yes. Supported raster output formats include PNG, JPEG, BMP, TIFF, and GIF.

### Can Aspose.SVG for .NET convert images to SVG?

Yes, through image vectorization workflows. This is different from loading an image as an `SVGDocument`.
