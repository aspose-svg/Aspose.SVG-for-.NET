# Save SVG Files in C#

[**Aspose.SVG for .NET**](https://products.aspose.com/svg/net/) can save created or modified SVG documents to regular SVG files, URI-based destinations, compressed SVGZ files, and custom resource handlers.

Use this guide when you need to persist SVG changes, save generated SVG markup, create compressed SVGZ output, or save an edited SVG document from a .NET application.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Save SVG File](https://docs.aspose.com/svg/net/save-svg-file/)
- [Supported File Formats](../getting-started/supported-file-formats.md)
- [SVGDocument API Reference](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/)
- [Examples: WorkingWithSVGDocument](../../Examples/CSharp/WorkingWithSVGDocument/README.md)

## Save an SVG Document to a File

After creating, loading, or editing an SVG document, call `Save()` with an output file path.

```csharp
using Aspose.Svg;

using (var document = new SVGDocument("input.svg"))
{
    document.Save("output.svg");
}
```

## Save After DOM Editing

Most save workflows start with a DOM update. For example, select a rectangle, change its fill color, and save the edited SVG.

```csharp
using Aspose.Svg;

using (var document = new SVGDocument("input.svg"))
{
    var rect = document.RootElement.QuerySelector("rect");

    if (rect != null)
    {
        rect.SetAttribute("fill", "teal");
    }

    document.Save("edited.svg");
}
```

## Save Compressed SVGZ

SVGZ is a GZIP-compressed SVG format. Use `SVGSaveFormat.SVGZ` when you need a smaller file for storage or delivery.

```csharp
using Aspose.Svg;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svg"))
{
    document.Save("output.svgz", SVGSaveFormat.SVGZ);
}
```

## Save SVGZ Back to SVG

Aspose.SVG can load compressed SVGZ files. To save the document as regular SVG, use `SVGSaveFormat.SVG`.

```csharp
using Aspose.Svg;
using Aspose.Svg.Saving;

using (var document = new SVGDocument("input.svgz"))
{
    document.Save("expanded-output.svg", SVGSaveFormat.SVG);
}
```

For advanced workflows that save the main SVG file and external resources to memory, databases, cloud storage, or archives, use a custom `ResourceHandler`. See `SaveSVGToMemoryStreams()` in [`SaveSVGDocumentExamples.cs`](../../Examples/CSharp/WorkingWithSVGDocument/SaveSVGDocumentExamples.cs).

## Common Questions

### Can Aspose.SVG save SVG files after editing?

Yes. Load an `SVGDocument`, update the DOM, and call `Save("output.svg")`.

### Can Aspose.SVG save SVGZ files?

Yes. Use `document.Save("output.svgz", SVGSaveFormat.SVGZ)`.

### Can Aspose.SVG convert SVGZ back to SVG?

Yes. Load the `.svgz` file with `SVGDocument` and save it with `SVGSaveFormat.SVG`.

### Can I save SVG directly to a Stream?

`SVGDocument.Save()` does not provide a direct `Stream` overload. Use `DocumentElement.OuterHTML` when you need SVG markup as a string, or use a custom `ResourceHandler` for advanced in-memory output and resource handling.
