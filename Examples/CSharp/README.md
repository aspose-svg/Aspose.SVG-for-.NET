# Aspose.SVG for .NET C# Examples

This folder contains C# examples for working with **Aspose.SVG for .NET**.

The examples are organized by documentation topic. Each section contains focused C# files, a section runner, and, for the main rewritten sections, a local `README.md` with details and product links.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Aspose.SVG for .NET Product Page](https://products.aspose.com/svg/net/)
- [Aspose.SVG for .NET NuGet Package](https://www.nuget.org/packages/Aspose.SVG/)
- [Aspose.SVG Support Forum](https://forum.aspose.com/c/svg/28)

## Requirements

- .NET SDK compatible with `net6.0`.
- Visual Studio or another C# IDE.
- NuGet package restore enabled.
- Input files from `Examples/Data/`.

The Aspose.SVG package version is defined in `CSharp.csproj`.

## Project Structure

```text
Examples/
  Data/                 Shared input files for examples
  output/               Generated files created by examples
  CSharp/
    CSharp.csproj       Main C# examples project
    RunExamples.cs      Central runner for section-based execution
    Properties/
      launchSettings.json
```

## How to Run from Command Line

Run a specific section from the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSVGDocument
```

Replace `WorkingWithSVGDocument` with any available section name.

## How to Run in Visual Studio

1. Open the solution or the `Examples/CSharp/CSharp.csproj` project.
2. Restore NuGet packages.
3. Select a launch profile such as `WorkingWithSVGDocument`, `ConvertRenderMergeSvg`, or `UsingSvgBuilder`.
4. Run the project.

Launch profiles are stored in:

```text
Examples/CSharp/Properties/launchSettings.json
```

## Available Sections

### GettingStarted

License setup examples for Aspose.SVG for .NET.

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section GettingStarted
```

### WorkingWithSVGDocument

Examples for creating, loading, editing, navigating, querying, and saving SVG documents.

Folder: `WorkingWithSVGDocument/`

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSVGDocument
```

### ConvertRenderMergeSvg

Examples for converting SVG to PDF, PNG, JPEG, TIFF, GIF, XPS, rendering SVG documents, resizing SVG, converting images to SVG, and rendering multiple SVG files into one output document.

Folder: `ConvertRenderMergeSvg/`

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section ConvertRenderMergeSvg
```

### ImageAndTextVectorization

Examples for image vectorization, stencil creation, and SVG text vectorization.

Folder: `ImageAndTextVectorization/`

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section ImageAndTextVectorization
```

### SvgFiltersAndGradients

Examples for creating SVG filters and gradients.

Folder: `SvgFiltersAndGradients/`

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgFiltersAndGradients
```

### SvgStylesAndFontsManagement

Examples for SVG styles, CSS rules, text, custom fonts, fallback fonts, and common style/font fixes.

Folder: `SvgStylesAndFontsManagement/`

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgStylesAndFontsManagement
```

### SvgTransformations

Examples for rotating, translating, scaling, skewing, using `SVGMatrix`, and changing the visible area with `viewBox`.

Folder: `SvgTransformations/`

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgTransformations
```

### UsingSvgBuilder

Examples for creating and editing SVG with the Aspose.SVG Builder API, including shapes, paths, styles, paint servers, filters, and clip paths.

Folder: `UsingSvgBuilder/`

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section UsingSvgBuilder
```

### WorkingWithSvgColors

Examples for changing SVG element colors, SVG background colors, and converting color codes.

Folder: `WorkingWithSvgColors/`

Run:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSvgColors
```

### PhotoEffects

`PhotoEffects/` is a separate console sample application for applying SVG filter-based photo effects to raster images. It has its own project file and README.

Run it from its own folder or project:

```powershell
dotnet run --project Examples\CSharp\PhotoEffects\PhotoEffects.csproj -- --help
```

## How to Run Only One Example

Each rewritten section has a central `*Examples.cs` runner. For example:

```csharp
WorkingWithSvgColorsExamples.RunAll();
```

To run only one group or one method, open the section runner or the target file and comment out the method calls you do not need.

Example:

```csharp
public static void RunAll()
{
    // SvgElementColors.Run();
    SvgBackgroundColors.Run();
    // SvgColorCodeConversion.Run();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSvgColors
```

## Input and Output Files

Input files are stored centrally in:

```text
Examples/Data/
```

Generated files are written to section-specific folders under:

```text
Examples/output/
```

For example:

```text
Examples/output/svg/
Examples/output/convert/
Examples/output/vectorization/
Examples/output/filters-gradients/
Examples/output/styles-fonts/
Examples/output/transformations/
Examples/output/builder/
Examples/output/colors/
```

## Notes

The folders `bin/` and `obj/` are build artifacts and are not part of the examples.

The main `CSharp.csproj` excludes `PhotoEffects/` because `PhotoEffects` is an independent console project with its own `.csproj` file.
