# Create SVG Documents in .NET

Creating SVG documents programmatically is a foundational feature of [**Aspose.SVG for .NET**](https://products.aspose.com/svg/net/), allowing developers to generate scalable vector graphics dynamically for web, print, and desktop applications. You can build new SVG documents from scratch or construct them using memory strings, streams, or the Builder API.

## Create an Empty SVG Document

You can initialize a blank SVG document and start adding elements using the DOM or Builder API.

```csharp
using Aspose.Svg;

// Create a new empty SVG document
using (var document = new SVGDocument())
{
    document.Save("empty.svg");
}
```

This approach provides a clean canvas for generating SVG graphics programmatically.

## Create an SVG from a Memory String

You can also create an SVG document from an SVG string in memory, which is useful for dynamic content or content received from APIs.

```csharp
using Aspose.Svg;

string svgContent = "<svg width='100' height='100'></svg>";
using (var document = new SVGDocument(svgContent, "."))
{
    document.Save("from-string.svg");
}
```

This method enables immediate parsing and manipulation of SVG content without intermediate files.

## Create Custom SVG Using Builder API

Aspose.SVG provides a fluent [**Builder API**](https://docs.aspose.com/svg/net/svg-builder/) for constructing SVG elements programmatically. This allows precise control over shapes, paths, and attributes.

```csharp
using Aspose.Svg;
using Aspose.Svg.Builders;

// Create an <svg> element with specified width, height and viewBox, and add into it other required elements
SVGSVGElement svg = new SVGSVGElementBuilder()
    .Width(700).Height(300)
    .ViewBox(0, 0, 700, 300)

    .AddG(g => g
    .AddCircle(circle => circle.Cx(130).Cy(130).R(60).Fill(Paint.None).Stroke(Color.FromArgb(200, 0, 0)).StrokeWidth(70).StrokeDashArray(2, 14))
    .AddText("I can create SVG from scratch!", x: 270, y: 140, fontSize: 30, fill: Color.Teal)
    )
    .Build(document.FirstChild as SVGSVGElement);

// Save the document
document.Save(Path.Combine(OutputDir, "svg-from-scratch.svg"));
```

This approach is ideal for generating complex graphics dynamically with precise control.

## Save the SVG Document

After creating or modifying an SVG document, you can save it to a file or stream. The resulting file is fully compliant with the SVG specification.

```csharp
document.Save("output.svg");
```

## See Also

* [**Official Documentation**](https://docs.aspose.com/svg/net/create-svg-document/)
* [**API Reference**](https://reference.aspose.com/svg/net/)
* [**Online SVG Tools**](https://products.aspose.app/svg/applications)
* [**GitHub Examples and Sample Data**](https://github.com/aspose-svg/Aspose.SVG-for-.NET/tree/master/Examples). This repository contains ready‑to‑use code examples and sample SVG files demonstrating common editing, conversion, and rendering scenarios with Aspose.SVG for .NET.