---
title: Aspose.SVG for .NET 20.6 Release Notes
type: docs
weight: 26
url: /net/aspose-svg-for-net-20-6-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.SVG for .NET 20.6

{{% /alert %}} 
## **Major Features**
As per the regular monthly update process of all APIs being offered by Aspose, we are honored to announce the June release of Aspose.SVG for .NET.
In this release we have made the following improvement:
- Support for rendering (X)HTML content inside of the <foreignObject> SVG elements was added. This new feature enables correct rendering of the HTML and XHTML elements embedded into SVG document (during conversion to supported formats). See an example of such SVG document below.
{{< highlight java >}}
<svg viewBox="0 0 200 200" xmlns="http://www.w3.org/2000/svg">
  <style>
    div {
      color: white;
      font: 18px serif;
      height: 100%;
      overflow: hidden;
    }
  </style>
 
  <polygon points="5,5 195,10 185,185 10,195" />

  <!-- Common use case: embed HTML text into SVG -->
  <foreignObject x="20" y="20" width="160" height="160">
    <!--
      In the context of SVG embedded in an HTML document, the XHTML 
      namespace could be omitted, but it is mandatory in the 
      context of an SVG document
    -->
    <div xmlns="http://www.w3.org/1999/xhtml">
      Lorem ipsum dolor sit amet, consectetur adipiscing elit.
      Sed mollis mollis mi ut ultricies. Nullam magna ipsum,
      porta vel dui convallis, rutrum imperdiet eros. Aliquam
      erat volutpat.
    </div>
  </foreignObject>
</svg>
{{< /highlight >}}
# **Public API changes:**
## **Added APIs:**
No change

## **Removed APIs:**
No change

