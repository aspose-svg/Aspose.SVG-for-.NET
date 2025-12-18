# Traverse and Inspect SVG DOM in .NET

Aspose.SVG for .NET allows developers to navigate and inspect the **SVG Document Object Model (DOM)** programmatically. This is essential for querying, modifying, or analyzing SVG elements in .NET applications.

##  View SVG Content

The easiest way to inspect the document content is to look at content as a string. The properties `InnerHTML` and `OuterHTML` of the Element class return a fragment of XML (or HTML) that represents the element and its contents. They are developed precisely for viewing SVG content as a string. The following code example shows how to view the content of document.svg file in the console.

```c#
using Aspose.Svg;
using System.IO;

// Get SVG document OuterHTML in C#

// Load an SVG document
using (SVGDocument document = new SVGDocument(Path.Combine(DataDir, "document.svg")))
{
    // Use the OuterHTML property
    string html = document.DocumentElement.OuterHTML;

    Console.WriteLine(html);
}
// View the document content
```

## Extract Information about Specific SVG Element

The following example shows how to extract information about a particular SVG element from a file shapes.svg:

```c#
using Aspose.Svg;
using System.IO;
using System.Linq;

// Extract information about specific SVG element

string documentPath = Path.Combine(DataDir, "shapes.svg");

// Load a document from a file
using (SVGDocument document = new SVGDocument(documentPath))
{
    // Get the root <svg> element of the document
    Element svg = document.DocumentElement;

    // Find the first child element with a given tag name
    SVGGElement g = svg.GetElementsByTagName("g").First() as SVGGElement;
    SVGRectElement rect = g.FirstElementChild as SVGRectElement;

    Console.WriteLine("Height: {0}", rect.Height);// 100
    Console.WriteLine("Width: {0}", rect.Width); // 100
}
```

## Navigate SVG with XPath Query

XPath Query ( XML Path Language), often referred to simply as an XPath, is a query language used to query data from documents. It is based on a DOM representation of the SVG document and selects nodes by various criteria. The syntax of the XPath expressions is quite simple, and what is more important, it is easy to read and support.

Aspose.SVG also has powerful XPath Specifications implementation along with Traversal Specifications. This empowers you to use XPath Query to navigate over the document as shown in the following code sample:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
using Aspose.Svg.Collections;

using (var document = new SVGDocument(Path.Combine(DataDir, "shapes.svg")))
{
    // Evaluate XPath expression
    var xpathResult = document.Evaluate("//rect[@x='120']", document, null, (Dom.XPath.XPathResultType)XPathResultType.Any, null);

    // Get the next evaluated node
    Console.WriteLine((xpathResult.IterateNext() as Element)?.OuterHTML);
}
```

## See Also

- [**Official Documentation**](https://docs.aspose.com/svg/net/navigation-inspection/)
Detailed guides and advanced scenarios for working with SVG documents in .NET.
- [**API Reference**](https://reference.aspose.com/svg/net/)
Explore the full API interface, classes, methods, and configuration options in the official reference.
- [**Online SVG Converter**](https://products.aspose.app/svg/applications)
Try SVG conversion online without writing code using the Aspose web application.
- [**GitHub Repository Examples**](https://github.com/aspose-svg/Aspose.SVG-for-.NET/tree/master/Examples)
This repository contains ready-to-use code examples and sample data files that demonstrate SVG conversion, rendering, and manipulation with Aspose.SVG for .NET. Use these examples as a starting point or reference when integrating SVG processing into your own applications.