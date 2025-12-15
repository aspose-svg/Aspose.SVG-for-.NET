# Create and Read SVG Documents

Aspose.SVG for .NET API lets you create an SVG document from scratch as well as load an existing SVG from different sources. An SVG document can be loaded from disc, user-provided string or a URL referring to the XML file.  This article demonstrates the usage of API for creating and loading SVG files in your .NET applications.

## **Create an SVG Document using C#**

The API provides the SVGDocument class to create an SVG document file in your .NET applications. SVG files can be created:

- From scratch as an empty document with SVG structure
- From User-Provided string

### **Create an Empty SVG Document**

Aspose.SVG for .NET API provides the [**SVGDocument**](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/) class that can be used to create an empty document using its default constructor. Once the document object is created, it can be filled later with SVG elements. The following code snippet shows the usage of the default constructor of [**SVGDocument**](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/) class to create an SVG Document.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-CreateEmptySVGDocument-CreateEmptySVGDocument.cs" >}}

### **Create SVG from User-Defined String**

If your case is to create a document from a user string directly in your code, the following example could help you:

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-CreateSVGDocumentFromContent-CreateSVGDocumentFromContent.cs" >}}

## **Read SVG Document in C#**

Aspose.SVG API not only provides the capability to create new SVG documents, but it also lets you read existing SVG documents from a variety of sources. The overloaded constructors provided by the API provides different methods to load SVG files.

### **Read SVG File from Disc**

To load an SVG file from disc, use the default constructor of the [**SVGDocument**](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/) class and pass the document path as the input parameter to it.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-LoadSVGDocumentFromFile-LoadDocumentFromFile.cs" >}}

### **Read SVG File from Remote Server**

You can also load an SVG file hosted on a remote server using the URL of the image as shown below.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-LoadSVGDocumentFromUrl-LoadDocumentFromUrl.cs" >}}

{{% alert color="primary" %}} 

If you set a wrong URL that can't be reached right at this moment, the library throws the DOMException with specialized code 'NetworkError' to inform that selected resource can not be found.

{{% /alert %}}

### **Reading SVG with Resources Async**

If the SVG to load contains external resources, it may take time to load all resources completely and, hence, resulting in blocking of the main application thread. In an Async model, the Load and ReadyStateChange events can be subscribed to notify the loading application for complete loading of the SVG file as shown in the following code sample.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-LoadSVGDocumentAsync-LoadSVGDocumentAsync.cs" >}}