# Using SVG Builder in C#

This folder contains C# examples for creating and editing SVG documents with the [**Aspose.SVG for .NET**](https://docs.aspose.com/svg/net/) Builder API.

The examples use local input files from `Examples/Data/` and write generated SVG output to `Examples/output/builder/`.

## Product Resources

- [SVG Builder API - C# Examples](https://docs.aspose.com/svg/net/svg-builder-api/)
- [SVG Element Builders](https://docs.aspose.com/svg/net/element-builders/)
- [SVG Path Builder](https://docs.aspose.com/svg/net/path-builder/)
- [SVG Paint Builder](https://docs.aspose.com/svg/net/paint-builder/)
- [SVG Rule Builder](https://docs.aspose.com/svg/net/rule-builder/)
- [SVGSVGElementBuilder API Reference](https://reference.aspose.com/svg/net/aspose.svg.builder/svgsvgelementbuilder/)

## What You Can Learn

- Create an SVG document from scratch with `SVGSVGElementBuilder`.
- Add SVG shapes, groups, text, paths, gradients, patterns, filters, and clip paths.
- Edit existing SVG documents with element-specific builders.
- Build SVG path data with fluent path commands.
- Use Paint Builder for pattern and gradient references.
- Use Rule Builder to create CSS rules inside SVG.
- Combine Builder API calls with the SVG DOM when updating existing files.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET. The package version is defined in `Examples/CSharp/CSharp.csproj`.
- Input files from `Examples/Data/`.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section UsingSvgBuilder
```

In Visual Studio, select the `UsingSvgBuilder` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
UsingSvgBuilderExamples.RunAll();
```

## How to Run Selected Examples

The file `UsingSvgBuilderExamples.cs` is the central runner for this section. Its `RunAll()` method calls each example group:

```csharp
BasicSvgBuilder.Run();
SvgBuilderShapesAndPaths.Run();
SvgBuilderStylesAndPaint.Run();
SvgBuilderFiltersAndClipping.Run();
```

To run only path examples, comment out the other groups:

```csharp
public static void RunAll()
{
    Console.WriteLine("Running UsingSvgBuilder examples...");

    // BasicSvgBuilder.Run();
    SvgBuilderShapesAndPaths.Run();
    // SvgBuilderStylesAndPaint.Run();
    // SvgBuilderFiltersAndClipping.Run();

    Console.WriteLine("UsingSvgBuilder examples finished.");
}
```

To run only one method from a file, open that file's `Run()` method and comment out the methods you do not need.

For example, to run only the SVG gradient Builder example:

```csharp
public static void Run()
{
    // CreateCssRulesWithRuleBuilder();
    // CreatePatternFillWithPaintBuilder();
    CreateLinearGradientFill();
    // AddBackgroundToExistingSvg();
    // AddSvgTextWithBuilderApi();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section UsingSvgBuilder
```

## Input and Output

Input files are stored centrally:

```text
Examples/Data/
```

Generated files are written to:

```text
Examples/output/builder/
```

## Example Groups

### Basic SVG Builder

File: `BasicSvgBuilder.cs`

This group demonstrates the foundation of the [SVG Builder API](https://docs.aspose.com/svg/net/svg-builder-api/) and [SVG Element Builders](https://docs.aspose.com/svg/net/element-builders/).

- `CreateSvgFromScratch()` creates a new SVG document with shapes and text.
- `CreateComplexSvgWithBuilderApi()` creates nested SVG content with `<defs>`, gradients, groups, paths, and `<use>`.
- `AddShapesToExistingSvg()` adds new Builder-created elements to an existing SVG file.
- `ModifyExistingSvgElement()` updates an existing element with a builder.

### SVG Shapes and Paths

File: `SvgBuilderShapesAndPaths.cs`

This group demonstrates shape builders and [SVG Path Builder](https://docs.aspose.com/svg/net/path-builder/).

- `CreateBasicSvgShapes()` creates common SVG elements in one document.
- `CreateSvgPathWithPathBuilder()` builds path data with `M`, `L`, and `Z` commands.
- `CreateBezierCurveWithPathBuilder()` builds cubic Bezier curves.
- `CombinePathSegments()` combines raw SVG path segments.
- `CreateTextAlongPath()` creates SVG text bound to paths with `<textPath>`.

### SVG Styles and Paint

File: `SvgBuilderStylesAndPaint.cs`

This group demonstrates [SVG Rule Builder](https://docs.aspose.com/svg/net/rule-builder/) and [SVG Paint Builder](https://docs.aspose.com/svg/net/paint-builder/).

- `CreateCssRulesWithRuleBuilder()` creates embedded CSS rules.
- `CreatePatternFillWithPaintBuilder()` creates reusable SVG patterns.
- `CreateLinearGradientFill()` creates a linear gradient and applies it as a fill.
- `AddBackgroundToExistingSvg()` inserts a background layer into an existing SVG.
- `AddSvgTextWithBuilderApi()` adds text with Builder API overloads.

### SVG Filters and Clipping

File: `SvgBuilderFiltersAndClipping.cs`

This group shows how Builder API can also create SVG effects and clipping definitions.

- `ApplyGaussianBlurWithBuilder()` creates a Gaussian blur filter.
- `CreateDropShadowFilterWithBuilder()` creates a drop shadow filter.
- `CreateClipPathWithBuilderApi()` defines and applies a clip path.
- `CreateCircularClipPathWithBuilder()` builds a circular clipping window step by step.

## Notes

The Builder API is especially useful when SVG documents must be created or modified programmatically. It reduces manual attribute handling and makes nested SVG structures easier to read in C#.

Builder examples in this folder intentionally overlap with other sections such as filters, gradients, styles, and transformations. Here the focus is the Builder API syntax; the topic-specific sections explain the SVG concepts in more detail.
