# Traverse and Inspect SVG DOM in C#

**Aspose.SVG for .NET** exposes the SVG Document Object Model (DOM), so you can inspect SVG markup, traverse elements, query nodes, and extract information before editing, conversion, or validation.

Use this guide when you need to read SVG structure, inspect element attributes, use CSS selectors, or query SVG documents with XPath in a .NET application.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Navigation and Inspection](https://docs.aspose.com/svg/net/navigation-inspection/)
- [SVGDocument API Reference](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/)
- [Examples: WorkingWithSVGDocument](../../Examples/CSharp/WorkingWithSVGDocument/README.md)

## View SVG Markup as a String

Use `OuterHTML` to inspect the serialized markup of an element.

```csharp
using Aspose.Svg;
using System;

using (var document = new SVGDocument("input.svg"))
{
    string markup = document.DocumentElement.OuterHTML;
    Console.WriteLine(markup);
}
```

## Inspect a Specific SVG Element

Use DOM methods to find elements and read typed SVG properties or attributes.

```csharp
using Aspose.Svg;
using System;
using System.Linq;

using (var document = new SVGDocument("shapes.svg"))
{
    var rect = document.GetElementsByTagName("rect").First() as SVGRectElement;

    if (rect != null)
    {
        Console.WriteLine($"Width: {rect.Width.BaseVal.Value}");
        Console.WriteLine($"Height: {rect.Height.BaseVal.Value}");
        Console.WriteLine($"Style: {rect.GetAttribute("style")}");
    }
}
```

## Query SVG with CSS Selectors

CSS selectors are useful when you need a concise way to find elements by tag, class, id, or attribute.

```csharp
using Aspose.Svg;
using System;

using (var document = new SVGDocument("input.svg"))
{
    var highlightedShapes = document.QuerySelectorAll(".highlight");

    foreach (var element in highlightedShapes)
    {
        Console.WriteLine(element.OuterHTML);
    }
}
```

## Query SVG with XPath

Use XPath when you need structured queries over the SVG DOM.

```csharp
using Aspose.Svg;
using Aspose.Svg.Collections;
using Aspose.Svg.Dom;
using System;

using (var document = new SVGDocument("shapes.svg"))
{
    var result = document.Evaluate(
        "//rect[@x='120']",
        document,
        null,
        (Dom.XPath.XPathResultType)XPathResultType.Any,
        null);

    var node = result.IterateNext() as Element;
    Console.WriteLine(node?.OuterHTML);
}
```

## When to Traverse SVG DOM

- Inspect SVG files before conversion.
- Find and update selected shapes.
- Extract dimensions, colors, text, paths, or style attributes.
- Validate generated SVG output.
- Build tools that analyze or normalize SVG documents.

## Common Questions

### Can I inspect SVG content without saving it?

Yes. Load the document and read DOM properties such as `OuterHTML`, attributes, and typed SVG element values.

### Can I use CSS selectors with SVG?

Yes. Use `QuerySelector()` and `QuerySelectorAll()` on `SVGDocument` or SVG elements.

### Can I use XPath with SVG documents?

Yes. Aspose.SVG supports XPath evaluation over the SVG DOM.
