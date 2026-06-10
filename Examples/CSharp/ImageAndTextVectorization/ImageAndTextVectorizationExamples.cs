using System;

namespace CSharp.ImageAndTextVectorization
{
    public class ImageAndTextVectorizationExamples
    {
        public static void RunAll()
        {
            // Run all Image and Text Vectorization examples from one place.
            // Users can comment out individual calls below when they want to focus on one scenario.
            Console.WriteLine("Running ImageAndTextVectorization examples...");

            ImageVectorization.Run();
            ImageStencil.Run();
            TextVectorization.Run();

            Console.WriteLine("ImageAndTextVectorization examples finished.");
        }
    }
}
