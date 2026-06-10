# SVG Transformations in C#

This folder contains C# examples for applying SVG transformations with [**Aspose.SVG for .NET**](https://docs.aspose.com/svg/net/).

The examples use local input files from `Examples/Data/` and write generated SVG output to `Examples/output/transformations/`.

## Product Resources

- [SVG Transformations - C# Examples](https://docs.aspose.com/svg/net/svg-transformations/)
- [Rotate SVG - C# Examples](https://docs.aspose.com/svg/net/rotate-svg/)
- [SVG Scaling - C# Examples](https://docs.aspose.com/svg/net/svg-scaling/)
- [SVGMatrix API Reference](https://reference.aspose.com/svg/net/aspose.svg.datatypes/svgmatrix/)

## What You Can Learn

- Rotate SVG elements with `transform="rotate(...)"`.
- Rotate elements around a specific point.
- Translate SVG shapes and paths.
- Scale individual elements and whole SVG documents.
- Apply transformations with the Aspose.SVG Builder API.
- Build transformation matrices with `SVGMatrix`.
- Combine scale, translate, and rotate transformations.
- Crop visible SVG content with `viewBox`.
- Skew SVG content with `skewX()`.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET. The package version is defined in `Examples/CSharp/CSharp.csproj`.
- Input files from `Examples/Data/`.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgTransformations
```

In Visual Studio, select the `SvgTransformations` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
SvgTransformationsExamples.RunAll();
```

## How to Run Selected Examples

The file `SvgTransformationsExamples.cs` is the central runner for this section. Its `RunAll()` method calls each example group:

```csharp
RotateSvgElements.Run();
TranslateAndScaleSvgElements.Run();
MatrixAndViewBoxTransformations.Run();
```

To run only matrix and viewBox examples, comment out the other groups:

```csharp
public static void RunAll()
{
    Console.WriteLine("Running SvgTransformations examples...");

    // RotateSvgElements.Run();
    // TranslateAndScaleSvgElements.Run();
    MatrixAndViewBoxTransformations.Run();

    Console.WriteLine("SvgTransformations examples finished.");
}
```

To run only one method from a file, open that file's `Run()` method and comment out the methods you do not need.

For example, to run only `viewBox` cropping:

```csharp
public static void Run()
{
    // RotateRectangleWithMatrix();
    // TranslateRectangleWithMatrix();
    // CombineScaleTranslateRotateMatrix();
    CropSvgWithViewBox();
    // SkewExistingSvgImage();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgTransformations
```

## Input and Output

Input files are stored centrally:

```text
Examples/Data/
```

Generated files are written to:

```text
Examples/output/transformations/
```

## Example Groups

### Rotate SVG Elements

File: `RotateSvgElements.cs`

This group demonstrates SVG rotation. For product documentation, see [Rotate SVG - C# Examples](https://docs.aspose.com/svg/net/rotate-svg/).

- `RotateRectangleWithTransformAttribute()` creates a rectangle and applies `rotate(45)`.
- `RotateExistingRectangleAroundPoint()` rotates a selected rectangle around a fixed point.
- `RotateRectangleUsingBuilderApi()` applies rotation with the Aspose.SVG Builder API.

### Translate and Scale SVG Elements

File: `TranslateAndScaleSvgElements.cs`

This group demonstrates SVG translation and scaling. For product documentation, see [SVG Transformations - C# Examples](https://docs.aspose.com/svg/net/svg-transformations/) and [SVG Scaling - C# Examples](https://docs.aspose.com/svg/net/svg-scaling/).

- `TranslateRectangle()` moves a rectangle with `translate(x, y)`.
- `TranslateExistingPath()` moves a selected path in an existing SVG file.
- `ScaleCircle()` scales a circle with `scale(2)`.
- `ScaleExistingSvgDocument()` scales the root `<svg>` element.
- `ScaleSvgUsingBuilderApi()` applies scaling with the Builder API.

### Matrix and ViewBox Transformations

File: `MatrixAndViewBoxTransformations.cs`

This group demonstrates calculated transforms and visible-area changes. For API details, see [SVGMatrix API Reference](https://reference.aspose.com/svg/net/aspose.svg.datatypes/svgmatrix/).

- `RotateRectangleWithMatrix()` rotates a rectangle with `SVGMatrix`.
- `TranslateRectangleWithMatrix()` translates a rectangle with `SVGMatrix`.
- `CombineScaleTranslateRotateMatrix()` chains several matrix operations.
- `CropSvgWithViewBox()` changes the visible SVG coordinate area.
- `SkewExistingSvgImage()` applies a `skewX()` transform.

## Notes

The SVG `transform` attribute affects rendering without directly changing the original geometry values such as `x`, `y`, `width`, `height`, or path data.

The `viewBox` attribute is not a transform function, but it is often used alongside transformations because it controls which coordinate area is visible.

