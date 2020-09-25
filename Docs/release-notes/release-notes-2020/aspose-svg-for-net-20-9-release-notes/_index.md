---
title: Aspose.SVG for .NET 20.9 Release Notes
type: docs
weight: 23
url: /net/aspose-svg-for-net-20-9-release-notes/
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.SVG for .NET 20.9

{{% /alert %}}

## **Major Features**

As per the regular monthly update process of all APIs being offered by Aspose, we are honored to announce the June release of Aspose.SVG for .NET.
In this release we have added a new feature for "vectorization" of text elements inside SVG documents.  By the term "vectorization" we mean converting text into a set of graphic elements such as <path>, <g>, <use>, <rect>.  "Vectoryzation" is applied to a document in saving it with option VectorizeText = true. There are several reasons for using this feature. One of them is protecting intellectual property from grabbing of document  text and the other one is substitution of fonts that can not be shared. 

## **Public API changes:**

### **Added APIs:**

A new option VectorizeText was added to the class SVGSaveOptions:

{{< highlight csharp >}}

namespace Aspose.Svg.Saving
{
    /// <summary>
    /// Represents SVG save options.
    /// </summary>
    public class SVGSaveOptions : SaveOptions
    {
        /// <summary>
        /// Gets or sets whether text elements are replaced with paths.
        /// </summary>
        public bool VectorizeText { get; set; }
    }
}

{{< /highlight >}}

### **Changed APIs:**
### **Removed APIs:**