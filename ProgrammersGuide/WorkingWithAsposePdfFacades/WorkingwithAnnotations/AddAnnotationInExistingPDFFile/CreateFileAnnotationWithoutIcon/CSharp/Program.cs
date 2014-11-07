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

namespace CreateFileAnnotationWithoutIconExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // instantiate PdfContentEditor object
            PdfContentEditor editor = new PdfContentEditor();
            // bind input PDF file
            editor.BindPdf(dataDir+ "input.pdf");
            // the last argumnet is for transparency of icon
            editor.CreateFileAttachment(new System.Drawing.Rectangle(50, 50, 10, 10), "here", "simple.doc", 1, "Paperclip", 0.005);
            // save the updated PDF file
            editor.Save(dataDir+ "PdfWith_Transparent_Annotation.pdf");
            
        }
    }
}