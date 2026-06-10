# Getting Started with Aspose.SVG for .NET

This folder contains C# examples for applying an **Aspose.SVG for .NET** license.

The examples are safe to run without a license file or metered keys. If credentials are missing, the example prints a clear message and skips the license call instead of failing.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Aspose.SVG for .NET Product Page](https://products.aspose.com/svg/net/)
- [Aspose.SVG for .NET NuGet Package](https://www.nuget.org/packages/Aspose.SVG/)
- [Licensing - Aspose.SVG for .NET](https://docs.aspose.com/svg/net/licensing/)
- [Installation - Aspose.SVG for .NET](https://docs.aspose.com/svg/net/installation/)
- [Aspose.SVG Support Forum](https://forum.aspose.com/c/svg/28)

## What You Can Learn

- Apply an Aspose.SVG license from a file.
- Apply a license from a `FileStream`.
- Apply a license embedded as an assembly resource.
- Apply a metered license without hard-coding keys in source code.
- Run license examples safely when license credentials are not available.

## Requirements

- .NET SDK compatible with `net6.0`.
- Aspose.SVG for .NET. The package version is defined in `Examples/CSharp/CSharp.csproj`.
- Optional: a valid `Aspose.SVG.lic` file.
- Optional: Aspose metered public and private keys.

## How to Run

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section GettingStarted
```

In Visual Studio, select the `GettingStarted` launch profile and run the `CSharp` project.

The section entry point is:

```csharp
GettingStartedExamples.RunAll();
```

## License File Examples

The file-based and stream-based examples expect the license file here:

```text
Examples/Data/Aspose.SVG.lic
```

Methods:

- `LoadLicense.LoadLicenseFromFile()`
- `LoadLicense.LoadLicenseFromStream()`

If the file does not exist, the methods print the expected path and skip the license call.

## Embedded Resource Example

Method:

```csharp
LoadLicense.ApplyLicenseUsingEmbeddedResource();
```

To use this approach:

1. Add `Aspose.SVG.lic` to the project.
2. Set its Build Action to `Embedded Resource`.
3. Run the example.

The method searches the current assembly resources for a resource ending with `Aspose.SVG.lic`.

## Metered License Example

Method:

```csharp
LoadLicense.ApplyMeteredLicense();
```

Set keys with environment variables:

```powershell
$env:ASPOSE_SVG_METERED_PUBLIC_KEY = "your-public-key"
$env:ASPOSE_SVG_METERED_PRIVATE_KEY = "your-private-key"
dotnet run --project Examples\CSharp\CSharp.csproj -- --section GettingStarted
```

The example intentionally reads keys from environment variables so credentials are not committed to source control.

## Example Files

- `GettingStartedExamples.cs` - section runner.
- `LoadLicense.cs` - license setup examples.

## Notes

These examples demonstrate licensing patterns. They do not generate SVG output files.

If you run Aspose.SVG without a license, the library works in evaluation mode. Use a valid license to remove evaluation limitations.
