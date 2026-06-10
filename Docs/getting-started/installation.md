# Install Aspose.SVG for .NET

**Aspose.SVG for .NET** is distributed as a NuGet package. The recommended way to install it is to add the `Aspose.SVG` package to your .NET project and let NuGet restore the required assemblies.

Use this page when you need to install Aspose.SVG for .NET, add it to a C# project, update the package, or verify that the library is ready for SVG creation, editing, rendering, conversion, and vectorization.

## Product Resources

- [Aspose.SVG for .NET Documentation](https://docs.aspose.com/svg/net/)
- [Aspose.SVG for .NET API Reference](https://reference.aspose.com/svg/net/)
- [Aspose.SVG for .NET NuGet Package](https://www.nuget.org/packages/Aspose.SVG/)
- [Aspose.SVG for .NET Product Page](https://products.aspose.com/svg/net/)
- [Aspose.SVG Releases](https://releases.aspose.com/svg/net/)
- [Aspose.SVG Support Forum](https://forum.aspose.com/c/svg/28)

## Requirements

- A .NET project that targets a framework supported by the current Aspose.SVG package.
- Visual Studio, JetBrains Rider, Visual Studio Code, or another .NET development environment.
- NuGet package restore enabled.
- Internet access for restoring the package from NuGet, unless your environment uses an internal package feed.

## Install with .NET CLI

Run this command from the folder that contains your `.csproj` file:

```powershell
dotnet add package Aspose.SVG
```

Then restore and build the project:

```powershell
dotnet restore
dotnet build
```

## Install with Package Manager Console

In Visual Studio, open **Tools > NuGet Package Manager > Package Manager Console** and run:

```powershell
Install-Package Aspose.SVG
```

To update an existing package reference:

```powershell
Update-Package Aspose.SVG
```

## Install with Visual Studio NuGet UI

1. Open your solution in Visual Studio.
2. Right-click the project.
3. Select **Manage NuGet Packages**.
4. Search for `Aspose.SVG`.
5. Select the package and click **Install** or **Update**.

## Add PackageReference Manually

You can also add the package reference directly to a project file:

```xml
<ItemGroup>
  <PackageReference Include="Aspose.SVG" Version="x.y.z" />
</ItemGroup>
```

Use the version required by your project or omit the version when your dependency management process controls package versions centrally.

## Verify Installation

After installation, create and save a simple SVG document:

```csharp
using Aspose.Svg;

using (var document = new SVGDocument())
{
    document.RootElement.SetAttribute("width", "300");
    document.RootElement.SetAttribute("height", "120");
    document.RootElement.SetAttribute("viewBox", "0 0 300 120");

    var text = document.CreateElementNS("http://www.w3.org/2000/svg", "text");
    text.SetAttribute("x", "20");
    text.SetAttribute("y", "70");
    text.SetAttribute("font-size", "24");
    text.TextContent = "Aspose.SVG for .NET";
    document.RootElement.AppendChild(text);

    document.Save("hello.svg");
}
```

If the project builds and `hello.svg` is created, Aspose.SVG for .NET is installed correctly.

## Run the Example Project

The repository includes runnable C# examples:

```powershell
dotnet run --project Examples\CSharp\CSharp.csproj -- --section WorkingWithSVGDocument
```

For the complete examples overview, see [`Examples/CSharp/README.md`](../../Examples/CSharp/README.md).

## Troubleshooting

- If NuGet cannot find the package, make sure `nuget.org` is enabled as a package source.
- If restore fails in a corporate environment, check proxy settings or use an internal NuGet feed.
- If the project builds but output contains evaluation limitations, apply a valid Aspose.SVG license. See [Licensing and Subscription - Aspose.SVG for .NET](licensing.md).
- If you are upgrading old examples, check the target framework in the `.csproj` file and use a .NET SDK compatible with it.

## Common Questions

### How do I install Aspose.SVG for .NET in a C# project?

Use `dotnet add package Aspose.SVG`, Visual Studio NuGet UI, or Package Manager Console.

### Do I need to install Aspose.SVG separately on the machine?

No. NuGet restores the package into your project. You do not need a separate MSI-style installation for normal .NET development.

### Where can I find runnable C# examples?

Use the examples in [`Examples/CSharp`](../../Examples/CSharp/README.md). They cover SVG documents, conversion, rendering, vectorization, styles, fonts, colors, transformations, Builder API, and licensing.
