# SVG Filters and Gradients in C#

This folder contains C# examples for creating SVG filters and gradients with [**Aspose.SVG for .NET**](https://docs.aspose.com/svg/net/).

The examples use local input files from `Examples/Data/` and write generated SVG output to `Examples/output/filters-gradients/`.

## Product Resources

- [SVG Filters Guide](https://docs.aspose.com/svg/net/drawing-basics/svg-filters/)
- [SVG Filters C# Examples](https://docs.aspose.com/svg/net/svg-filters/)
- [Gaussian Blur - SVG Filters](https://docs.aspose.com/svg/net/gaussian-blur/)
- [SVG Gradients - SVG Code and C# Examples](https://docs.aspose.com/svg/net/svg-gradients/)
- [Aspose.Svg.Filters API Reference](https://reference.aspose.com/svg/net/aspose.svg.filters/)

## What You Can Learn

- Create SVG Gaussian blur filters.
- Apply filters to images, rectangles, and text.
- Use `feColorMatrix` for saturation and hue rotation.
- Adjust RGBA channels with `feComponentTransfer`.
- Add drop shadows with `feDropShadow`.
- Create specular lighting with `feSpecularLighting` and `fePointLight`.
- Define linear gradients and radial gradients.
- Reuse gradient paint servers on multiple SVG shapes.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET. The package version is defined in `Examples/CSharp/CSharp.csproj`.
- Input files from `Examples/Data/`.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgFiltersAndGradients
```

In Visual Studio, select the `SvgFiltersAndGradients` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
SvgFiltersAndGradientsExamples.RunAll();
```

## How to Run Selected Examples

The file `SvgFiltersAndGradientsExamples.cs` is the central runner for this section. Its `RunAll()` method calls each example group:

```csharp
SvgFilterEffects.Run();
SvgGradients.Run();
```

To run only gradient examples, comment out the filters group:

```csharp
public static void RunAll()
{
    Console.WriteLine("Running SvgFiltersAndGradients examples...");

    // SvgFilterEffects.Run();
    SvgGradients.Run();

    Console.WriteLine("SvgFiltersAndGradients examples finished.");
}
```

To run only one method from a file, open that file's `Run()` method and comment out the methods you do not need.

For example, to run only a drop shadow example:

```csharp
public static void Run()
{
    // ApplyGaussianBlurToImage();
    // ApplyGaussianBlurToRectangle();
    // ApplySaturationFilterToImage();
    // ApplyHueRotateFilterToImage();
    // ApplyRgbaComponentTransfer();
    AddDropShadowToRectangle();
    // AddDropShadowToText();
    // CreateSpecularLightingEffect();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgFiltersAndGradients
```

## Input and Output

Input files are stored centrally:

```text
Examples/Data/
```

Generated files are written to:

```text
Examples/output/filters-gradients/
```

## Example Groups

### SVG Filter Effects

File: `SvgFilterEffects.cs`

This group demonstrates SVG filter primitives and common visual effects. For product documentation, see [SVG Filters Guide](https://docs.aspose.com/svg/net/drawing-basics/svg-filters/) and [SVG Filters C# Examples](https://docs.aspose.com/svg/net/svg-filters/).

- `ApplyGaussianBlurToImage()` creates a [Gaussian blur SVG filter](https://docs.aspose.com/svg/net/gaussian-blur/) for an image.
- `ApplyGaussianBlurToRectangle()` applies [Gaussian blur](https://docs.aspose.com/svg/net/gaussian-blur/) to a rectangle.
- `ApplySaturationFilterToImage()` uses `feColorMatrix` with `type="saturate"`.
- `ApplyHueRotateFilterToImage()` uses `feColorMatrix` with `type="hueRotate"`.
- `ApplyRgbaComponentTransfer()` adjusts color channels with `feComponentTransfer`.
- `AddDropShadowToRectangle()` creates a rectangle shadow with `feDropShadow`.
- `AddDropShadowToText()` applies a colored shadow to SVG text.
- `CreateSpecularLightingEffect()` creates a simple lighting effect.

### SVG Gradients

File: `SvgGradients.cs`

This group demonstrates SVG paint servers. For product documentation, see [SVG Gradients - SVG Code and C# Examples](https://docs.aspose.com/svg/net/svg-gradients/).

- `CreateLinearGradient()` creates and applies a linear gradient.
- `CreateRadialGradient()` creates and applies a radial gradient.
- `CreateMultipleGradientShapes()` defines multiple gradients and reuses them on different shapes.

## Notes

Filters and gradients are defined inside `<defs>` and then referenced from SVG elements by id, for example `filter="url(#shadow)"` or `fill="url(#linearGradient)"`.
