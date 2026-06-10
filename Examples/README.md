# Aspose.SVG for .NET Examples

This folder contains example projects and shared input files for **Aspose.SVG for .NET**.

The examples are designed to complement the product documentation and show practical C# scenarios: working with SVG documents, converting and rendering SVG, vectorization, filters, gradients, styles, fonts, transformations, Builder API usage, SVG colors, and photo effects.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Aspose.SVG for .NET Product Page](https://products.aspose.com/svg/net/)
- [Aspose.SVG for .NET NuGet Package](https://www.nuget.org/packages/Aspose.SVG/)
- [Aspose.SVG Support Forum](https://forum.aspose.com/c/svg/28)

## Folder Structure

```text
Examples/
  CSharp/       C# example projects and section runners
  Data/         Shared input files used by examples
  output/       Generated files created when examples run
```

The main C# examples project is located here:

```text
Examples/CSharp/CSharp.csproj
```

For C#-specific instructions and the full section list, see:

```text
Examples/CSharp/README.md
```

## Requirements

- .NET SDK compatible with the target framework used by the examples.
- Visual Studio or another C# IDE.
- NuGet package restore enabled.
- The `Examples/Data/` folder, because many examples load shared input files from it.

The Aspose.SVG package version is defined in the corresponding `.csproj` file.

## Run C# Examples

From the repository root, run a section by passing `--section`:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSVGDocument
```

You can replace `WorkingWithSVGDocument` with another section name, for example:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section ConvertRenderMergeSvg
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgFiltersAndGradients
dotnet run --project Examples\CSharp\CSharp.csproj -- --section UsingSvgBuilder
```

The central runner is:

```text
Examples/CSharp/RunExamples.cs
```

Visual Studio launch profiles are stored in:

```text
Examples/CSharp/Properties/launchSettings.json
```

## Available C# Sections

- `GettingStarted` - license setup examples.
- `WorkingWithSVGDocument` - create, load, edit, navigate, query, and save SVG documents.
- `ConvertRenderMergeSvg` - convert, render, resize, and merge SVG output.
- `ImageAndTextVectorization` - image vectorization, stencil creation, and text vectorization.
- `SvgFiltersAndGradients` - SVG filter effects and gradients.
- `SvgStylesAndFontsManagement` - SVG styles, CSS, text, custom fonts, and font troubleshooting.
- `SvgTransformations` - rotate, translate, scale, skew, matrix transforms, and `viewBox`.
- `UsingSvgBuilder` - create and edit SVG with the Aspose.SVG Builder API.
- `WorkingWithSvgColors` - change SVG colors, backgrounds, and color code formats.
- `PhotoEffects` - separate console app for SVG filter-based photo effects.

## Input and Output Files

Input assets are stored centrally:

```text
Examples/Data/
```

Generated files are written under:

```text
Examples/output/
```

Output folders are created automatically when examples run.

## Download Examples

You can clone the repository or download it as a ZIP archive:

```text
https://github.com/aspose-svg/Aspose.SVG-for-.NET
```

Make sure the `Examples/Data/` folder is downloaded together with the source code.

## Contribute

Contributions are welcome. You can fork the repository, improve or add examples, and open a pull request.

When adding examples, keep them focused, runnable, and documented. Prefer shared input files in `Examples/Data/` and write generated results to `Examples/output/`.
