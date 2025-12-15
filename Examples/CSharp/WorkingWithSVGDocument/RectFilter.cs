using Aspose.Svg.Dom;
using Aspose.Svg.Dom.Traversal.Filters;

namespace CSharp.WorkingWithSVGDocument
{
    class RectFilter : NodeFilter
    {
        public override short AcceptNode(Node n)
        {
            return string.Equals("rect", n.NodeName)
                ? FILTER_ACCEPT
                : FILTER_REJECT;
        }
    }
}
