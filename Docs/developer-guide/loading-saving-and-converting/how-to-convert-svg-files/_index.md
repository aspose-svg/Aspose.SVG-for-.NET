---
title: How to Convert SVG Files
type: docs
weight: 30
url: /net/how-to-convert-svg-files/
---

Aspose.SVG for .NET API can read and convert [SVG](https://wiki.fileformat.com/specification/page-description-language/svg/) Image files to several different file formats. You can use it in your C# or any other .NET application (such as VB.NET) to develop converter applications without getting into the details fo underlying file formats. You can use the API to convert an SVG file to [PNG](https://wiki.fileformat.com/image/png/), [JPEG](https://wiki.fileformat.com/image/jpeg/), [XPS](https://wiki.fileformat.com/specification/page-description-language/xps/), [PDF](https://wiki.fileformat.com/view/pdf/), [BMP](https://wiki.fileformat.com/image/bmp/), [GIF](https://wiki.fileformat.com/image/gif/), and [TIFF](https://wiki.fileformat.com/image/tiff/) file formats.
## **Convert SVG to PDF in C#**
Aspose.SVG for .NET can convert SVG files to PDF in your .NET applications. [PDF](https://wiki.fileformat.com/view/pdf/) is a widely used document format that supports text, images, multimedia, and other media types. Modern document management systems use PDF as the format of choice for archiving files.

The following code sample can be used to convert an SVG file to PDF.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGToPDF-ConvertSVGToPDF.cs" >}}
## **Convert SVG to XPS**
Aspose.SVG for .NET lets you read and convert SVG files to [XPS](https://wiki.fileformat.com/page-description-language/xps/) using C# and other .NET programming languages. XPS (XML Paper Specification) files are page layout files that use XML in layout, appearance and printing information of a document.

The following code sample shows how to convert SVG to XPS file format.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGToXPS-ConvertSVGToXPS.cs" >}}
## **Convert SVG to Image**
### **Convert SVG to JPEG**
A [JPEG](https://wiki.fileformat.com/image/jpeg/) image is a compressed file that uses lossy compression to reduce the image file size while compromising on the image quality. The compression level of the image can be adjusted to achieve the desired quality level while at the same time reduce the storage size. A higher compression value results in higher degradation of the image quality.

Aspose.SVG for .NET API offers the capability to convert SVG images to JPEG format in your .NET applications. The API has a simple interface to render SVG files to different image file formats.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGToImage-ConvertSVGToJPEG.cs" >}}
### **Convert SVG to PNG**
{{% alert color="primary" %}}

https://products.aspose.app/svg/conversion/svg-to-png

{{% /alert %}}
[PNG](https://wiki.fileformat.com/image/png/) (Portable Network Formats) has been the image format of choice as a replacement of GIF format with lossless compression. It doesn't support animations unlike GIF but has gained popularity due to its lossless compression among its users. It is supported by almost all operating systems such as Microsoft Windows and macOS.

Aspose.SVG for .NET API has the capability to read and convert SVG files to PNG file format using C# and other .NET programming languages. 

# **How to convert SVG to PNG using the [ConvertSVG](https://apireference.aspose.com/svg/net/aspose.svg.converters.converter/convertsvg/methods/1) method of the [Converter](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter) class.** 
1. Initially we create a SVG sample and save it to a file.
1. A new instance of the [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) class is created from the SVG file.
1. We specify PNG [ImageFormat](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imageformat) using an instance of the [ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions) class.
1. Then we call the Converter.ConvertSVG method, which converts SVG to PGN.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGToImage-ConvertSVGToPNGFromFile.cs" >}}

# **How to convert SVG to PNG using rendering on [ImageDeivece](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice).** 
1. We create a SVG sample and save it to string variable.
1. A new instance of the SVGDocument class is created from the string source.
1. In the next step, we create an instance of the ImageDeivice class. The constructor of this device accepts [ImageRendering](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions) options that determine the rendering process and the result file.
1. The SVG document is rendered to the PGN output file.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGToImage-ConvertSVGToPNGFromString.cs" >}}

### **Convert SVG to BMP**
Aspose.SVG for .NET (C#, VB.NET) lets you convert your SVG files to rasterized Bitmaps using a couple of lines of code. Bitmap files have been known for long as these were the initial image file formats and were widely used for graphical representation and storing images. With the passage of time, other image file formats have replaced [.bmp](https://wiki.fileformat.com/image/bmp/) files based on the file size and quality.

The following code sample shows how to use Aspose.SVG API to convert SVG to BMP file format.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGToImage-ConvertSVGToBMP.cs" >}}
### **Convert SVG to GIF**
Aspose.SVG for .NET API offers to convert SVG to [GIF](https://wiki.fileformat.com/image/gif/) image which is a type of highly compressed image. GIF compresses images using the LZW compression algorithm that keeps the image quality better. It also supports animation by combining numerous images or frames into a single file and display them in sequence.

The following lines of code show how to convert SVG to GIF files using Aspose.SVG for .NET.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGToImage-ConvertSVGToGIF.cs" >}}
### **Convert SVG to TIFF**
Aspose.SVG for .NET can convert SVG to [TIFF](https://wiki.fileformat.com/image/tiff/) (Tagged Image File Format) file formats using C# or any other .NET language. TIFF files are raster images that describe bilevel, grayscale, palette-color and full-color image data in several color spaces. It supports lossy as well as lossless compression schemes to choose between space and time for applications using the format. 

The following code sample shows how to convert SVG to TIFF using Aspose.SVG for .NET.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGToImage-ConvertSVGToTIFF.cs" >}}
### **Convert SVG files with Rendering Options**
The example below shows how to use Rendering Options object in order to specify the output result properties, such as page size, page margins, resolution, image quality, etc..

{{< highlight java >}}

 using (var document = new SVGDocument(Path.Combine(DataPath, "smiley.svg")))

{

    using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Tiff), "smiley.Tiff"))

    {

        document.RenderTo(device);

    }

}

{{< /highlight >}}
## **Convert SVG Documents Using Renderer**
Aspose.SVG for .NET can render SVG documents to different formats using SVGRenderer class. This class is generic in nature where rendering parameters can be set and loaded SVG document can be rendered to desired rendering device. The following code sample shows the usage of SVGRenderer class for converting SVG documents to XPS.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-ConvertSVGFilesUsingRenderer-ConvertSVGFilesUsingRenderer.cs" >}}
### **Rendering Options**
To facilitate users setting additional options for rendering SVG documents, the XpsRenderingOptions can be used to specify additional settings such as Page Setup and Background color as shown in the code sample below.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-RenderingOptions-RenderingOptions.cs" >}}
