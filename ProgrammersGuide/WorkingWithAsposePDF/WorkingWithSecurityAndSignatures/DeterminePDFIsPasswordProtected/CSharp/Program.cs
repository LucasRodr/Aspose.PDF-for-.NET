//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace DeterminePDFIsPasswordProtected
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");


            // load the source PDF doucment
            PdfFileInfo fileInfo = new PdfFileInfo(dataDir+ @"input.pdf");
            // determine that source PDF file is Encrypted with password
            bool encrypted = fileInfo.IsEncrypted;
            // MessageBox displays the current status related to PDf encryption
           Console.WriteLine(encrypted.ToString());
            
        }
    }
}