using Aspose.Svg;
using Aspose.Svg.Dom;
using System;
using System.IO;

namespace CSharp.WorkingWithSVGDocument
{
    class TraverseSVGElement
    {
        public static void Run()
        {
            TraverseFromRootToChild();
            TraverseElementChildren();
            TraverseSiblingElements();
        }

        public static void TraverseFromRootToChild()
        {
            // Traverse SVG elements with the Aspose.SVG for .NET DOM API.
            // This example navigates from the root <svg> element to nested child elements.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "paths.svg")))
            {
                var element = document.DocumentElement;
                Console.WriteLine(element.TagName);

                element = element.FirstElementChild;
                Console.WriteLine(element.TagName);

                element = element.FirstElementChild;
                Console.WriteLine(element.TagName);
            }
        }

        public static void TraverseElementChildren()
        {
            // Iterate through direct child elements of an SVG root element.
            // Element.Children exposes element nodes without text/comment nodes.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "basic-shapes.svg")))
            {
                foreach (Element child in document.RootElement.Children)
                {
                    Console.WriteLine(child.TagName);
                }
            }
        }

        public static void TraverseSiblingElements()
        {
            // Traverse sibling SVG elements using FirstElementChild and NextElementSibling.
            // This is useful when walking SVG markup in document order.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes_svg.svg")))
            {
                Element current = document.RootElement.FirstElementChild?.FirstElementChild;

                while (current != null)
                {
                    Console.WriteLine(current.TagName);
                    current = current.NextElementSibling;
                }
            }
        }
    }
}
