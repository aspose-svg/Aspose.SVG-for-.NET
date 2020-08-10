---
title: Installation
type: docs
weight: 60
url: /net/installation/
---

## **Installing Aspose.SVG for .NET through NuGet**
NuGet is a free, open-source developer-focused package management system for the .NET platform intent on simplifying the process of incorporating third party libraries into a .NET application during development. It is a Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects that use the .NET Framework. A library or tool can easily be shared with other developers by creating a NuGet package and storing it inside a NuGet repository. When you install the package, NuGet copies files to your solution and automatically makes the necessary changes, such as adding references and changing your app.config or web.config files. If you decide to remove the library, NuGet removes files and reverses whatever changes it made to your project so that no clutter is left.
### **Referencing Aspose.SVG for .NET**
Taking benefit of this wonderful feature, we have bundled [Aspose.SVG for .NET](https://www.nuget.org/packages/Aspose.SVG) libraries into a NuGet package and uploaded it into a NuGet repository. With this option, you benefit from using Aspose.SVG for .NET without installing this component on your system. NuGet runs in Visual Studio 2010 and higher version(s), Visual Web Developer 2010, and Windows Phone Developer Tools 7.1. In our tests, we have tested it with Visual Studio 2015 Ultimate.

To get started:

1. Open your solution or project in Visual Studio.
1. Add NuGet Package Manager as a Visual Studio extension:
   1. Select the **Tools** menu followed by **Extension Manager**.
   1. Select **Online Gallery** to get a complete list of packages available online.
   1. Select **NuGet Package Manager**.
   1. Click **Download**.
   1. Once the package Manager is installed, restart Visual Studio to bring the changes into effect. 
      When NuGet Package Manager is installed, you can find, install, remove, and update packages from the **Manage NuGet Packages** window, or by using PowerShell command-line commands in the **Package Manager Console** dedicated Visual Studio window. You can find both options if you select the **Tools** followed by the **Library Package Manager**.
### **Install-Package using Package Manager Console**
To reference the component using the package manager console:

1. Open your .NET application in Visual Studio.
1. On the **Tools** menu, select **Library Package Manager** and then **Package Manager Console**.
1. Type the command “Install-Package Aspose.SVG” to install the latest full release, or type the command “Install-Package Aspose.SVG -prerelease” to install the latest release including hotfixes.
1. Press **Enter**.
### **Update package using Package Manager Console**
If you have already referenced the component through NuGet, follow these steps to update the reference to the latest version:

1. Open your .NET application in Visual Studio.
1. From the **Tools** menu, select **Library Package Manager**, followed by the **Package Manager Console** to open the Package Manager console.
1. Type the command “Update-Package Aspose.SVG” to reference the latest full release, or type the command “Update-Package Aspose.SVG -prerelease” to install the latest release including hotfixes.
1. Press **Enter**.
### **Install-Package using the Package Manager GUI**
Follow these steps to reference the component using the package manager GUI:

1. Open your .NET application in Visual Studio.
1. From the **Tools** menu, select **Library Package Manager** and **Manage NuGet Packages** from the **Solution** option. 
   You can also get a similar option from the Solution Explorer:
   1. Right-click the project name.
   1. Select **Manage NuGet Packages**.
1. Select **online** from the left menu.
1. Type **Aspose.SVG** into the search box to find Aspose.SVG for .NET.
1. Click **Install/Update** next to the latest version of Aspose.SVG for .NET.
