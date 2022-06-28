---
template: true
title: Kombinieren Sie SVG in gängigen Formaten mit C#
description: Kombinieren Sie Bilder oder SVG in PDF, XPS, PNG, JPEG usw. mit wenigen Zeilen C#-Code.
url: /de/net/merger/
---

{{< blocks/products/pf/main-wrap-class isAutogenPage="true">}}
{{< blocks/products/pf/feature-page-wrap >}}
{{< blocks/products/pf/feature-page-header h1="Kombinieren Sie SVG, JPEG, PNG oder andere Bilder mit C#"  h2="Führen Sie SVG- oder Bilddateien zusammen und speichern Sie das Ergebnis in gängigen Formaten wie PDF, XPS, BMP, JPEG, PNG, GIF und TIFF mit C#" >}}

{{% blocks/products/pf/feature-page-section  h2="So führen Sie SVG und Bilder mit C# zusammen" %}}

Es gibt viele Gründe, warum Sie mehrere SVGs oder Bilder in einem Dokument kombinieren müssen. Um SVG-Dateien zusammenzuführen, verwenden wir <a href="https://products.aspose.com/svg/net/" target="_blank">Aspose.SVG for .NET API</a>, eine Funktion, die reichhaltige, leistungsstarke und benutzerfreundliche API zur Dokumentenbearbeitung und -zusammenführung für die C#-Plattform. Unsere C#-Bibliothek bietet die Klasse <a href="https://reference.aspose.com/svg/net/aspose.svg.rendering/svgrenderer/" target="_blank">SvgRenderer </a> zum Rendern und Zusammenführen von SVG Unterlagen. Die Render()-Methode gibt Ihnen die Möglichkeit, mehrere Dokumente gleichzeitig an das Ausgabe-Rendergerät zu senden und sie zusammenzuführen.



<h2>C#-Beispiel zum Kombinieren von SVG in PDF</h2>

<p>Eine Hochgeschwindigkeits-C#-Bibliothek ermöglicht es .NET-Entwicklern, SVG-Dateien zusammenzuführen und das kombinierte Ergebnis mit hoher Qualität und Effizienz in viele gängige Formate wie PDF, XPS, JPEG, PNG, BMP, GIF und TIFF zu konvertieren. Das Zusammenführen von Dokumenten kann mit ein paar Zeilen Code durchgeführt werden:

</p>

{{% blocks/products/pf/agp/code-block title="SVG in PDF zusammenführen – C#" offSpacer="true" %}}


```cs
// Initialize SVG documents from files to merge 
using (var document1 = new SVGDocument("document1.svg"))
using (var document2 = new SVGDocument("document2.svg"))
using (var document3 = new SVGDocument("document3.svg"))
{
    // Create an instance of SvgRenderer
    using var renderer = new Aspose.Svg.Rendering.SvgRenderer();	
    // Create an instance of SvgRenderer
    using var device = new Aspose.Svg.Rendering.Pdf.PdfDevice("result.pdf");
    //Merge all SVG documents to PDF
    renderer.Render(device, document1, document2, document3);                
}
```



{{% /blocks/products/pf/agp/code-block %}}
{{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="SVG-Merger in der Dokumentation" %}}

Mit der Bibliothek Aspose.SVG für .NET können Sie SVG-Dateien programmgesteuert mit C# erstellen, bearbeiten, lesen, konvertieren und zusammenführen. Der Namespace [Aspose.Svg.Rendering](https://reference.aspose.com/svg/net/aspose.svg.rendering/) implementiert einfachen Zugriff auf Konvertierungs- und Zusammenführungsmethoden. Darüber hinaus bietet es die Möglichkeit, SVG-Dateien in gängigen Formaten wie PDF, XPS, JPEG, PNG, BMP, TIFF und GIF zu kombinieren. Bitte besuchen Sie das Dokumentationskapitel <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-merge-svg-files/" target ="_blank">So führen Sie SVG-Dateien zusammen</a>, um mehr über die Zusammenführungsfunktionen der SVG-C#-API zu erfahren.



 {{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="Aspose.SVG für die .NET-Bibliothek installieren" %}}

Aspose.SVG für .NET ist eine plattformübergreifende flexible Bibliothek, die entwickelt wurde, um eine breite Palette von Funktionen zum Verarbeiten und Rendern von SVG-Dokumenten bereitzustellen. Es lässt sich nahtlos in Ihre .NET-Apps integrieren, um mit SVG-Dateien zu arbeiten, ohne Software von Drittanbietern zu installieren. Unsere SVG .NET-API kann mit jeder .NET-Sprache wie C#, VB.NET, ASP.NET usw. verwendet werden. Sie funktioniert gleichermaßen gut auf jedem Betriebssystem, das Mono installieren (.NET 4.0 Framework-Unterstützung) oder .NET verwenden kann Ader. Dazu gehören Windows, Linux und macOS.

Installieren von <a href="https://www.nuget.org/packages/Aspose.SVG" target="_blank">Aspose.SVG für .NET über NuGet</a>:
1. Verwenden der Paket-Manager-Konsole.
2. Verwenden der NuGet Package Manager-GUI.</br>



  Weitere Einzelheiten zur Installation der C#-Bibliothek finden Sie in der [Aspose.SVG-Dokumentation](https://docs.aspose.com/svg/net/getting-started/installation/).



{{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="Andere unterstützte Fusionen" %}}

Sie können SVG-Dateien in viele andere Dateiformate kombinieren, darunter einige, die unten aufgeführt sind:

{{% /blocks/products/pf/feature-page-section %}}
{{< /blocks/products/pf/feature-page-wrap >}}
{{< /blocks/products/pf/main-wrap-class >}}
{{< blocks/products/pf/feature-page-options pairs="svg-to-pdf svg-to-xps svg-to-bmp jpg-to-jpg png-to-png gif-to-gif svg-to-png svg-to-jpeg svg-to-tiff jpg-to-png png-to-jpg gif-to-jpg svg-to-gif svg-to-image jpg-to-tiff jpg-to-gif png-to-gif gif-to-png" >}}