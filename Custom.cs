using Docnet.Core;
using Docnet.Core.Models;
using iText.IO.Util;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Xobject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyDienTu
{
    public partial class Custom : Form
    {
        public Custom()
        {
            InitializeComponent();
        }
        public string PDFFile { get; set; }
        public List<Image> RenderPageToPng(string pdfPath)
        {
            var images = new List<Image>();
            // Initialize Docnet engine
            using (var library = DocLib.Instance)
            using (var docReader = library.GetDocReader(pdfPath, new PageDimensions()))
            {
                int totalpage = docReader.GetPageCount();
                for (int i = 1; i <= totalpage; i++)
                {
                    using (var pageReader = docReader.GetPageReader(i)) // 0-indexed
                    {
                        int width = pageReader.GetPageWidth();
                        int height = pageReader.GetPageHeight();
                        byte[] rawBytes = pageReader.GetImage(); // Returns raw BGRA bytes

                        // Reconstruct as a functional bitmap object
                        using (var bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb))
                        {
                            var bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
                            System.Runtime.InteropServices.Marshal.Copy(rawBytes, 0, bmpData.Scan0, rawBytes.Length);
                            bitmap.UnlockBits(bmpData);
                            images.Add(new Bitmap(bitmap)); // Add a copy of the bitmap to the list

                        }
                    }
                }
            }
            return images;
        }
        private void Custom_Load(object sender, EventArgs e)
        {
            var images = RenderPageToPng(PDFFile);

            //using (PdfDocument pdf = new PdfDocument(new PdfReader(PDFFile)))
            //{
            //    for(int pos = 1; pos <= pdf.GetNumberOfPages(); pos++)
            //    {

                
            //    PdfImageXObject imageXObject = pdf.GetPage(1);
                    

            //    int width = (int)imageXObject.GetWidth();
            //    int height = (int)imageXObject.GetHeight();
            //    byte[] rawBytes = imageXObject.GetImageBytes();

            //    // Create a blank bitmap matching the PDF image specifications
            //    Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            //    // Lock bitmap memory to copy raw pixel bytes safely
            //    BitmapData bmpData = bitmap.LockBits(
            //        new Rectangle(0, 0, width, height),
            //        ImageLockMode.WriteOnly,
            //        bitmap.PixelFormat
            //    );

            //    try
            //    {
            //        // Copy bytes to the bitmap memory pointer
            //        Marshal.Copy(rawBytes, 0, bmpData.Scan0, Math.Min(rawBytes.Length, bmpData.Stride * height));
            //    }
            //    finally
            //    {
            //        bitmap.UnlockBits(bmpData);
            //    }
            //    PictureBox pictureBox = new PictureBox
            //    {
            //        Image = bitmap,
            //        SizeMode = PictureBoxSizeMode.Zoom,
            //        Size = new Size(50, 50),
            //    };
            //    thumnailPDF.Controls.Add(pictureBox);
            //        }
            //}
        }
    }
}
