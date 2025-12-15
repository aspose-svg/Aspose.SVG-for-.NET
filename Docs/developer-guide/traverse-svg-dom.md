---
title: Traverse SVG DOM
type: docs
weight: 20
url: /net/traverse-svg-dom/
---

Aspose.SVG for .NET API is fully compatible with official SVG specifications and you can use the API to traverse the SVG Document Object Model (DOM) using it. The API supports a wide range of navigation functionality and inspection of the SVG contents. 
## **View SVG Content**
The easiest way to inspect the document content is just to look at content as a string. The methods 'InnerHTML' and 'OuterHTML' is developed exactly for this purpose:

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-WorkingWithSVGDocument-ViewDocumentContentAsString-ViewDocumentContentAsString.cs" >}}
## **Traverse Document and Elements of SVG**
Aspose.SVG contains a list of methods that are based on the Element & Document Traversal Specifications. You can perform a detailed inspection of the document and its elements using the API. The following code samples show the generalized usage of Element Traversal features.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-WorkingWithSVGDocument-TraverseSVGElement-TraverseSVGElement.cs" >}}
### **Extract Information about Specific Element**
The following example shows how to extract information about a particular element from the SVG file.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-WorkingWithSVGDocument-InspectDocumentContent-InspectDocumentContent.cs" >}}
### **Iterating Over Document Elements using Custom Filters**
You can also define custom filters and use them for iterating over the document elements as shown in the following code sample.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-WorkingWithSVGDocument-NodeIterator-NodeIterator.cs" >}}

where the RectFilter class is defined as follow:



{{< highlight java >}}

 class RectFilter : NodeFilter

{

    public override short AcceptNode(Node n)

    {

        return string.Equals("rect", n.NodeName)

            ? FILTER_ACCEPT

            : FILTER_REJECT;

    }

}

{{< /highlight >}}
### **Using XPath Query**
Aspose.SVG also has powerful XPath Specifications implementation along with Traversal Specifications. This empowers you to use XPath Query to navigate over the document as shown in the following code sample.



{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-WorkingWithSVGDocument-XPathQuery-XPathQuery.cs" >}}
### **Using CSS Selector**
Aspose.SVG for .NET also implements CSS Selector specification that allows you to navigate over the document by using CSS like style. The following code sample demonstrates this feature.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-WorkingWithSVGDocument-CSSSelector-CSSSelector.cs" >}}





