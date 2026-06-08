using Aspose.Svg;
using Aspose.Svg.Saving;
using Aspose.Svg.Saving.ResourceHandlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace CSharp.WorkingWithSVGDocument
{
    class SaveSVGDocumentExamples
    {
        public static void Run()
        {
            SaveSVGDocumentToUrl();
            SaveSVGDocumentToFile();
            SaveSVGDocumentToSVGZ();
            SaveSVGDocumentToUrlAsSVGZ();
            SaveSVGZDocumentToSVG();
            SaveMultipleSVGZDocumentsToSVG();
            SaveSVGWithExternalResources();
            SaveSVGToMemoryStreams();
            SaveSVGToZipArchive();
        }

        public static void SaveSVGDocumentToUrl()
        {
            // Save an SVG document to a Url destination with Aspose.SVG for .NET.
            // Use Url when your output target is represented by a URI rather than a plain file path.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            var outputUrl = new Url(Path.Combine(outputDir, "lineto-url-save.svg"), Directory.GetCurrentDirectory());

            using (var document = new SVGDocument(Path.Combine(dataDir, "lineto.svg")))
            {
                document.Save(outputUrl);
            }

            Console.WriteLine($"Saved SVG document to URL: {outputUrl.Href}");
        }

        public static void SaveSVGDocumentToFile()
        {
            // Save an SVG document to a local file using Aspose.SVG for .NET.
            // This example loads an SVG file, works with its DOM, and writes a copy to the output folder.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "circles-copy.svg");

            using (var document = new SVGDocument(Path.Combine(dataDir, "circles.svg")))
            {
                document.Save(outputPath);
            }

            Console.WriteLine($"Saved SVG file: {outputPath}");
        }

        public static void SaveSVGDocumentToSVGZ()
        {
            // Save an SVG document as compressed SVGZ with Aspose.SVG for .NET.
            // SVGZ is useful when SVG documents must be stored or transferred in a smaller format.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "shapes-compressed.svgz");

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes.svg")))
            {
                document.Save(outputPath, SVGSaveFormat.SVGZ);
            }

            Console.WriteLine($"Saved compressed SVGZ file: {outputPath}");
        }

        public static void SaveSVGDocumentToUrlAsSVGZ()
        {
            // Save an SVG document to a Url destination as compressed SVGZ.
            // This example combines URI-based output with the SVGSaveFormat.SVGZ option.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            var outputUrl = new Url(Path.Combine(outputDir, "aspose-url-save.svgz"), Directory.GetCurrentDirectory());

            using (var document = new SVGDocument(Path.Combine(dataDir, "aspose.svg")))
            {
                document.Save(outputUrl, SVGSaveFormat.SVGZ);
            }

            Console.WriteLine($"Saved SVG document to URL as SVGZ: {outputUrl.Href}");
        }

        public static void SaveSVGZDocumentToSVG()
        {
            // Convert a compressed SVGZ document back to a regular SVG file.
            // Aspose.SVG for .NET can load SVGZ directly and save it as uncompressed SVG.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();
            string outputPath = Path.Combine(outputDir, "shapes-from-svgz.svg");

            using (var document = new SVGDocument(Path.Combine(dataDir, "shapes.svgz")))
            {
                document.Save(outputPath, SVGSaveFormat.SVG);
            }

            Console.WriteLine($"Converted SVGZ to SVG: {outputPath}");
        }

        public static void SaveMultipleSVGZDocumentsToSVG()
        {
            // Convert all SVGZ files in the shared Data folder to regular SVG files.
            // This batch example is useful when compressed SVGZ assets must be normalized for editing.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = RunExamples.GetDataDir_OutputSVG();

            foreach (string svgzFile in Directory.GetFiles(dataDir, "*.svgz"))
            {
                string fileName = Path.GetFileNameWithoutExtension(svgzFile);
                string outputPath = Path.Combine(outputDir, fileName + "-batch.svg");

                using (var document = new SVGDocument(svgzFile))
                {
                    document.Save(outputPath, SVGSaveFormat.SVG);
                }

                Console.WriteLine($"Converted SVGZ file in batch: {outputPath}");
            }
        }

        public static void SaveSVGWithExternalResources()
        {
            // Save an SVG document together with its external resources.
            // FileSystemResourceHandler writes the SVG file and referenced resources to the output folder.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputDir = Path.Combine(RunExamples.GetDataDir_OutputSVG(), "resources");
            Directory.CreateDirectory(outputDir);

            using (var document = new SVGDocument(Path.Combine(dataDir, "with-resources.svg")))
            {
                document.Save(new FileSystemResourceHandler(outputDir));
            }

            Console.WriteLine($"Saved SVG with resources to: {outputDir}");
        }

        public static void SaveSVGToMemoryStreams()
        {
            // Save an SVG document and its external resources to memory streams.
            // A custom ResourceHandler lets applications store output in memory, databases, or cloud storage.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var document = new SVGDocument(Path.Combine(dataDir, "with-resources.svg")))
            {
                var resourceHandler = new MemoryResourceHandler();
                document.Save(resourceHandler);
                resourceHandler.PrintInfo();
            }
        }

        public static void SaveSVGToZipArchive()
        {
            // Save an SVG document and its resources into a ZIP archive.
            // The custom handler packages the main SVG file and linked resources into one portable file.
            string dataDir = RunExamples.GetDataDir_SVG();
            string outputPath = Path.Combine(RunExamples.GetDataDir_OutputSVG(), "with-resources.zip");

            using (var document = new SVGDocument(Path.Combine(dataDir, "with-resources.svg")))
            using (var resourceHandler = new ZipResourceHandler(outputPath))
            {
                document.Save(resourceHandler);
            }

            Console.WriteLine($"Saved SVG resources to ZIP archive: {outputPath}");
        }

        private class MemoryResourceHandler : ResourceHandler
        {
            private readonly List<Tuple<Stream, Resource>> streams = new List<Tuple<Stream, Resource>>();

            public override void HandleResource(Resource resource, ResourceHandlingContext context)
            {
                var outputStream = new MemoryStream();
                streams.Add(Tuple.Create<Stream, Resource>(outputStream, resource));

                string fileName = Path.GetFileName(resource.OriginalUrl.Pathname);
                resource
                    .WithOutputUrl(new Url(fileName, "memory:///"))
                    .Save(outputStream, context);
            }

            public void PrintInfo()
            {
                foreach (Tuple<Stream, Resource> stream in streams)
                {
                    Console.WriteLine($"Saved in memory: {stream.Item2.OutputUrl}, length: {stream.Item1.Length}");
                }
            }
        }

        private class ZipResourceHandler : ResourceHandler, IDisposable
        {
            private readonly FileStream zipStream;
            private readonly ZipArchive archive;
            private int streamsCounter;

            public ZipResourceHandler(string archivePath)
            {
                zipStream = new FileStream(archivePath, FileMode.Create, FileAccess.ReadWrite);
                archive = new ZipArchive(zipStream, ZipArchiveMode.Update);
            }

            public override void HandleResource(Resource resource, ResourceHandlingContext context)
            {
                string originalFileName = Path.GetFileName(resource.OriginalUrl.Pathname);
                string entryName = streamsCounter++ == 0 ? originalFileName : "resources/" + originalFileName;

                using (Stream entryStream = archive.CreateEntry(entryName).Open())
                {
                    resource
                        .WithOutputUrl(new Url(entryName, "file:///"))
                        .Save(entryStream, context);
                }
            }

            public void Dispose()
            {
                archive.Dispose();
                zipStream.Dispose();
            }
        }
    }
}
