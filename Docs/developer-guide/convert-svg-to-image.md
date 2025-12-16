# Convert SVG to Raster Images in .NET

[**Aspose.SVG for .NET**](https://products.aspose.com/svg/net/) allows you to convert SVG documents into popular raster image formats such as PNG, JPG, BMP, TIFF, and GIF while preserving visual accuracy and layout consistency. The rendering process is fully configurable, enabling you to control essential parameters including background color, resolution (DPI), output size, and page settings through the ImageRenderingOptions API. This flexibility makes SVG-to-image conversion suitable for web delivery, previews, reporting, and environments where vector graphics are not supported.

## Convert SVG to PNG, JPG, BMP, TIFF, and GIF

Aspose.SVG for .NET provides multiple ways to convert SVG documents into raster image formats, allowing developers to choose the most appropriate API depending on the required level of control and rendering customization.

### SVG to PNG Examples

The **first approach** uses the high-level Converter API and is suitable for quick and straightforward SVG-to-image conversion with minimal configuration.

```csharp
using Aspose.Svg;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;

// Initialize an SVG document from a file
using (SVGDocument document = new SVGDocument("svg-to-png.svg"))
{
    // Create an instance of the ImageSaveOptions class
    ImageSaveOptions pngSaveOptions = new ImageSaveOptions();

    // Convert SVG to PNG
    Converter.ConvertSVG(document, pngSaveOptions, "svg-to-png.png");
}
```

The **second approach** relies on the rendering pipeline (ImageRenderingOptions and ImageDevice) and is recommended when you need precise control over rendering parameters such as resolution, background, and output size.

```csharp
using Aspose.Svg;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;

using (var document = new SVGDocument("input.svg"))
{
    var options = new ImageRenderingOptions(ImageFormat.Png);

    using (var device = new ImageDevice(options, "output.png"))
    {
        document.RenderTo(device);
    }
}
```

### Rendering Options

The `ImageRenderingOptions` class provides fine-grained control over how an SVG document is rendered into a raster image. It allows you to configure both visual output and technical parameters to ensure predictable and high-quality results across different target formats.

Using `ImageRenderingOptions`, you can:

* **Control output resolution** by specifying horizontal and vertical DPI, which directly affects image clarity and physical size.
* **Define the background color** for the rendered image, which is especially important when exporting SVG files with transparent backgrounds.
* **Adjust rendering size and scaling** through page and viewport settings to match exact layout or preview requirements.
* **Configure format-specific options** for image rendering, such as compression behavior and pixel format, depending on the target image type.
* **Apply consistent rendering behavior** across PNG, JPG, BMP, TIFF, and GIF outputs using a unified API.

These options make `ImageRenderingOptions` essential for scenarios where SVG content must be rendered with precise visual fidelity, controlled resolution, and predictable output characteristics in .NET applications.

To convert to other formats, simply change the `ImageFormat` value (for example, `ImageFormat.Jpeg` or `ImageFormat.Tiff`). This approach ensures consistent visual results across all supported raster formats.

## See Also

- [**Official Documentation**](https://docs.aspose.com/svg/net/convert-svg/)
Detailed guides and advanced scenarios for working with SVG documents in .NET.
- [**API Reference**](https://reference.aspose.com/svg/net/aspose.svg.converters/)
Explore the full API interface, classes, methods, and configuration options in the official reference.
- [**Online SVG Converter**](https://products.aspose.app/svg/conversion)
Try SVG conversion online without writing code using the Aspose web application.
- [**GitHub Repository Examples**](https://github.com/aspose-svg/Aspose.SVG-for-.NET/tree/master/Examples)
This repository contains ready-to-use code examples and sample data files that demonstrate SVG conversion, rendering, and manipulation with Aspose.SVG for .NET. Use these examples as a starting point or reference when integrating SVG processing into your own applications.

# Article 3 — Convert SVG to SVGZ in .NET

## Convert SVG to Compressed SVGZ Format

SVGZ is a GZIP‑compressed version of SVG that significantly reduces file size while preserving full vector quality. **Aspose.SVG for .NET** provides native support for saving SVG documents in SVGZ format without manual compression.

### Why Use SVGZ

* Reduce file size for web delivery
* Improve loading performance
* Preserve full SVG compatibility
* Optimize storage and bandwidth usage

### Correct SVG to SVGZ Conversion Example

```csharp
using Aspose.Svg;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svg"))
{
    var options = new SVGSaveOptions
    {
        SaveFormat = SVGSaveFormat.SVGZ
    };

    document.Save("output.svgz", options);
}
```

### Notes

* No additional compression libraries are required.
* SVGZ files can be loaded and processed the same way as regular SVG files.
* The output fully complies with the SVG specification.

This makes SVGZ an excellent choice for delivering complex vector graphics efficiently in .NET applications.

