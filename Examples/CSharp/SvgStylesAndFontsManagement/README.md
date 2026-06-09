# SVG Styles and Fonts Management in C#

This folder contains C# examples for managing SVG styles, text, and fonts with [**Aspose.SVG for .NET**](https://docs.aspose.com/svg/net/).

The examples use local input files from `Examples/Data/` and write generated output to `Examples/output/styles-fonts/`.

## Product Resources

- [Work with SVG Fonts and Text in C#](https://docs.aspose.com/svg/net/working-with-fonts-and-text/)
- [SVG CSS vs Inline Styles vs Presentation Attributes](https://docs.aspose.com/svg/net/svg-styles-css-vs-inline-vs-attributes/)
- [Modify SVG Styles Programmatically in C#](https://docs.aspose.com/svg/net/modify-svg-styles-programmatically/)
- [Fix SVG CSS, Font Fallback, and Rendering Issues](https://docs.aspose.com/svg/net/common-svg-styling-and-font-issues/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [SVGDocument API Reference](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/)

## What You Can Learn

- Apply SVG presentation attributes.
- Apply inline CSS styles to SVG elements.
- Add embedded `<style>` rules to an SVG document.
- Select SVG shapes and update their visual attributes.
- Inspect inline style attributes.
- Normalize inline styles to avoid CSS conflicts.
- Create SVG text elements programmatically.
- Register custom font folders with `FontsSettings`.
- Use font fallback and `@font-face` rules.
- Render SVG text consistently to PNG and PDF.
- Fix common style and font rendering issues before conversion.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET. The package version is defined in `Examples/CSharp/CSharp.csproj`.
- Input files from `Examples/Data/`.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgStylesAndFontsManagement
```

In Visual Studio, select the `SvgStylesAndFontsManagement` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
SvgStylesAndFontsManagementExamples.RunAll();
```

## How to Run Selected Examples

The file `SvgStylesAndFontsManagementExamples.cs` is the central runner for this section. Its `RunAll()` method calls each example group:

```csharp
SvgStyleManagement.Run();
SvgTextAndFonts.Run();
SvgStyleAndFontTroubleshooting.Run();
```

To run only font examples, comment out the other groups:

```csharp
public static void RunAll()
{
    Console.WriteLine("Running SvgStylesAndFontsManagement examples...");

    // SvgStyleManagement.Run();
    SvgTextAndFonts.Run();
    // SvgStyleAndFontTroubleshooting.Run();

    Console.WriteLine("SvgStylesAndFontsManagement examples finished.");
}
```

To run only one method from a file, open that file's `Run()` method and comment out the methods you do not need.

For example, to run only the custom font folder conversion:

```csharp
public static void Run()
{
    // CreateAndStyleSvgTextElement();
    ConvertSvgWithCustomFontFolder();
    // RenderSvgTextWithCustomFont();
    // ConvertSvgTextWithFontFallbackToPdf();
    // UseFontFaceRuleWithLocalFont();
    // RenderConsistentTextToPngAndPdf();
}
```

Then run the section normally:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section SvgStylesAndFontsManagement
```

## Input and Output

Input files are stored centrally:

```text
Examples/Data/
```

Generated files are written to:

```text
Examples/output/styles-fonts/
```

## Example Groups

### SVG Style Management

File: `SvgStyleManagement.cs`

This group demonstrates SVG styling strategies. For product documentation, see [SVG CSS vs Inline Styles vs Presentation Attributes](https://docs.aspose.com/svg/net/svg-styles-css-vs-inline-vs-attributes/) and [Modify SVG Styles Programmatically in C#](https://docs.aspose.com/svg/net/modify-svg-styles-programmatically/).

- `ApplyPresentationAttributesToText()` applies `fill`, `font-size`, and `font-family` directly to SVG text.
- `ApplyInlineCssStylesToText()` writes an inline CSS `style` attribute.
- `AddStyleElementWithCssRules()` creates an embedded `<style>` element.
- `SelectAndFillShapeElements()` updates multiple SVG shape elements.
- `FindElementsWithInlineStyles()` reports elements that already have inline styles.
- `NormalizeInlineFillStyles()` removes `fill` from inline style declarations and replaces it with a presentation attribute.

### SVG Text and Fonts

File: `SvgTextAndFonts.cs`

This group demonstrates SVG text creation and font handling. For product documentation, see [Work with SVG Fonts and Text in C#](https://docs.aspose.com/svg/net/working-with-fonts-and-text/).

- `CreateAndStyleSvgTextElement()` creates text and renders it to JPEG.
- `ConvertSvgWithCustomFontFolder()` registers a custom font folder before conversion.
- `RenderSvgTextWithCustomFont()` renders text with a local Montserrat font.
- `ConvertSvgTextWithFontFallbackToPdf()` uses a font-family fallback list for PDF output.
- `UseFontFaceRuleWithLocalFont()` creates an SVG `@font-face` rule that references a local font file.
- `RenderConsistentTextToPngAndPdf()` renders the same text to PNG and PDF with registered fonts.

### Style and Font Troubleshooting

File: `SvgStyleAndFontTroubleshooting.cs`

This group demonstrates common fixes for SVG style and font issues. For product documentation, see [Fix SVG CSS, Font Fallback, and Rendering Issues](https://docs.aspose.com/svg/net/common-svg-styling-and-font-issues/).

- `RemoveAllInlineStyles()` removes every inline `style` attribute.
- `RemoveConflictingInlineCssProperties()` removes only blocking CSS properties.
- `NormalizeNestedTspanStyles()` cleans conflicting styles on nested `<tspan>` elements.
- `ApplyStylesToTextAndTspanElements()` applies consistent styles to parent and child text nodes.
- `RegisterFontsBeforePdfConversion()` registers local fonts before loading and converting SVG.

## Notes

SVG styling can come from presentation attributes, inline `style` attributes, or CSS rules inside `<style>`. Inline styles have high priority, so style normalization is often required before applying global rules.

For predictable font output, register custom font folders before loading the SVG document that will be rendered or converted.

