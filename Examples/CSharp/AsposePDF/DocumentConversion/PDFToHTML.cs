using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToHTML
    {
        public static void Run()
        {
            // ExStart:PDFToHTML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Open the source PDF document
            Document pdfDocument = new Document(dataDir + "PDFToHTML.pdf");

            // Save the file into MS document format
            pdfDocument.Save(dataDir + "output_out.html", SaveFormat.Html);
            // ExEnd:PDFToHTML
        }
        public static void MultiPageHTML()
        {
            // ExStart:MultiPageHTML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Open the source PDF document
            Document pdfDocument = new Document(dataDir + "PDFToHTML.pdf");

            // Instantiate HTML SaveOptions object
            HtmlSaveOptions htmlOptions = new HtmlSaveOptions();

            // Specify to split the output into multiple pages
            htmlOptions.SplitIntoPages = true;

            // Save the document
            pdfDocument.Save(@"MultiPageHTML_out.html", htmlOptions);
            // ExEnd:MultiPageHTML
        }
        public static void SaveSVGFiles()
        {
            // ExStart:SaveSVGFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load the PDF file
            Document doc = new Document(dataDir + "PDFToHTML.pdf");

            // Instantiate HTML save options object
            HtmlSaveOptions newOptions = new HtmlSaveOptions();

            // Specify the folder where SVG images are saved during PDF to HTML conversion
            newOptions.SpecialFolderForSvgImages = dataDir;

            // Save the output file
            doc.Save(dataDir + "SaveSVGFiles_out.html", newOptions);
            // ExEnd:SaveSVGFiles
        }
        public static void CompressSVGImages()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load the PDF file
            Document doc = new Document(dataDir + "PDFToHTML.pdf");
            // ExStart:CompressSVGImages
            // Create HtmlSaveOption with tested feature
            HtmlSaveOptions newOptions = new HtmlSaveOptions();

            // Compress the SVG images if there are any
            newOptions.CompressSvgGraphicsIfAny = true;
            // ExEnd:CompressSVGImages
            // Save the output file
            doc.Save(dataDir + "CompressSVGImages_out.html", newOptions);
            
        }
        public static void SpecifyingImageFolder()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load the PDF file
            Document doc = new Document(dataDir + "PDFToHTML.pdf");
            // ExStart:SpecifyingImageFolder
            // Create HtmlSaveOption with tested feature
            HtmlSaveOptions newOptions = new HtmlSaveOptions();

            // Specify the separate folder to save images
            newOptions.SpecialFolderForAllImages = dataDir;
            // ExEnd:SpecifyingImageFolder
            // Save the output file
            doc.Save(dataDir + "SpecifyingImageFolder_out.html", newOptions);
            
        }
        public static void CreateSubsequentFiles()
        {
            // ExStart:CreateSubsequentFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            Document doc = new Document(dataDir + "PDFToHTML.pdf");
            
            HtmlSaveOptions options = new HtmlSaveOptions();
            // This is the tested setting
            options.HtmlMarkupGenerationMode = HtmlSaveOptions.HtmlMarkupGenerationModes.WriteOnlyBodyContent;
            options.SplitIntoPages = true;

            doc.Save(dataDir + "CreateSubsequentFiles_out.html", options);
            // ExEnd:CreateSubsequentFiles
        }
        public static void TransparentTextRendering()
        {
            // ExStart:TransparentTextRendering
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            Document doc = new Document(dataDir + "PDFToHTML.pdf");
            HtmlSaveOptions htmlOptions = new HtmlSaveOptions();
            htmlOptions.SaveShadowedTextsAsTransparentTexts = true;
            htmlOptions.SaveTransparentTexts = true;
            doc.Save(dataDir + "TransparentTextRendering_out.html", htmlOptions);
            // ExEnd:TransparentTextRendering
        }
        public static void LayersRendering()
        {
            // ExStart:LayersRendering
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            Document doc = new Document(dataDir + "PDFToHTML.pdf");
            // Instantiate HTML SaveOptions object
            HtmlSaveOptions htmlOptions = new HtmlSaveOptions();

            // Specify to render PDF document layers separately in output HTML
            htmlOptions.ConvertMarkedContentToLayers = true;

            // Save the document
            doc.Save(dataDir + "LayersRendering_out.html", htmlOptions);
            // ExEnd:LayersRendering
        }
    }
}