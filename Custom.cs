
using iText.Kernel.Pdf;
using PDFtoImage;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KyDienTu
{
    public partial class Custom : Form
    {
        public Custom()
        {
            InitializeComponent();
        }
        public string PDFFile { get; set; }
        public List<System.Drawing.Image> RenderPagesToImages(string pdfPath)
        {
            var images = new List<System.Drawing.Image>();
            // Initialize Docnet engine
            //int totalPage = 0;
            //using (PdfDocument pdf = new PdfDocument(new PdfReader(PDFFile)))
            //{
            //    totalPage = pdf.GetNumberOfPages();
            //}
            //{
                
            using (FileStream pdfStream = File.OpenRead(pdfPath))
            {
                IEnumerable<SKBitmap> imgs = Conversion.ToImages(pdfStream,true);
                for (int pos = 0; pos < imgs.Count(); pos++)
                {
                    MemoryStream mStream = null;
                    using (SKData encodedData = imgs.ElementAt(pos).Encode(SKEncodedImageFormat.Jpeg, 100))
                    {
                        Stream stream = encodedData.AsStream();
                        Image img = System.Drawing.Image.FromStream(stream);
                        images.Add(img);
                    }
                        
                }
            }
                return images;
        }
        private void Custom_Load(object sender, EventArgs e)
        {
            List<Image> images = RenderPagesToImages(PDFFile);
            int pos = 1;
            foreach (Image item in images)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = item,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(180, 180),
                    Tag = pos

                };
                pictureBox.Click += PictureBox_Click;
                thumnailPDF.Controls.Add(pictureBox);
                pos++;
            }
            
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            picView.Visible = true;
            picView.Image = ((PictureBox)sender).Image;
            picView.Size = ((PictureBox)sender).Image.Size;
            pnlRect.Visible = false;
            SignedPage = (int)((PictureBox)sender).Tag;
        }
        Point start = new Point(0,0);
        Point end = new Point(0, 0);
        bool isMouseDown = false;
        private void picView_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
            Point p = new Point(0, 0);
            p.Y = e.Y - panel1.VerticalScroll.Value;
            p.X = e.X - panel1.HorizontalScroll.Value;
            start = p;
            isMouseDown = true;
            
            
        }

        private void picView_MouseUp(object sender, MouseEventArgs e)
        {
            this.Text = this.Text +" | "+ e.Location.ToString();
            end = e.Location;
            isMouseDown = false;
            
        }

        private void picView_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                //pnlRect.Location = start;
                //pnlRect.Width = Math.Abs(e.X- start.X);
                //pnlRect.Height = Math.Abs(e.Y - start.Y);
                Point p = new Point(0, 0);
                p.Y = e.Y - panel1.VerticalScroll.Value;
                p.X = e.X - panel1.HorizontalScroll.Value;
                pnlRect.Location = start;
                pnlRect.Width = Math.Abs(e.X- panel1.HorizontalScroll.Value - start.X);
                pnlRect.Height = Math.Abs(e.Y- panel1.VerticalScroll.Value - start.Y);
                this.Text = "W:" + Math.Abs(e.X - panel1.HorizontalScroll.Value - start.X) + "H:"+ Math.Abs(e.Y - panel1.VerticalScroll.Value - start.Y);
                pnlRect.Visible = true;
            }
        }
        public Rectangle SignedArea { get; set; }
        public int SignedPage { get; set; }
        private void pnlRect_Click(object sender, EventArgs e)
        {
            SignedArea = new Rectangle(pnlRect.Location, pnlRect.Size);
        }
    }
}
