---
template: true
title: Konvertieren Sie SVG in gängige Formate mit C#
description: Konvertieren Sie SVG in PDF, XPS und Bilder mit wenigen Zeilen C#-Code über die .NET-Bibliothek.
url: /de/net/conversion/
---

{{< blocks/products/pf/main-wrap-class isAutogenPage="true">}}
{{< blocks/products/pf/feature-page-wrap >}}
{{< blocks/products/pf/feature-page-header h1="SVG-Konvertierung über C#"  h2="Konvertieren Sie SVG in PDF, XPS und Bilder, einschließlich BMP, JPEG, PNG, TIFF, um plattformübergreifende .NET-Anwendungen zu erstellen" >}}

{{% blocks/products/pf/feature-page-section  h2="So konvertieren Sie SVG mit C#" %}}

SVG (Scalable Vector Graphics) ist ein XML-basiertes Bildformat für zweidimensionale Grafiken. Es ist ein Vektorgrafikformat, das hauptsächlich für das Web gedacht ist. Die größte Stärke von SVG ist seine unübertroffene Fähigkeit, ohne Qualitätsverlust auf jede beliebige Größe skaliert zu werden. Alle modernen Browser unterstützen SVG, und es scheint, dass das Web bereits auf Vektorgrafiken umsteigen sollte. Es gibt jedoch einige Einschränkungen bei der Verwendung von SVG und manchmal müssen Sie SVG in andere Formate konvertieren.
 
 - Die statische [Converter-Klasse](https://reference.aspose.com/svg/net/aspose.svg.converters/converter/) ist eine gemeinsam genutzte Fassade, die SVG-Dateikonvertierungen in die gängigen Formate bereitstellt und diese Operationen ermöglicht bequem und einfach.

 - Die Methode [RenderTo()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/renderto/) wird verwendet, um SVG in ein anderes Format zu rendern und ein Dokument an das Ausgabegerät zu senden. Die Aspose.SVG-API bietet die folgende Implementierung von Ausgabegeräten: die Klassen PdfDevice, XpsDevice und ImageDevice, die das Rendern in PDF-, XPS- bzw. Bilddateiformate durchführen.

<a href="https://products.aspose.com/svg/net/" target="_blank">Aspose.SVG for .NET API</a> vereinfacht den Konvertierungsprozess für Entwickler. Die Konvertierung zwischen Formaten kann mithilfe einiger verschiedener Ansätze erfolgen:



<h2>SVG Converter Live-Demos</h2>

Sie können SVG mit Aspose.SVG für die .NET-API in Echtzeit konvertieren. Das folgende C#-Beispiel zeigt, wie ein SVG-Dokument konvertiert wird. Bitte laden Sie eine Datei aus dem lokalen Dateisystem, wählen Sie das Ausgabeformat und führen Sie das Beispiel aus. Das Ergebnis erhalten Sie sofort als separate Datei.



{{% /blocks/products/pf/feature-page-section %}}


{{< app/svg/converter SVG PDF BMP "JPG|JPEG" PNG GIF TIFF XPS>}}
using Aspose.Svg;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;

    using var document = new SVGDocument("input.{{input lower}}");
{{#if_output 'PDF'}}
    var options = new PdfSaveOptions();
{{/if_output}}
{{#if_output 'DOCX'}}
    var options = new DocSaveOptions();
{{/if_output}}
{{#if_output 'XPS'}}
    var options = new XpsSaveOptions();
{{/if_output}}
{{#if_output 'MD'}}
    var options = new MarkdownSaveOptions();
{{/if_output}}
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output camel}});
{{/if_output}}
    Converter.ConvertSVG(document, options, "output.{{output lower}}");
{{< /app/svg/converter>}}



{{% blocks/products/pf/feature-page-section  h2="Beliebte SVG-Konvertierungen in der Dokumentation" %}}

Mit der Bibliothek Aspose.SVG für .NET können Sie SVG-Dateien programmgesteuert mit C# erstellen, bearbeiten, lesen und konvertieren. Das wichtigste Highlight der SVG C# API ist eine Konvertierungsfunktion. Der Namespace [Aspose.SVG.Converters](https://reference.aspose.com/svg/net/aspose.svg.converters/) implementiert einen einfachen Zugriff auf Konvertierungsmethoden. Es bietet eine breite Palette von SVG-Konvertierungen in gängige Formate wie PDF, XPS, JPEG, PNG, BMP, TIFF und GIF. Bitte besuchen Sie das Dokumentationskapitel <a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/" target="_blank">How to Convert SVG-Dateien</a>, um mehr über die Konvertierungsfunktionen der SVG-C#-API zu erfahren.

<div>
	<ul>
		<li><a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/convert-svg-to-pdf/" target="_blank">Convert SVG to PDF</a></li>
		<li><a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/convert-svg-to-xps/" target="_blank">Convert SVG to XPS</a></li>
		<li><a href="https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/convert-svg-to-image/" target="_blank">Convert SVG to Image</a></li>							
	</ul>
</div>



 {{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="Aspose.SVG für die .NET-Bibliothek installieren" %}}

Aspose.SVG für .NET ist eine plattformübergreifende flexible Bibliothek, die entwickelt wurde, um eine breite Palette von Funktionen zum Verarbeiten und Rendern von SVG-Dokumenten bereitzustellen. Es lässt sich nahtlos in Ihre .NET-Apps integrieren, um mit SVG-Dateien zu arbeiten, ohne Software von Drittanbietern zu installieren. Unsere SVG .NET-API kann mit jeder .NET-Sprache wie C#, VB.NET, ASP.NET usw. verwendet werden. Sie funktioniert gleichermaßen gut auf jedem Betriebssystem, das Mono installieren (.NET 4.0 Framework-Unterstützung) oder .NET verwenden kann Ader. Dazu gehören Windows, Linux und macOS.

Installieren von <a href="https://www.nuget.org/packages/Aspose.SVG" target="_blank">Aspose.SVG für .NET über NuGet</a>:
1. Verwenden der Paket-Manager-Konsole.
1. Verwenden der NuGet Package Manager-GUI.



Weitere Einzelheiten zur Installation der C#-Bibliothek finden Sie in der [Aspose.SVG-Dokumentation](https://docs.aspose.com/svg/net/getting-started/installation/).



{{% /blocks/products/pf/feature-page-section %}}

{{% blocks/products/pf/feature-page-section  h2="Andere unterstützte Konvertierungen" %}}

Sie können SVG-Dateien auch in viele andere Dateiformate konvertieren, darunter einige, die unten aufgeführt sind:

{{% /blocks/products/pf/feature-page-section %}}
{{< /blocks/products/pf/feature-page-wrap >}}
{{< /blocks/products/pf/main-wrap-class >}}
{{< blocks/products/pf/feature-page-options pairs="svg-to-pdf svg-to-xps svg-to-bmp svg-to-png svg-to-jpeg svg-to-tiff svg-to-gif svg-to-image" >}}