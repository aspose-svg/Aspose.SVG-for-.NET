# Working with SVG Colors in C#

This folder contains C# examples for changing SVG colors, SVG backgrounds, and color code formats with [**Aspose.SVG for .NET**](https://docs.aspose.com/svg/net/).

The examples use local input files from `Examples/Data/` and write generated SVG output to `Examples/output/colors/`.

## Product Resources

- [How to Change SVG Color - C# Examples](https://docs.aspose.com/svg/net/how-to-change-svg-color/)
- [Change SVG Background Color - C# Examples](https://docs.aspose.com/svg/net/change-svg-background-color/)
- [Convert Color Codes - C# Examples](https://docs.aspose.com/svg/net/convert-color-codes/)
- [SVGDocument API Reference](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/)
- [Aspose.Svg.Drawing.Color API Reference](https://reference.aspose.com/svg/net/aspose.svg.drawing/color/)

## What You Can Learn

- Change SVG `fill` and `stroke` colors with DOM methods.
- Recolor SVG paths and icon-like graphics.
- Add a background rectangle to SVG files.
- Change an existing SVG background color.
- Use CSS style elements and style attributes for SVG backgrounds.
- Convert color values between HEX, RGB, RGBA, HSLA, LAB, and CMYK.
- Generate an SVG color palette from converted color values.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET. The package version is defined in `Examples/CSharp/CSharp.csproj`.
- Input files from `Examples/Data/`.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSvgColors
```

In Visual Studio, select the `WorkingWithSvgColors` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
WorkingWithSvgColorsExamples.RunAll();
```

## How to Run Selected Examples

The file `WorkingWithSvgColorsExamples.cs` is the central runner for this section. Its `RunAll()` method calls each example group:

```csharp
SvgElementColors.Run();
SvgBackgroundColors.Run();
SvgColorCodeConversion.Run();
```

To run only color code conversion examples, comment out the other groups:

```csharp
public static void RunAll()
{
    Console.WriteLine("Running WorkingWithSvgColors examples...");

    // SvgElementColors.Run();
    // SvgBackgroundColors.Run();
    SvgColorCodeConversion.Run();

    Console.WriteLine("WorkingWithSvgColors examples finished.");
}
```

To run only one method from a file, open that file's `Run()` method and comment out the methods you do not need.

For example, to run only HEX to RGB conversion:

```csharp
public static void Run()
{
    ConvertHexToRgb();
    // ConvertRgbaToHsla();
    // ConvertLabToCmyk();
    // CreateConvertedColorPaletteSvg();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSvgColors
```

## Input and Output

Input files are stored centrally:

```text
Examples/Data/
```

Generated files are written to:

```text
Examples/output/colors/
```

## Example Groups

### SVG Element Colors

File: `SvgElementColors.cs`

This group demonstrates how to change SVG element colors with DOM methods. For product documentation, see [How to Change SVG Color - C# Examples](https://docs.aspose.com/svg/net/how-to-change-svg-color/).

- `ChangeSvgCircleFillColor()` changes the `fill` of a circle.
- `ChangeSvgLineStrokeColor()` changes the `stroke` of a line.
- `RecolorSvgPathAndAddBackground()` recolors a path and adds a background shape.
- `CreateColoredShapesSvg()` creates a new SVG with several colored shapes.
- `ModifySvgStyleAttributesWithDom()` combines color attributes and inline styles.

### SVG Background Colors

File: `SvgBackgroundColors.cs`

This group demonstrates several ways to add or change SVG background colors. For product documentation, see [Change SVG Background Color - C# Examples](https://docs.aspose.com/svg/net/change-svg-background-color/).

- `AddBackgroundRectangleToSvg()` inserts a full-size background rectangle.
- `ChangeExistingBackgroundColor()` updates an existing background rectangle.
- `SetSvgBackgroundWithStyleAttribute()` sets background color through the `style` attribute.
- `AddBackgroundWithCssStyleElement()` adds CSS and a background class.
- `EmbedScriptThatAddsBackgroundColor()` saves a script element that can add a background when script execution is enabled.

### SVG Color Code Conversion

File: `SvgColorCodeConversion.cs`

This group demonstrates color parsing and conversion with `Aspose.Svg.Drawing.Color`. For product documentation, see [Convert Color Codes - C# Examples](https://docs.aspose.com/svg/net/convert-color-codes/).

- `ConvertHexToRgb()` converts HEX to RGB.
- `ConvertRgbaToHsla()` converts RGBA to HSLA.
- `ConvertLabToCmyk()` converts LAB to CMYK.
- `CreateConvertedColorPaletteSvg()` creates a visual SVG palette with converted color labels.

## Notes

In SVG, `fill` usually controls the inside of a shape, while `stroke` controls its outline. Lines and open paths usually need `stroke`, not `fill`.

For reliable rendering and conversion, a real background rectangle is often more predictable than relying only on CSS `background` for the root `<svg>` element.
