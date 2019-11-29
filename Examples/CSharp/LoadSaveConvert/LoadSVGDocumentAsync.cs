using Aspose.Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class LoadSVGDocumentAsync
    {
        public static void Run()
        {
            //ExStart: LoadSVGDocumentAsync
            var document = new SVGDocument();
            var @event = new ManualResetEvent(false);

            // Subscribes to the event 'OnReadyStateChange' that will be fired once document is completely loaded
            document.OnReadyStateChange += (sender, ev) =>
            {
                if (document.ReadyState == "complete")
                {
                    // Sets the state of the event to signaled to unblock the main thread
                    @event.Set();
                }
            };
            document.Navigate("http://www1.plurib.us/1shot/2008/circle_design/circles_single.svg");

            // Blocks the current thread while the document is loading
            @event.WaitOne();
            //ExEnd: LoadSVGDocumentAsync
        }
    }
}
