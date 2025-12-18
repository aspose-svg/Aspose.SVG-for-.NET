# Convert SVG to SVGZ in .NET

## Convert SVG to Compressed SVGZ Format

SVGZ is a GZIP‑compressed version of SVG that significantly reduces file size while preserving full vector quality. [**Aspose.SVG for .NET**](https://products.aspose.com/svg/net/) provides native support for saving SVG documents in SVGZ format without manual compression.

### Why Use SVGZ

* Reduce file size for web delivery
* Improve loading performance
* Preserve full SVG compatibility
* Optimize storage and bandwidth usage

### SVG to SVGZ Conversion Example

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

## See Also

- [**Official Documentation**](https://docs.aspose.com/svg/net/convert-svg/)
Detailed guides and advanced scenarios for working with SVG documents in .NET.
- [**API Reference**](https://reference.aspose.com/svg/net/aspose.svg.converters/)
Explore the full API interface, classes, methods, and configuration options in the official reference.
- [**Online SVG Converter**](https://products.aspose.app/svg/conversion)
Try SVG conversion online without writing code using the Aspose web application.
- [**GitHub Repository Examples**](https://github.com/aspose-svg/Aspose.SVG-for-.NET/tree/master/Examples)
This repository contains ready-to-use code examples and sample data files that demonstrate SVG conversion, rendering, and manipulation with Aspose.SVG for .NET. Use these examples as a starting point or reference when integrating SVG processing into your own applications.