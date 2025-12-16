# Save SVG Documents in .NET

Saving SVG documents is a fundamental feature of [**Aspose.SVG for .NET**](https://products.aspose.com/svg/net/), allowing developers to persist created or modified SVG files to disk or streams. The library ensures full compliance with the SVG specification while providing flexible options for saving and compression.

## Save an SVG Document to a File

After creating or editing an SVG document, you can save it to a file in standard SVG format.

```csharp
using Aspose.Svg;

using (var document = new SVGDocument("input.svg"))
{
    // Perform edits or build SVG
    document.Save("output.svg");
}
```

This method writes the SVG content to the specified file path while maintaining the document structure and elements.

## Save Compressed SVG (SVGZ)

Aspose.SVG supports saving SVG files in compressed **SVGZ** format, reducing file size for storage or web delivery.

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

This approach provides GZIP compression while keeping full vector fidelity and SVG compatibility.


## Notes on Saving

* The saved files are fully compliant with the SVG specification.
* You can combine saving with editing or creation APIs to build complete workflows.
* SVGZ files can be loaded and processed the same way as regular SVG files.

## See Also

- [**Official Documentation**](https://docs.aspose.com/svg/net/save-svg-document/)
Detailed guides and advanced scenarios for working with SVG documents in .NET.
- [**API Reference**](https://reference.aspose.com/svg/net/)
Explore the full API interface, classes, methods, and configuration options in the official reference.
- [**Online SVG Converter**](https://products.aspose.app/svg/applications)
Try SVG conversion online without writing code using the Aspose web application.
- [**GitHub Repository Examples**](https://github.com/aspose-svg/Aspose.SVG-for-.NET/tree/master/Examples)
This repository contains ready-to-use code examples and sample data files that demonstrate SVG conversion, rendering, and manipulation with Aspose.SVG for .NET. Use these examples as a starting point or reference when integrating SVG processing into your own applications.
