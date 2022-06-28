---
template: true
title: Konvertieren Sie SVG in GIF mit .NET Core
description: Laden und konvertieren Sie SVG in GIF mit der .NET Core-API unter Windows, macOS und Linux
url: /de/net/conversion/svg-to-gif/
family: svg
platformtag: net
feature: conversion
informat: SVG
outformat: BMP
otherformats: GIF JPEG PNG TIFF 
---
<!-- template1.md -->

{{< blocks/products/pf/main-wrap-class isAutogenPage="true" >}}

{{< blocks/products/pf/upper-banner h1="Konvertieren Sie SVG in GIF über C#" h2="Hochgeschwindigkeits-.NET-API zum Konvertieren von SVG in GIF unter Windows, macOS und Linux" logoImageSrc="https://www.aspose.cloud/templates/aspose/img/products/svg/headers/aspose_svg-for-net.svg" pfName="Aspose.SVG " subTitlepfName="for .NET" downloadUrl="https://downloads.aspose.com/svg/net" >}}

{{< blocks/products/pf/main-container >}}

{{% blocks/products/pf/agp/content h2="SVG-zu-GIF-Konvertierung über .NET Core" %}}

SVG ist eines der am häufigsten verwendeten Formate zum Erstellen von Websites und zum Drucken von Grafiken, um Skalierbarkeit zu erreichen. Aber manchmal müssen Sie SVG konvertieren und in einem gängigen Rasterbildformat speichern. Mit der API [Aspose.SVG for .NET](https://products.aspose.com/svg/net/) können Sie SVG programmgesteuert in das GIF-Format umwandeln, wobei Sie die volle Kontrolle über eine Vielzahl von Konvertierungsparametern haben. Mit der leistungsstarken C#-API können Sie SVG mit hoher Geschwindigkeit und hoher Qualität in gängige Formate konvertieren.



<br>

<h2>Kostenlose Online-Konverter-Live-Demos</h2>

Testen Sie die Qualität der Umwandlung von SVG in GIF direkt in Ihrem Browser! Das folgende C#-Beispiel zeigt, wie ein SVG-Dokument mithilfe der ConvertSVG()-Methode konvertiert wird. Wir beschreiben den Quellcode zum Lesen von SVG aus einer Datei und zum anschließenden Konvertieren von SVG in GIF mit Standardspeicheroptionen. Bitte laden Sie SVG aus dem lokalen Dateisystem, wählen Sie das Ausgabeformat und führen Sie das Beispiel aus. Das Ergebnis erhalten Sie sofort als separate Datei.



{{% /blocks/products/pf/agp/content %}}


{{< app/svg/converter SVG GIF BMP XPS TIFF PNG PDF "JPG|JPEG" >}}
using Aspose.Svg;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;
using Aspose.Svg.Rendering.Image;

    using var document = new SVGDocument("image.svg");
{{#if_output 'PDF'}}
    var options = new PdfSaveOptions();
{{/if_output}}
{{#if_output 'XPS'}}
    var options = new XpsSaveOptions();
{{/if_output}}
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output param2 camel}});
{{/if_output}}
    Converter.ConvertSVG(document, options, "output.{{output lower}}");   
{{< /app/svg/converter>}} 

 

{{% blocks/products/pf/agp/content %}}


Bitte besuchen Sie <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/" target="_blank">unsere Dokumentation</a> um mehr über die Verwendung von Aspose.SVG-API-Konvertierungsfunktionen zu erfahren und C#-Beispiele für die gängigsten SVG-Konvertierungsszenarien zu betrachten. Im Dokumentationsartikel <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/convert-svg-to-image/" target="_blank ">SVG in Bild umwandeln</a> können Sie C#-Beispiele betrachten, wie Sie SVG auf unterschiedliche Weise in Bilder umwandeln können. Betrachten wir einige davon:


<br>

<h2>Schritte zum Konvertieren von SVG in GIF mit der ConvertSVG()-Methode</h2>

1. Laden Sie eine SVG-Datei mit einem der SVGDocument()-Konstruktoren der [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument)-Klasse.
1. Erstellen Sie ein neues [ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions)-Objekt mit GIF ImageFormat. Standardmäßig ist die Eigenschaft „Format“ PNG.
1. Verwenden Sie die Methode [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/convertsvg/), um SVG als GIF-Bild zu speichern. Sie müssen das SVGDocument, die ImageSaveOptions und den Pfad der Ausgabedatei an die Methode ConvertSVG() übergeben.
1. Die GIF-Datei wird im angegebenen Pfad gespeichert.




<br>

<h2>Schritte zum Konvertieren von SVG in GIF mit der RenderTo()-Methode</h2>

1. Initialisieren Sie [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) mit Ihrer SVG-Datei.
1. Erstellen Sie ein Objekt der ImageRenderingOptions-Klasse. Verwenden Sie den Konstruktor [ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1) und geben Sie die Eigenschaft „Format“ des Dokuments an.
1. Initialisieren Sie die Klasse [ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice) und geben Sie den zu rendernden Ausgabedateinamen an.
1. Rufen Sie die Methode [RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) auf und übergeben Sie die Instanz von ImageDevice.





{{% blocks/products/pf/agp/code-block title="Konvertieren Sie SVG in GIF" offSpacer="true" %}}


```cs
using (var document = new SVGDocument("input.svg"))
{
	var options = new ImageRenderingOptions(ImageFormat.Gif);
	using (IDevice device = new ImageDevice(options, "output.gif"))
	{
		document.RenderTo(device);                    
	}
}
```

 

{{% /blocks/products/pf/agp/code-block %}}

{{% /blocks/products/pf/agp/content %}}

{{% blocks/products/pf/agp/content h2="Erste Schritte mit der .NET SVG-API" %}}

Installieren Sie von der Befehlszeile als ```nuget install Aspose.SVG``` oder über die Package Manager Console von Visual Studio mit ```Install-Package Aspose.SVG```.
Alternativ können Sie das Offline-MSI-Installationsprogramm oder DLLs in einer ZIP-Datei von [downloads](https://downloads.aspose.com/svg/net) herunterladen. Aspose.SVG für .NET API ist eine eigenständige Bibliothek und hängt von keiner Software für die Verarbeitung von SVG-Dokumenten ab.
 Weitere Einzelheiten zur Installation der C#-Bibliothek und zu den Systemanforderungen finden Sie in der [Aspose.SVG-Dokumentation](https://docs.aspose.com/svg/net/getting-started/).



{{% /blocks/products/pf/agp/content %}}

{{< blocks/products/pf/agp/other-supported-section title="Andere unterstützte SVG-Konvertierungen" subTitle="Sie können SVG auch in viele andere Dateiformate konvertieren:" >}}

{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-pdf/" name="SVG TO PDF" description="Portable Document Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-xps/" name="SVG TO XPS" description="XML Paper Specifications" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-bmp/" name="SVG TO BMP" description="Bitmap Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-image/" name="SVG TO IMAGE" description="Image formats" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-jpeg/" name="SVG TO JPEG" description="JPEG Image" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-gif/" name="SVG TO GIF" description="Graphical Interchange Format" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-png/" name="SVG TO PNG" description="Portable Network Graphics" >}}
{{< blocks/products/pf/agp/other-supported-section-item href="https://products.aspose.com/svg/net/conversion/svg-to-tiff/" name="SVG TO TIFF" description="Tagged Image Format" >}}

{{< /blocks/products/pf/agp/other-supported-section >}}
{{< /blocks/products/pf/main-container >}}
{{< /blocks/products/pf/main-wrap-class >}}