# Licensing and Subscription – Aspose.SVG for .NET

## Evaluation Version Limitations

A free evaluation version of Aspose.SVG for .NET can be downloaded from the downloads section of Aspose’s website at: [Download Aspose.SVG API](https://releases.aspose.com/svg/net/).

### Limitation
The evaluation version provides all the features except the following:

- Watermark is added to the output files.
- Only the first four pages of the SVG document can be converted.
- Only 50% of SVG Document’s nodes will be saved during serialization.

If you want to try Aspose.SVG without evaluation limitations, request a 30 day temporary license. Please refer to [How to get a Temporary License?](https://purchase.aspose.com/temporary-license/) for more information.

## Apply License using File or Stream Object

The license can be loaded from a [file](https://docs.aspose.com/svg/net/licensing/#loading-a-license-from-file) or [stream object](https://docs.aspose.com/svg/net/licensing/#loading-a-license-from-a-stream-object).

The easiest way to apply a license is to put the license file in the same folder as the Aspose.SVG.dll file and specify just the file name without a path.

```c#
// Initialize a license object
Aspose.Svg.License svgLicense = new Aspose.Svg.License();

// Apply the license using a file name
svgLicense.SetLicense("Aspose.SVG.lic");
```

## Apply Metered License

Aspose.SVG for .NET API allows developers to apply the metered license. It is a new licensing mechanism. The new licensing mechanism will be used along with the existing licensing method. Those customers who want to be billed based on the usage of the API features can use the metered licensing. For more details, please refer to [Metered Licensing FAQ](http://www.aspose.com/corporate/purchase/policies/Licensing-Faqs/metered-faq.aspx) section.

A new class [Metered](https://apireference.aspose.com/svg/net/aspose.svg/metered) has been added to apply the metered key. This code example demonstrates how to set metered public and private keys:

```c#
// Initialize a metered object
Aspose.Svg.Metered metered = new Aspose.Svg.Metered();

// Apply the metered license using the public and private keys
metered.SetMeteredKey("*****", "*****");
```

For more information on how to apply a license for Aspose.SVG for .NET, please see the official documentation article [**Licensing – Aspose.SVG for .NET**](https://docs.aspose.com/svg/net/getting-started/licensing/).