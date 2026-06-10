# Edit SVG Files in C#

**Aspose.SVG for .NET** provides a standards-based SVG DOM API for editing SVG files programmatically. You can load an SVG document, select elements, change attributes and styles, add new nodes, and save the result.

Use this guide when you need to modify SVG color, size, text, shapes, paths, CSS, attributes, or document structure in a .NET application.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Edit SVG File](https://docs.aspose.com/svg/net/edit-svg-file/)
- [Modify SVG Styles Programmatically](https://docs.aspose.com/svg/net/modify-svg-styles-programmatically/)
- [How to Change SVG Color](https://docs.aspose.com/svg/net/how-to-change-svg-color/)
- [SVGDocument API Reference](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/)
- [Examples: WorkingWithSVGDocument](../../Examples/CSharp/WorkingWithSVGDocument/README.md)
- [Examples: WorkingWithSvgColors](../../Examples/CSharp/WorkingWithSvgColors/README.md)

## Load an SVG File

Start by loading the SVG document from a file path.

```csharp
using Aspose.Svg;

using (var document = new SVGDocument("input.svg"))
{
    // The SVG DOM is ready for editing.
}
```

## Change SVG Attributes

Use `SetAttribute()` to change root attributes, shape geometry, colors, transformations, and CSS-like presentation attributes.

```csharp
using Aspose.Svg;

using (var document = new SVGDocument("input.svg"))
{
    document.RootElement.SetAttribute("width", "400");
    document.RootElement.SetAttribute("height", "300");
    document.RootElement.SetAttribute("viewBox", "0 0 400 300");

    document.Save("resized.svg");
}
```

## Select and Recolor an SVG Element

CSS selectors are convenient for targeted SVG edits.

```csharp
using Aspose.Svg;

using (var document = new SVGDocument("input.svg"))
{
    var circle = document.RootElement.QuerySelector("circle");

    if (circle != null)
    {
        circle.SetAttribute("fill", "green");
        circle.SetAttribute("stroke", "#004d40");
    }

    document.Save("recolored.svg");
}
```

## Add a New SVG Element

Create SVG nodes with `CreateElementNS()` and append or insert them into the document.

```csharp
using Aspose.Svg;

const string SvgNamespace = "http://www.w3.org/2000/svg";

using (var document = new SVGDocument("input.svg"))
{
    var rect = document.CreateElementNS(SvgNamespace, "rect");
    rect.SetAttribute("x", "20");
    rect.SetAttribute("y", "20");
    rect.SetAttribute("width", "120");
    rect.SetAttribute("height", "80");
    rect.SetAttribute("fill", "orange");

    document.RootElement.AppendChild(rect);
    document.Save("with-rectangle.svg");
}
```

## Batch Edit Elements

Use `QuerySelectorAll()` to update multiple matching nodes.

```csharp
using Aspose.Svg;

using (var document = new SVGDocument("input.svg"))
{
    var paths = document.QuerySelectorAll("path");

    foreach (var path in paths)
    {
        path.SetAttribute("stroke", "white");
    }

    document.Save("paths-updated.svg");
}
```

## Common Questions

### Can Aspose.SVG edit existing SVG files?

Yes. Load an `SVGDocument`, modify DOM nodes or attributes, and call `Save()`.

### Can I use CSS selectors in C#?

Yes. Use `QuerySelector()` and `QuerySelectorAll()` to select SVG elements with CSS selector syntax.

### Can I change SVG colors programmatically?

Yes. Change `fill`, `stroke`, inline `style`, or CSS rules depending on how the SVG is styled.
