# Image and Text Vectorization in C#

This folder contains C# examples for image vectorization and SVG text vectorization with [**Aspose.SVG for .NET**](https://docs.aspose.com/svg/net/).

The examples use local input files from `Examples/Data/` and write generated output to `Examples/output/vectorization/`.

## Product Resources

- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Image and Text Vectorization Overview](https://docs.aspose.com/svg/net/vectorization/)
- [Convert Image to SVG in C#](https://docs.aspose.com/svg/net/convert-image-to-svg/)
- [Aspose.Svg.ImageVectorization API Reference](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/)

## What You Can Learn

- Vectorize PNG images to SVG.
- Vectorize JPG photos to SVG.
- Configure `ImageVectorizer` and `ImageVectorizerConfiguration`.
- Use `BezierPathBuilder` and `SplinePathBuilder`.
- Tune tracing with `ImageTraceSmoother` and `ImageTraceSimplifier`.
- Limit vectorized output colors with `ColorsLimit`.
- Create mono-color SVG stencil output from a raster image.
- Save SVG text as editable text.
- Convert SVG text elements into path geometry with `SVGSaveOptions.VectorizeText`.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET. The package version is defined in `Examples/CSharp/CSharp.csproj`.
- Input files from `Examples/Data/`.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section ImageAndTextVectorization
```

In Visual Studio, select the `ImageAndTextVectorization` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
ImageAndTextVectorizationExamples.RunAll();
```

## How to Run Selected Examples

The file `ImageAndTextVectorizationExamples.cs` is the central runner for this section. Its `RunAll()` method calls each example group:

```csharp
ImageVectorization.Run();
ImageStencil.Run();
TextVectorization.Run();
```

To run only text vectorization examples, comment out the other calls:

```csharp
public static void RunAll()
{
    Console.WriteLine("Running ImageAndTextVectorization examples...");

    // ImageVectorization.Run();
    // ImageStencil.Run();
    TextVectorization.Run();

    Console.WriteLine("ImageAndTextVectorization examples finished.");
}
```

To run only one method from a file, open that file's `Run()` method and comment out the methods you do not need.

For example, to run only PNG vectorization with default settings:

```csharp
public static void Run()
{
    VectorizePngWithDefaultSettings();
    // VectorizePngWithBezierPathBuilder();
    // VectorizePngWithSplinePathBuilder();
    // CompareTraceSimplifierSettings();
    // VectorizeJpegPhoto();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section ImageAndTextVectorization
```

## Input and Output

Input files are stored centrally:

```text
Examples/Data/
```

Generated files are written to:

```text
Examples/output/vectorization/
```

## Example Groups

### Image Vectorization

File: `ImageVectorization.cs`

This group demonstrates raster-to-vector conversion with `ImageVectorizer`. For product documentation, see [Image and Text Vectorization Overview](https://docs.aspose.com/svg/net/vectorization/) and [Convert Image to SVG in C#](https://docs.aspose.com/svg/net/convert-image-to-svg/).

- `VectorizePngWithDefaultSettings()` vectorizes a PNG image with default settings.
- `VectorizePngWithBezierPathBuilder()` uses `BezierPathBuilder` for configurable curve tracing.
- `VectorizePngWithSplinePathBuilder()` uses `SplinePathBuilder` and path simplification.
- `CompareTraceSimplifierSettings()` creates several SVG outputs with different simplification levels.
- `VectorizeJpegPhoto()` vectorizes a JPG photo with a higher color limit.

### Image Stencil

File: `ImageStencil.cs`

This example creates mono-color vector output from a raster image. It uses `StencilConfiguration` to produce an icon-like SVG result.

### Text Vectorization

File: `TextVectorization.cs`

This group demonstrates SVG text handling. For product documentation, see [Image and Text Vectorization Overview](https://docs.aspose.com/svg/net/vectorization/).

- `SaveSvgWithTextAsText()` saves a comparison copy with editable `<text>` elements.
- `VectorizeSvgTextToPaths()` saves SVG text as path geometry by setting `SVGSaveOptions.VectorizeText = true`.

Text vectorization is useful when a document must look the same on machines that do not have the original fonts installed.

## Note About ConvertImageToSVG

The `ConvertRenderMergeSvg` section includes a basic `ConvertImageToSVG.cs` example because it demonstrates the conversion API `Converter.ConvertImageToSVG()`.

This section goes deeper into vectorization-specific settings, including path builders, smoothing, simplification, stencil output, and text-to-path conversion.
