//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace ExtractImagesToStreamExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "input.pdf");

            //extract images
            pdfExtractor.ExtractImage();
            //get all the extracted images
            while (pdfExtractor.HasNextImage())
            {
                //read image into memory stream
                MemoryStream memoryStream = new MemoryStream();
                pdfExtractor.GetNextImage(memoryStream);

                //write to disk, if you like, or use it otherwise.
                FileStream fileStream = new
                FileStream(dataDir+ DateTime.Now.Ticks.ToString() + ".jpg", FileMode.Create);
                memoryStream.WriteTo(fileStream);
                fileStream.Close();
            }
            
        }
    }
}