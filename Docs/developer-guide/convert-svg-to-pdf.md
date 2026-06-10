# Convert SVG to PDF in C#

**Aspose.SVG for .NET** converts SVG documents to PDF for reports, diagrams, print workflows, archiving, and document exchange. The conversion engine renders SVG content to PDF and provides save options for page setup, background color, resolution, and image quality.

Use this guide when you need to convert SVG files to PDF programmatically in a .NET application.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Convert SVG to PDF](https://docs.aspose.com/svg/net/convert-svg-to-pdf/)
- [Convert SVG Files](https://docs.aspose.com/svg/net/convert-svg/)
- [PdfSaveOptions API Reference](https://reference.aspose.com/svg/net/aspose.svg.saving/pdfsaveoptions/)
- [Examples: ConvertRenderMergeSvg](../../Examples/CSharp/ConvertRenderMergeSvg/README.md)

## Convert SVG to PDF

Use `Converter.ConvertSVG()` with `PdfSaveOptions` for a straightforward conversion.

```csharp
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;

Converter.ConvertSVG("input.svg", new PdfSaveOptions(), "output.pdf");
```

## Convert SVGDocument to PDF

Load an `SVGDocument` when you need to inspect or modify the SVG before conversion.

```csharp
using Aspose.Svg;
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svg"))
{
    var options = new PdfSaveOptions();
    Converter.ConvertSVG(document, options, "output.pdf");
}
```

## Customize PDF Output

Use `PdfSaveOptions` to configure PDF conversion settings such as page setup, background color, and rendering behavior.

```csharp
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;
using System.Drawing;

var options = new PdfSaveOptions
{
    BackgroundColor = Color.White
};

Converter.ConvertSVG("input.svg", options, "output.pdf");
```

## When to Use SVG to PDF Conversion

- Generate printable documents from SVG diagrams.
- Create PDF output from SVG-based technical graphics.
- Package SVG-based reports into a widely supported document format.
- Convert multiple SVG assets into PDF output for document workflows.

## Common Questions

### Can Aspose.SVG convert SVG to PDF?

Yes. Use `Converter.ConvertSVG()` with `PdfSaveOptions` to convert an SVG file or an `SVGDocument` instance to PDF.

### Can I convert SVG to PDF after editing it?

Yes. Load the SVG as `SVGDocument`, update the DOM, and pass the document to `Converter.ConvertSVG()`.

### Which PDF conversion options can I configure?

Use `PdfSaveOptions` to configure output behavior such as page setup, background color, resolution, CSS handling, document information, encryption, and JPEG image quality.