# Convert SVG to Raster Images in C#

[**Aspose.SVG for .NET**](https://products.aspose.com/svg/net/) converts SVG documents to raster image formats such as PNG, JPEG, BMP, TIFF, and GIF. SVG to image conversion is useful for previews, thumbnails, web delivery, reports, and systems that require bitmap output.

Use this guide when you need to render SVG as PNG, JPEG, TIFF, BMP, or GIF in a .NET application.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Convert SVG to Image](https://docs.aspose.com/svg/net/convert-svg-to-image/)
- [Convert SVG Files](https://docs.aspose.com/svg/net/convert-svg/)
- [ImageSaveOptions API Reference](https://reference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions/)
- [Examples: ConvertRenderMergeSvg](../../Examples/CSharp/ConvertRenderMergeSvg/README.md)

## Convert SVG to PNG

Use `ImageSaveOptions` with `Converter.ConvertSVG()` for simple SVG to PNG conversion. PNG is the default output image format when `ImageSaveOptions` is created without an explicit `ImageFormat`.

```csharp
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;

Converter.ConvertSVG("input.svg", new ImageSaveOptions(), "output.png");
```

## Convert SVGDocument to PNG

Load an `SVGDocument` when you need to edit or inspect SVG before rendering.

```csharp
using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svg"))
{
    Converter.ConvertSVG(document, new ImageSaveOptions(), "output.png");
}
```

## Convert SVG to JPEG, BMP, TIFF, or GIF

Set the target image format in `ImageSaveOptions`.

```csharp
using Aspose.Svg.Converters;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Saving;

var options = new ImageSaveOptions(ImageFormat.Jpeg);
Converter.ConvertSVG("input.svg", options, "output.jpeg");
```

Use `ImageFormat.Png`, `ImageFormat.Jpeg`, `ImageFormat.Bmp`, `ImageFormat.Tiff`, or `ImageFormat.Gif` depending on the output you need.

## Customize Raster Output

Configure `ImageSaveOptions` when you need predictable output size, background color, page setup, or rendering quality.

```csharp
using Aspose.Svg.Converters;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Saving;
using System.Drawing;

var options = new ImageSaveOptions(ImageFormat.Png)
{
    BackgroundColor = Color.White
};

Converter.ConvertSVG("input.svg", options, "output.png");
```

## When to Use SVG to Image Conversion

- Create PNG previews from SVG files.
- Generate JPEG thumbnails for content management systems.
- Render SVG diagrams into bitmap reports.
- Produce TIFF or BMP output for legacy image workflows.
- Convert SVG graphics for environments that do not support vector rendering.

## Common Questions

### Can Aspose.SVG convert SVG to PNG?

Yes. Use `Converter.ConvertSVG()` with `ImageSaveOptions`. PNG is the default format, so `new ImageSaveOptions()` is enough for basic SVG to PNG conversion.

### Can Aspose.SVG convert SVG to JPEG?

Yes. Set `ImageFormat.Jpeg` in `ImageSaveOptions`.

### Can I set a background color for transparent SVG?

Yes. Use the `BackgroundColor` property in image save options with a `System.Drawing.Color` value.
