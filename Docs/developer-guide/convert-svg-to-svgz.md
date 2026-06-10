# Convert SVG to SVGZ in C#

SVGZ is a GZIP-compressed SVG format. **Aspose.SVG for .NET** can save SVG as SVGZ directly, without requiring manual compression code.

Use SVGZ when you want smaller SVG files for storage, delivery, or web publishing while keeping the content as vector graphics.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Save SVG File](https://docs.aspose.com/svg/net/save-svg-file/)
- [Supported File Formats](../getting-started/supported-file-formats.md)
- [Examples: ConvertRenderMergeSvg](../../Examples/CSharp/ConvertRenderMergeSvg/README.md)
- [Examples: WorkingWithSVGDocument](../../Examples/CSharp/WorkingWithSVGDocument/README.md)

## Convert SVG to SVGZ

Load the SVG file and save it with `SVGSaveFormat.SVGZ`.

```csharp
using Aspose.Svg;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svg"))
{
    document.Save("output.svgz", SVGSaveFormat.SVGZ);
}
```

## Why Use SVGZ?

- Smaller file size than plain SVG.
- Same vector quality as SVG.
- Useful for web delivery and storage.
- Can be loaded and processed like regular SVG by tools that support SVGZ.

## Load SVGZ

An SVGZ file can be loaded through `SVGDocument` when you need to inspect, edit, or convert it.

```csharp
using Aspose.Svg;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svgz"))
{
    document.Save("expanded-output.svg", SVGSaveFormat.SVG);
}
```

## Convert SVGZ to PDF or PNG

After loading SVGZ with `SVGDocument`, use the same conversion APIs that are used for regular SVG documents.

```csharp
using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svgz"))
{
    Converter.ConvertSVG(document, new PdfSaveOptions(), "output.pdf");
    Converter.ConvertSVG(document, new ImageSaveOptions(), "output.png");
}
```

## Common Questions

### Is SVGZ different from SVG?

SVGZ contains SVG markup compressed with GZIP. It preserves the vector content but stores it in a compressed file.

### Do I need a separate compression library?

No. Aspose.SVG can save SVGZ directly.

### Can I convert SVGZ to PDF or PNG?

Yes. Load SVGZ with `SVGDocument` and use `Converter.ConvertSVG()` with `PdfSaveOptions` or `ImageSaveOptions`.
