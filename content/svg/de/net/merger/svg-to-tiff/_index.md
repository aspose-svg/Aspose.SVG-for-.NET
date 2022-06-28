---
template: true
title: Zusammenführen von SVG zu TIFF über C# - Aspose.SVG
description: Zusammenführen von SVG zu TIFF mithilfe der C#-API unter Windows, macOS und Linux
url: /de/net/merger/svg-to-tiff/
family: svg
platformtag: net
feature: conversion
informat: SVG
outformat: BMP
otherformats: GIF JPEG PNG TIFF 
---
<!-- template1.md -->

{{< blocks/products/pf/main-wrap-class isAutogenPage="true" >}}

{{< blocks/products/pf/upper-banner h1="SVG zu TIFF über C# zusammenführen" h2="Hochgeschwindigkeits-.NET-API zum Kombinieren von SVG-Dateien unter Windows, macOS und Linux" logoImageSrc="https://www.aspose.cloud/templates/aspose/img/products/svg/headers/aspose_svg-for-net.svg" pfName="Aspose.SVG " subTitlepfName="for .NET" downloadUrl="https://downloads.aspose.com/svg/net" >}}

{{< blocks/products/pf/main-container >}}

{{% blocks/products/pf/agp/content h2="Zusammenführen von SVG in TIFF mit C#" %}}

SVG ist eines der am häufigsten verwendeten Formate zum Erstellen von Websites und zum Drucken von Grafiken, um Skalierbarkeit zu erreichen. Aber manchmal müssen Sie SVG-Dateien zusammenführen und als ein Rasterbild speichern. TIFF ist ein beliebtes Format zum Speichern von Deep-Color-Bildern. Mit der API [Aspose.SVG for .NET](https://products.aspose.com/svg/net/) können Sie SVG programmgesteuert mit TIFF zusammenführen. Die leistungsstarke C#-API hilft Ihnen, SVG-Dateien schnell und in hoher Qualität zu kombinieren!


<br>

<h2>C#-Codebeispiel zum Zusammenführen von SVG zu TIFF</h2>

Eine Hochgeschwindigkeits-C#-Bibliothek ermöglicht es .NET-Entwicklern, SVG-Dateien zusammenzuführen und das kombinierte Ergebnis schnell und effizient in andere gängige Formate wie PDF, XPS, JPEG, PNG, BMP, GIF und TIFF zu konvertieren. Das Zusammenführen von Dokumenten kann mit ein paar Zeilen Code durchgeführt werden:

<br>

{{% blocks/products/pf/agp/code-block title="SVG in TIFF zusammenführen - C#" offSpacer="true" %}}


```cs
// Initialize SVG documents from files to merge 
using (var document1 = new SVGDocument("document1.svg"))
using (var document2 = new SVGDocument("document2.svg"))
using (var document3 = new SVGDocument("document3.svg"))
{
    // Create an instance of SvgRenderer
    using var renderer = new Aspose.Svg.Rendering.SvgRenderer();	
    // Create an instance of ImageDevice
    using var device = new Aspose.Svg.Rendering.Image.ImageDevice("result.tiff");
    // Merge SVG to TIFF
    renderer.Render(device, document1, document2, document3);                
}
```

 

<p></p></br></br>

{{% /blocks/products/pf/agp/code-block %}}

<h2>Schritte zum Zusammenführen von SVG zu TIFF mit C#</h2>

1. Laden Sie ein SVG-Dokument mit einem der [SVGDocument()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/svgdocument/)-Konstruktoren.
1. Erstellen Sie eine neue Instanz der Klasse [SvgRenderer](https://reference.aspose.com/svg/net/aspose.svg.rendering/svgrenderer/).
1. Verwenden Sie den Konstruktor [ImageDevice()](https://reference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/imagedevice/#constructor_5), um eine neue Instanz der ImageDevice-Klasse zu initialisieren.
1. Rufen Sie die Methode [Render()](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderer-1/) auf, um SVG zu TIFF-Bild zusammenzuführen.
1. Mehrere SVG-Dateien werden im TIFF-Bild im angegebenen Pfad gespeichert.




<br>


Der Namespace [Aspose.Svg.Rendering](https://reference.aspose.com/svg/net/aspose.svg.rendering/) implementiert einfachen Zugriff auf Render()-Methoden. Sie können SVG-Zusammenführungen schnell durchführen und das Kombinationsergebnis in gängige Formate wie PDF, XPS, JPEG, PNG, BMP, TIFF und GIF exportieren. Bitte besuchen Sie <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/" target="_blank">unsere Dokumentation</a>, um mehr zu erfahren mehr über die Verwendung von Aspose.SVG-API-Funktionen. Im Dokumentationsartikel <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-merge-svg-files/" target= "_blank">So führen Sie SVG-Dateien zusammen</a>, können Sie sich C#-Beispiele zum Zusammenführen von SVG ansehen.


<br>

<h2>Online-Bildzusammenführung</h2>

Aspose.SVG bietet eine kostenlose Online-<a href="https://products.aspose.app/svg/merger" target="_blank">Image Merger</a>-App, die mehrere Bilder in einer einzigen Datei kombiniert. Sie können eine Art Bildzusammenführung für verschiedene Quelldateien wie SVG, JPG, PNG, BMP, ICO, GIF oder TIFF auswählen und das Ergebnis in einem der folgenden Ausgabeformate speichern: JPG, PNG oder SVG. Unsere Anwendung ist multifunktional. Sie können Bildcollagen erstellen, Bilder vor dem Zusammenführen bearbeiten und manipulieren. Mit Image Merger können Sie Bilder frei hinzufügen, drehen, skalieren, Hintergründe hinzufügen, filtern und jedes Bild verschieben, bis Sie mit dem Endergebnis Ihres Designs zufrieden sind.



{{% /blocks/products/pf/agp/content %}}

{{% blocks/products/pf/agp/content h2="Erste Schritte mit der .NET SVG-API" %}}

Installieren Sie von der Befehlszeile als ```nuget install Aspose.SVG``` oder über die Package Manager Console von Visual Studio mit ```Install-Package Aspose.SVG```.
Alternativ können Sie das Offline-MSI-Installationsprogramm oder DLLs in einer ZIP-Datei von [downloads](https://downloads.aspose.com/svg/net) herunterladen. Aspose.SVG für .NET API ist eine eigenständige Bibliothek und hängt von keiner Software für die Verarbeitung von SVG-Dokumenten ab.
 Weitere Einzelheiten zur Installation der C#-Bibliothek und zu den Systemanforderungen finden Sie in der [Aspose.SVG-Dokumentation](https://docs.aspose.com/svg/net/getting-started/).



{{% /blocks/products/pf/agp/content %}}

{{< blocks/products/pf/agp/other-supported-section title="Andere unterstützte Fusionen" subTitle="Sie können SVG und Bilder in andere Dateiformate zusammenführen:" >}}

{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-jpg/" name="JPG to JPG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-png/" name="JPG to PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-bmp/" name="JPG to BMP" description="Bitmap Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-gif/" name="JPG to GIF" description="Graphical Interchange Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/jpg-to-tiff/" name="JPG to TIFF" description="Tagged Image Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-png/" name="PNG TO PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-jpg/" name="PNG to JPG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-bmp/" name="PNG to BMP" description="Bitmap Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-gif/" name="PNG to GIF" description="Graphical Interchange Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/png-to-tiff/" name="PNG to TIFF" description="Tagged Image Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/gif-to-jpg/" name="GIF to JPG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/gif-to-png/" name="GIF to PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-pdf/" name="SVG TO PDF" description="Portable Document Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-xps/" name="SVG TO XPS" description="XML Paper Specifications" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-bmp/" name="SVG TO BMP" description="Bitmap Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-image/" name="SVG TO IMAGE" description="Image formats" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-jpeg/" name="SVG TO JPEG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-gif/" name="SVG TO GIF" description="Graphical Interchange Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-png/" name="SVG to PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/merger/svg-to-tiff/" name="SVG TO TIFF" description="Tagged Image Format" >}}

{{< /blocks/products/pf/agp/other-supported-section >}}
{{< /blocks/products/pf/main-container >}}
{{< /blocks/products/pf/main-wrap-class >}}