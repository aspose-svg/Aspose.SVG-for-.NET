---
title: Aspose.SVG for .NET 20.5 Release Notes
type: docs
weight: 27
url: /net/aspose-svg-for-net-20-5-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.SVG for .NET 20.5

{{% /alert %}} 
## **Major Features**

As per the regular monthly update process of all APIs being offered by Aspose, we are honored to announce the May release of Aspose.SVG for .NET.
In this release we have made the following improvements:

- updated processing of many CSS properties according to the latest documentation;
- made some usability improvements, like, clarified the URL parsing exceptions and added new signatures to the Document creation methods. 

# **Public API changes:**
## **Added APIs:**
We have added new signatures to the Document creation methods. Now you can specify a base URL using the Aspose.Svg.Url class.

{{< highlight java >}}
namespace Aspose.SVG.Dom
{
    public class Document : Node, IDocumentTraversal, IXPathEvaluator, IDocumentEvent, IParentNode, INonElementParentNode, IDocumentStyle, IGlobalEventHandlers
    {
        /// <summary>
        /// Loads the document from specified content and using baseUri to resolve relative resources, replacing the previous content.
        /// </summary>
        /// <param name="content">The document content.</param>
        /// <param name="baseUri">The base URI to resolve relative resources.</param>
        /// <exception cref="ArgumentNullException"><c>baseUri</c> is <c>null</c>.</exception>
        public void Navigate(string content, Url baseUri);

        /// <summary>
        /// Loads the document from specified content and using baseUri to resolve relative resources, replacing the previous content.
        /// </summary>
        /// <param name="content">The document content.</param>
        /// <param name="baseUri">The base URI to resolve relative resources.</param>
        /// <exception cref="ArgumentNullException"><c>baseUri</c> is <c>null</c>.</exception>
        public void Navigate(Stream content, Url baseUri);
    }
}

namespace Aspose.Svg
{
    public class SVGDocument : Document, IDocumentCSS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SVGDocument"/> class. Constructor works synchronously, it waits for loading of all the external resources (images, scripts, etc.).
        /// To load document asynchronously use method <see cref="Document.Navigate(string, Url)"/> or its overloads.
        /// Or you can disable loading of some external resources by setting appropriate flags in <see cref="IBrowsingContext.Security"/>.
        /// </summary>
        /// <param name="content">The document content.</param>
        /// <param name="baseUri">The base URI of the document.</param>
        /// <exception cref="ArgumentNullException"><c>baseUri</c> is <c>null</c>.</exception>
        public SVGDocument(string content, Url baseUri);

        /// <summary>
        /// Initializes a new instance of the <see cref="SVGDocument"/> class. Constructor works synchronously, it waits for loading of all the external resources (images, scripts, etc.).
        /// To load document asynchronously use method <see cref="Document.Navigate(string, Url)"/> or its overloads.
        /// Or you can disable loading of some external resources by setting appropriate flags in <see cref="IBrowsingContext.Security"/>.
        /// </summary>
        /// <param name="content">The document content.</param>
        /// <param name="baseUri">The base URI of the document.</param>
        /// <param name="configuration">The environment configuration.</param>
        /// <exception cref="ArgumentNullException"><c>baseUri</c> is <c>null</c>.</exception>
        public SVGDocument(string content, Url baseUri, Configuration configuration);

        /// <summary>
        /// Initializes a new instance of the <see cref="SVGDocument"/> class. Constructor works synchronously, it waits for loading of all the external resources (images, scripts, etc.).
        /// To load document asynchronously use method <see cref="Document.Navigate(Stream, Url)"/> or its overloads.
        /// Or you can disable loading of some external resources by setting appropriate flags in <see cref="IBrowsingContext.Security"/>.
        /// </summary>
        /// <param name="content">The document content.</param>
        /// <param name="baseUri">The base URI of the document.</param>
        /// <exception cref="ArgumentNullException"><c>baseUri</c> is <c>null</c>.</exception>
        public SVGDocument(Stream content, Url baseUri);

        /// <summary>
        /// Initializes a new instance of the <see cref="SVGDocument"/> class. Constructor works synchronously, it waits for loading of all the external resources (images, scripts, etc.).
        /// To load document asynchronously use method <see cref="Document.Navigate(Stream, Url)"/> or its overloads.
        /// Or you can disable loading of some external resources by setting appropriate flags in <see cref="IBrowsingContext.Security"/>.
        /// </summary>
        /// <param name="content">The document content.</param>
        /// <param name="baseUri">The base URI of the document.</param>
        /// <param name="configuration">The environment configuration.</param>
        /// <exception cref="ArgumentNullException"><c>baseUri</c> is <c>null</c>.</exception>
        public SVGDocument(Stream content, Url baseUri, Configuration configuration);
    }
}
Added new service IRuntimeService, which provides JavaScriptTimeout property, that allows you to specify JavaScript processing timeout. It can be used to speed up the rendering process or to stop the execution of infinite JavaScripts.

namespace Aspose.Svg.Services
{
    /// <summary>
    /// This service is used to configure runtime related properties.
    /// </summary>
    public interface IRuntimeService : IService
    {
        /// <summary>
        /// Gets or sets <see cref="TimeSpan"/> which limits JavaScript execution time. If script is executed longer than provided <see cref="TimeSpan"/>, it will be cancelled. You can specify infinite timeout by setting <see cref="TimeSpan"/> equal to -1 millisecond. Default value is 1 minute.
        /// </summary>
        TimeSpan JavaScriptTimeout { get; set; }
    }
}
{{< /highlight >}}
We have also added the empty constructor to the ImageSaveOptions class.

{{< highlight java >}}
namespace Aspose.Svg.Saving
{
    public class ImageSaveOptions : ImageRenderingOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveOptions"/> class; <see cref="ImageFormat.Png"/> will be used as default image format.
        /// </summary>
        public ImageSaveOptions();
    }
}
{{< /highlight >}}
 
## **Removed APIs:**
No change

