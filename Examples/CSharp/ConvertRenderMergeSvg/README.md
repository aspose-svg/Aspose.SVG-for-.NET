# Convert, Render, and Merge SVG in C#

This folder contains C# examples for converting, rendering, resizing, and merging SVG documents with [**Aspose.SVG for .NET**](https://docs.aspose.com/svg/net/).

The examples use local input files from `Examples/Data/` and write generated output to `Examples/output/convert/`.

## Product Resources

- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Convert SVG Files - C# Examples](https://docs.aspose.com/svg/net/convert-svg/)
- [Convert SVG to Image in C#](https://docs.aspose.com/svg/net/convert-svg-to-image/)
- [Convert SVG to PDF in C#](https://docs.aspose.com/svg/net/convert-svg-to-pdf/)
- [Resize SVG During Conversion](https://docs.aspose.com/svg/net/resize-document/)
- [Convert Image to SVG in C#](https://docs.aspose.com/svg/net/convert-image-to-svg/)

## What You Can Learn

- Convert SVG to PNG, JPEG, BMP, GIF, and TIFF.
- Convert SVG to PDF and XPS.
- Render SVG documents with `SVGDocument.RenderTo()`.
- Render SVG documents with `SvgRenderer`.
- Configure image rendering quality, antialiasing, page setup, and output sizing.
- Resize rendered SVG output with `FitContent`, `ScaleContent`, `Contain`, and `Crop`.
- Merge several SVG documents into one PDF.
- Convert PNG and JPG images to SVG with `Converter.ConvertImageToSVG()`.
- Render SVG documents that contain embedded HTML content through `<foreignObject>`.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET. The package version is defined in `Examples/CSharp/CSharp.csproj`.
- Input files from `Examples/Data/`.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section ConvertRenderMergeSvg
```

In Visual Studio, select the `ConvertRenderMergeSvg` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
ConvertRenderMergeSvgExamples.RunAll();
```

## How to Run Selected Examples

The file `ConvertRenderMergeSvgExamples.cs` is the central runner for this section. Its `RunAll()` method calls each example group:

```csharp
ConvertSVGToImage.Run();
ConvertSVGToPDF.Run();
ConvertSVGToXPS.Run();
RenderSVGDocuments.Run();
ResizeSVGDocument.Run();
MergeSVGDocuments.Run();
ConvertImageToSVG.Run();
SupportForHtmlContentInSVG.Run();
```

To run only one group, comment out the calls you do not need. For example, to run only image conversion examples:

```csharp
public static void RunAll()
{
    Console.WriteLine("Running ConvertRenderMergeSvg examples...");

    ConvertSVGToImage.Run();
    // ConvertSVGToPDF.Run();
    // ConvertSVGToXPS.Run();
    // RenderSVGDocuments.Run();
    // ResizeSVGDocument.Run();
    // MergeSVGDocuments.Run();
    // ConvertImageToSVG.Run();
    // SupportForHtmlContentInSVG.Run();

    Console.WriteLine("ConvertRenderMergeSvg examples finished.");
}
```

To run only one method from a file, open that file's `Run()` method and comment out the methods you do not need.

For example, to run only PNG to SVG conversion from `ConvertImageToSVG.cs`:

```csharp
public static void Run()
{
    ConvertPngToSvg();
    // ConvertJpgStreamToSvg();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section ConvertRenderMergeSvg
```

## Input and Output

Input files are stored centrally:

```text
Examples/Data/
```

Generated files are written to:

```text
Examples/output/convert/
```

Keeping input and output separate makes it easier to reuse sample assets across documentation sections.

## Example Groups

### Convert SVG to Images

File: `ConvertSVGToImage.cs`

This group demonstrates raster image output. For product documentation, see [Convert SVG to Image in C#](https://docs.aspose.com/svg/net/convert-svg-to-image/).

- `ConvertSvgToPngUsingConverter()` converts SVG to PNG with `Converter.ConvertSVG()`.
- `RenderSvgToPngUsingRenderTo()` renders SVG to PNG with `SVGDocument.RenderTo()`.
- `ConvertSvgToJpegUsingConverter()` converts SVG to JPEG with an opaque background.
- `RenderSvgToJpegWithAntialiasing()` compares JPEG rendering with and without antialiasing.
- `ConvertSvgToBmp()` renders SVG to BMP.
- `ConvertSvgToGifWithPageSetup()` converts SVG to GIF with custom page setup.
- `ConvertSvgToTiffWithCompression()` renders SVG to TIFF with compression settings.

### Convert SVG to PDF

File: `ConvertSVGToPDF.cs`

This group shows PDF workflows. For product documentation, see [Convert SVG to PDF in C#](https://docs.aspose.com/svg/net/convert-svg-to-pdf/).

- direct SVG file conversion with `Converter.ConvertSVG()`;
- conversion with `FitContent` page sizing;
- conversion from SVG markup stored in a string;
- conversion from an SVG stream;
- conversion with custom PDF page size and margins;
- rendering to a `PdfDevice` with custom `PdfRenderingOptions`.

### Convert SVG to XPS

File: `ConvertSVGToXPS.cs`

This group shows two XPS workflows:

- direct conversion with `Converter.ConvertSVG()`;
- rendering to an `XpsDevice` with custom page settings.

### Render SVG Documents

File: `RenderSVGDocuments.cs`

These examples use `SvgRenderer` directly:

- render SVG to PNG;
- render SVG to JPEG;
- render SVG to XPS.

Use this approach when your application needs lower-level control over rendering devices.

### Resize SVG Output

File: `ResizeSVGDocument.cs`

These examples show how rendering page settings affect output size. For product documentation, see [Resize SVG During Conversion](https://docs.aspose.com/svg/net/resize-document/).

- default page setup;
- `FitContent`;
- `ScaleContent`;
- `Contain`;
- `Crop`.

### Merge SVG Rendering Output

File: `MergeSVGDocuments.cs`

These examples render several SVG documents into one output file. This is not DOM-level SVG merging: the source SVG files are not combined into a new `.svg` document. Instead, `SvgRenderer` sends multiple `SVGDocument` instances to one rendering device, such as `PdfDevice` or `ImageDevice`.

This workflow is useful when multiple SVG diagrams, icons, or drawings must be delivered as one PDF or PNG output.

### Convert Image to SVG

File: `ConvertImageToSVG.cs`

This group demonstrates basic image-to-SVG conversion. For product documentation, see [Convert Image to SVG in C#](https://docs.aspose.com/svg/net/convert-image-to-svg/).

- `ConvertPngToSvg()` converts a PNG image to SVG.
- `ConvertJpgStreamToSvg()` converts a JPG image stream to SVG.

These examples belong here because they use the conversion API `Converter.ConvertImageToSVG()`. Advanced vectorization workflows and tracing settings can be covered in a dedicated vectorization section.

### Render SVG with HTML Content

File: `SupportForHtmlContentInSVG.cs`

This example renders SVG markup that contains XHTML content inside a `<foreignObject>` element.
