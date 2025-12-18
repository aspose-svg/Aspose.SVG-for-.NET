using Aspose.Svg;
using Aspose.Svg.Rendering.Image;

namespace CSharp.LoadSaveConvert
{
    public class SupportForHtmlContentInSVG
    {
        public static void Run()
        {
            //ExStart: 1
            string outputDir = RunExamples.GetDataDir_OutputConvert();

            string svgCode = "<svg viewBox='0 0 200 200' xmlns='http://www.w3.org/2000/svg'>" +
                "<style>" +
                "div {" +
                "color: white;" +
                "font: 18px serif;" +
                "height: 100%;" +
                "overflow: hidden;" +
                " }" +
                "</style>" +
                "<polygon points='5,5 195,10 185,185 10,195' />" +
                "<foreignObject x='20' y='20' width='160' height='160'>" +
                "<div xmlns='http://www.w3.org/1999/xhtml'>" +
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                "Sed mollis mollis mi ut ultricies. Nullam magna ipsum," +
                "porta vel dui convallis, rutrum imperdiet eros. Aliquam" +
                "erat volutpat." +
                "</div>" +
                "</foreignObject>" +
                "</svg>";


            using (var document = new SVGDocument(svgCode, "."))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Jpeg), outputDir + "SupportForHtmlContentInSVG_out.jpg"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: 1
        }
    }
}
