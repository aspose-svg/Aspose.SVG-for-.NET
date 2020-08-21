---
title: Aspose.SVG for .NET 20.8 Release Notes
type: docs
weight: 24
url: /net/aspose-svg-for-net-20-8-release-notes/
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.SVG for .NET 20.8

{{% /alert %}}

## **Major Features**

As per the regular monthly update process of all APIs being offered by Aspose, we are honored to announce the June release of Aspose.SVG for .NET.
In this release we have made the number of improvements:

- Added support for the comp-op property with the following list of values :  hue, saturation, color, luminosity;
- Fixed problem with processing units in methods GetCTM and GetScreenCTM in all classes inherited from SVGGraphicsElement class;
- Added support for calculating bounding boxes of non-shaped elements (SVGTextElement, SVGTSpanElement) inside the method GetBBox of  SVGGraphicsElement class.
- Fixed issue in pattern painting coordinate system.

## **Public API changes:**

### **Added APIs:**

Several new modes were added to SVGFEBlendElement class:

{{< highlight csharp >}}

namespace Aspose.Svg.Filters
{
    /// <summary>
    /// The SVGFEBlendElement interface corresponds to the ‘feBlend’ element.
    /// </summary>
    public class SVGFEBlendElement : SVGElement, ISVGFilterPrimitiveStandardAttributes
    {
        /// <summary>
        /// Corresponds to value 'hue'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_HUE = 13;
        /// <summary>
        /// Corresponds to value 'saturation'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_SATURATION = 14;
        /// <summary>
        /// Corresponds to value 'color'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_COLOR = 15;
        /// <summary>
        /// Corresponds to value 'luminosity'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_LUMINOSITY = 16;

    }
}

{{< /highlight >}}

### **Changed APIs:**

We have changed vales of the modes in SVGFEBlendElement class according to specification [W3C](https://www.w3.org/TR/filter-effects-1/#InterfaceSVGFEBlendElement):

{{< highlight csharp >}}

namespace Aspose.Svg.Filters
{
    /// <summary>
    /// The SVGFEBlendElement interface corresponds to the ‘feBlend’ element.
    /// </summary>
    public class SVGFEBlendElement : SVGElement, ISVGFilterPrimitiveStandardAttributes
    {
        /// <summary>
        /// Corresponds to value 'overlay'.
        /// <summary>
        public const ushort SVG_FEBLEND_MODE_OVERLAY = 6;
        /// <summary>
        /// Corresponds to value 'color_dodge'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_COLOR_DODGE = 7;
        /// <summary>
        /// Corresponds to value 'color_burn'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_COLOR_BURN = 8;
        /// <summary>
        /// Corresponds to value 'hard_light'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_HARD_LIGHT = 9;
        /// <summary>
        /// Corresponds to value 'soft_light'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_SOFT_LIGHT = 10;
        /// <summary>
        /// Corresponds to value 'difference'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_DIFFERENCE = 11;
        /// <summary>
        /// Corresponds to value 'exclusion'.
        /// </summary>
        public const ushort SVG_FEBLEND_MODE_EXCLUSION = 12;
    }
}

{{< /highlight >}}

### **Removed APIs:**

The next modes were remove from SVGFEBlendElement class according to specification [W3C](https://www.w3.org/TR/filter-effects-1/#InterfaceSVGFEBlendElement):

{{< highlight csharp >}}

namespace Aspose.Svg.Filters
{
    /// <summary>
    /// The SVGFEBlendElement interface corresponds to the ‘feBlend’ element.
    /// </summary>
    public class SVGFEBlendElement : SVGElement, ISVGFilterPrimitiveStandardAttributes
    {
         /// Corresponds to value 'clear'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_CLEAR =6;
         /// <summary>
         /// Corresponds to value 'src'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_SRC = 7;
         /// <summary>
         /// Corresponds to value 'dst'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_DST =8;
         /// <summary>
         /// Corresponds to value 'src-over'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_SRC_OVER =9;
         /// <summary>
         /// Corresponds to value 'dst-over'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_DST_OVER =10;
         /// <summary>
         /// Corresponds to value 'src-in'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_SRC_IN =11;
         /// <summary>
         /// Corresponds to value 'dst-in'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_DST_IN =12;
         /// <summary>
         /// Corresponds to value 'src-out'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_SRC_OUT =13;
         /// <summary>
         /// Corresponds to value 'dst-out'.
         /// </summary>
         public const ushort SVG_FEBLEND_MODE_DST_OUT =14;
         /// Corresponds to value 'src-atop'.
         public const ushort SVG_FEBLEND_MODE_SRC_ATOP =15;
         /// <summary>
         /// Corresponds to value 'dst-atop'.
         public const ushort SVG_FEBLEND_MODE_DST_ATOP =16;
         /// <summary>
         /// Corresponds to value 'xor'.
         public const ushort SVG_FEBLEND_MODE_XOR =17;
         /// <summary>
         /// Corresponds to value 'plus'.
         public const ushort SVG_FEBLEND_MODE_PLUS =18;
         /// <summary>
    }
}

{{< /highlight >}}
