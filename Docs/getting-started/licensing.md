# Licensing and Subscription - Aspose.SVG for .NET

Aspose.SVG for .NET can run in evaluation mode, but a valid license removes evaluation limitations. You can apply a license from a file, a stream, an embedded resource, or use metered licensing.

Use this page when you need to apply an Aspose.SVG license in C#, understand evaluation limitations, request a temporary license, or configure metered license keys.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Licensing - Aspose.SVG for .NET](https://docs.aspose.com/svg/net/getting-started/licensing/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [License Class API Reference](https://reference.aspose.com/svg/net/aspose.svg/license/)
- [Metered Class API Reference](https://reference.aspose.com/svg/net/aspose.svg/metered/)
- [Temporary License](https://purchase.aspose.com/temporary-license/)
- [Aspose.SVG Releases](https://releases.aspose.com/svg/net/)

## Evaluation Version

You can download and use Aspose.SVG for .NET without a license for evaluation. The evaluation version provides the API functionality, but output may include evaluation limitations.

Typical evaluation limitations include:

- A watermark may be added to output files.
- Only the first pages of a multipage output may be converted.
- Serialization may save only part of the SVG document nodes.

To test without evaluation limitations, request a [30-day temporary license](https://purchase.aspose.com/temporary-license/).

## Apply a License from File

Place `Aspose.SVG.lic` in a known location and pass the file path to `SetLicense()`:

```csharp
using Aspose.Svg;

var license = new License();
license.SetLicense("Aspose.SVG.lic");
```

In the examples project, file-based licensing expects:

```text
Examples/Data/Aspose.SVG.lic
```

See [`LoadLicense.LoadLicenseFromFile()`](../../Examples/CSharp/GettingStarted/LoadLicense.cs).

## Apply a License from Stream

Use a stream when the license is stored outside the default probing path or loaded from custom storage:

```csharp
using Aspose.Svg;
using System.IO;

var license = new License();

using (var stream = new FileStream("Aspose.SVG.lic", FileMode.Open, FileAccess.Read))
{
    license.SetLicense(stream);
}
```

See [`LoadLicense.LoadLicenseFromStream()`](../../Examples/CSharp/GettingStarted/LoadLicense.cs).

## Apply a License as an Embedded Resource

You can embed `Aspose.SVG.lic` into your application assembly:

1. Add `Aspose.SVG.lic` to the project.
2. Set **Build Action** to **Embedded Resource**.
3. Pass the embedded resource name to `SetLicense()`.

```csharp
using Aspose.Svg;

var license = new License();
license.SetLicense("YourAssembly.Aspose.SVG.lic");
```

See [`LoadLicense.ApplyLicenseUsingEmbeddedResource()`](../../Examples/CSharp/GettingStarted/LoadLicense.cs).

## Apply a Metered License

Metered licensing lets you use public and private metered keys. Do not hard-code real keys in source control. Store them in environment variables, a secure configuration provider, or a secrets manager.

```csharp
using Aspose.Svg;
using System;

string publicKey = Environment.GetEnvironmentVariable("ASPOSE_SVG_METERED_PUBLIC_KEY");
string privateKey = Environment.GetEnvironmentVariable("ASPOSE_SVG_METERED_PRIVATE_KEY");

var metered = new Metered();
metered.SetMeteredKey(publicKey, privateKey);
```

PowerShell example:

```powershell
$env:ASPOSE_SVG_METERED_PUBLIC_KEY = "your-public-key"
$env:ASPOSE_SVG_METERED_PRIVATE_KEY = "your-private-key"
dotnet run --project Examples\CSharp\CSharp.csproj -- --section GettingStarted
```

See [`LoadLicense.ApplyMeteredLicense()`](../../Examples/CSharp/GettingStarted/LoadLicense.cs).

## Run Licensing Examples

From the repository root:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section GettingStarted
```

The examples are safe to run without a license file or metered keys. Missing credentials are reported and skipped instead of causing the program to fail.

For section details, see [`Examples/CSharp/GettingStarted/README.md`](../../Examples/CSharp/GettingStarted/README.md).

## Common Questions

### Can I use Aspose.SVG for .NET without a license?

Yes, but it runs in evaluation mode and output may contain evaluation limitations. Apply a valid or temporary license for unrestricted testing.

### Where should I put the license file?

You can put the license anywhere your application can read it. The repository examples expect `Examples/Data/Aspose.SVG.lic`.

### Should I commit Aspose.SVG.lic to Git?

No. License files and metered keys should not be committed to source control.

### What is the safest way to store metered keys?

Use environment variables, secure application settings, or a secrets manager. Avoid hard-coding keys in `.cs`, `.json`, or `.config` files.
