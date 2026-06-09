# Working with SVG Documents in C#

This folder contains practical examples that show how to create, load, inspect, edit, navigate, and save SVG documents with **Aspose.SVG for .NET 26.5.0**.

The examples are designed as companion code for product documentation. They use real SVG files from the shared `Examples/Data/` folder and write generated files to `Examples/output/svg/`.

## What You Can Learn

- Create an empty SVG document in C#.
- Create SVG from a string, stream, file, URL, and Builder API.
- Load SVG with a custom `Configuration`.
- Limit JavaScript execution time with `IRuntimeService`.
- View SVG markup as a string.
- Inspect SVG DOM elements and read geometry values.
- Traverse SVG nodes with DOM navigation APIs.
- Find and edit SVG elements with CSS selectors.
- Select SVG nodes with XPath expressions.
- Iterate nodes with a custom `NodeFilter`.
- Create and edit SVG shapes, text, images, and path data.
- Save SVG to files, `Url` destinations, SVGZ, memory streams, ZIP archives, and folders with external resources.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET `26.5.0`.
- Input files from `Examples/Data/`.

The package version is configured in `Examples/CSharp/CSharp.csproj`.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSVGDocument
```

In Visual Studio, select the `WorkingWithSVGDocument` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
WorkingWithSVGDocumentExamples.RunAll();
```

You can also open `WorkingWithSVGDocumentExamples.cs` and comment out individual calls if you want to run only one group of examples.

## How to Run Selected Examples

The file `WorkingWithSVGDocumentExamples.cs` is the central runner for this section. Its `RunAll()` method calls each example group:

```csharp
CreateAndLoadSVGDocument.Run();
ViewDocumentContentAsString.Run();
InspectDocumentContent.Run();
TraverseSVGElement.Run();
CSSSelector.Run();
XPathQuery.Run();
NodeIterator.Run();
EditSVGFile.Run();
EditSVGPathData.Run();
CreateSVGWithViewBox.Run();
SaveSVGDocumentExamples.Run();
```

To run examples only from one file, leave only the corresponding call uncommented. For example, to run only `EditSVGFile.cs`, edit `WorkingWithSVGDocumentExamples.RunAll()` like this:

```csharp
public static void RunAll()
{
    Console.WriteLine("Running WorkingWithSVGDocument examples...");

    // CreateAndLoadSVGDocument.Run();
    // ViewDocumentContentAsString.Run();
    // InspectDocumentContent.Run();
    // TraverseSVGElement.Run();
    // CSSSelector.Run();
    // XPathQuery.Run();
    // NodeIterator.Run();
    EditSVGFile.Run();
    // EditSVGPathData.Run();
    // CreateSVGWithViewBox.Run();
    // SaveSVGDocumentExamples.Run();

    Console.WriteLine("WorkingWithSVGDocument examples finished.");
}
```

To run only one method from `EditSVGFile.cs`, open `EditSVGFile.Run()` and comment out the methods you do not need:

```csharp
public static void Run()
{
    // CreateSVGFromScratch();
    AddCircleToSVGFile();
    // AddPolylineAndUpdateShapes();
    // DrawSVGOnExistingBitmap();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSVGDocument
```

The same pattern works for other files: keep the group call in `WorkingWithSVGDocumentExamples.RunAll()`, then choose individual methods inside that file's `Run()` method.

## Input and Output

Input files are stored centrally:

```text
Examples/Data/
```

Generated files are written to:

```text
Examples/output/svg/
```

This keeps source assets reusable across documentation sections and keeps generated output separate from input files.

## Example Groups

### Create and Load SVG Documents

File: `CreateAndLoadSVGDocument.cs`

This group demonstrates the main ways to create and load SVG documents with Aspose.SVG for .NET:

- `CreateEmptySVGDocument()` creates a blank SVG document and saves it.
- `CreateSVGDocumentFromString()` creates SVG from in-memory markup.
- `CreateSVGDocumentFromStringWithBaseUri()` resolves linked resources such as `flower.png`.
- `LoadSVGDocumentFromFile()` loads SVG from a local file.
- `LoadSVGDocumentFromStream()` loads SVG from a `FileStream`.
- `LoadSVGDocumentFromUrl()` loads SVG through an Aspose `Url`.
- `LoadSVGDocumentAsync()` uses `Navigate()` and waits for the document to be ready.
- `CreateSVGUsingBuilderApi()` creates SVG with the fluent Builder API.
- `LoadSVGDocumentWithConfiguration()` applies custom user-agent styles before loading.
- `LimitJavaScriptRuntime()` limits script execution time before conversion.

### View and Inspect SVG Content

Files:

- `ViewDocumentContentAsString.cs`
- `InspectDocumentContent.cs`

These examples show how to read SVG markup and inspect DOM properties:

- print the root element `OuterHTML`;
- print selected element markup;
- inspect the root `<svg>` element;
- read circle geometry values;
- extract rectangle width, height, and style data.

### Traverse SVG DOM Elements

File: `TraverseSVGElement.cs`

This group demonstrates basic SVG DOM navigation:

- start from the root `<svg>` element;
- move to child elements;
- iterate children;
- navigate between sibling elements.

Use these examples when you need to understand or inspect an existing SVG document before editing it.

### Query SVG with CSS Selectors

File: `CSSSelector.cs`

These examples use familiar CSS selector syntax:

- `QuerySelector()` to find the first matching element;
- `QuerySelectorAll()` to find multiple elements;
- edit selected circles in `owl.svg`;
- replace selected circles with rectangles;
- modify path data on an element selected by CSS.

This is often the easiest way to edit known parts of an SVG file.

### Query SVG with XPath

File: `XPathQuery.cs`

XPath examples are useful when selectors need to express document structure or attributes more explicitly:

- select a group by attribute;
- select a rectangle by coordinate;
- iterate XPath results;
- edit an element selected by XPath.

### Iterate SVG Nodes with a Custom Filter

File: `NodeIterator.cs`

This example uses `CreateNodeIterator()` with a custom `NodeFilter` implementation. The included filter accepts only `<rect>` nodes, so the iterator returns rectangle elements from the SVG DOM.

### Edit SVG Documents

Files:

- `EditSVGFile.cs`
- `EditSVGPathData.cs`
- `CreateSVGWithViewBox.cs`

These examples demonstrate common SVG editing tasks:

- create an SVG document from scratch;
- add a circle to an existing SVG file;
- add a polyline and update existing shapes;
- draw SVG annotations over an existing bitmap image;
- edit SVG path segment data programmatically;
- create an SVG with a custom `viewBox`.

### Save SVG Documents

File: `SaveSVGDocumentExamples.cs`

This group covers common persistence scenarios:

- save SVG to a file;
- save SVG to an Aspose `Url`;
- save SVG as compressed SVGZ;
- save SVGZ back to SVG;
- batch convert SVGZ files from `Examples/Data/`;
- save an SVG document with external resources;
- save SVG and resources to memory streams;
- package SVG and resources into a ZIP archive.

## Notes

This section focuses on SVG document structure, DOM navigation, editing, and saving. SVG filters and advanced visual effects are intentionally not covered here because they belong in a separate filters-focused documentation section.

