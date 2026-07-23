using iText.Bouncycastle.X509;
using iText.Commons.Bouncycastle.Cert;
using iText.Forms.Fields.Properties;
using iText.Forms.Form.Element;
using iText.IO.Font;
using iText.Kernel.Colors;
using iText.Kernel.Crypto;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Signatures;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Windows.Forms;
using X509Cert = System.Security.Cryptography.X509Certificates;



namespace KyDienTu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private X509Cert.X509Certificate2 GetCertificateFromStore()
        {
            using (X509Cert.X509Store store = new X509Cert.X509Store(X509Cert.StoreName.My, X509Cert.StoreLocation.CurrentUser))
            {
                store.Open(X509Cert.OpenFlags.ReadOnly);
                X509Cert.X509Certificate2Collection filter = store.Certificates.Find(X509Cert.X509FindType.FindByTimeValid, DateTime.Now, false).Find(X509Cert.X509FindType.FindByKeyUsage, X509Cert.X509KeyUsageFlags.NonRepudiation, false);
                X509Cert.X509Certificate2Collection selected = X509Cert.X509Certificate2UI.SelectFromCollection(
                filter, "Select Certificate", "Choose your USB Token Certificate", X509Cert.X509SelectionFlag.SingleSelection);
                //X509Cert.X509Certificate2Collection filter = store.Certificates.Find(X509Cert.X509FindType.FindByTimeValid, DateTime.Now, false).Find(X509Cert.X509FindType.FindByKeyUsage, X509Cert.X509KeyUsageFlags.NonRepudiation, false);
                //X509Cert.X509Certificate2Collection selected = X509Cert.X509Certificate2UI.SelectFromCollection(
                //store.Certificates, "Select Certificate", "Choose your USB Token Certificate", X509Cert.X509SelectionFlag.SingleSelection);

                if (selected.Count > 0)
                {
                    Console.WriteLine("Selected certificate: " + selected[0].Subject);
                    return selected[0];
                }
                return selected[0];
            }
        }
        bool isSelectedFile = false;
        private void btnKyDienTu_Click(object sender, EventArgs e)
        {
            string srcPdf = "";
            string destFolder = "";

            try
            {
                if (lblSelected.Text.Length > 0 && lblSignedFolder.Text.Length>0)
                {
                    destFolder = lblSignedFolder.Text;
                    if (isSelectedFile)
                    {
                        srcPdf = lblSelected.Text;
                        SignPdf(srcPdf, destFolder, posPage);
                        MessageBox.Show("Ký số thành công!");
                    }
                    else
                    {
                        DirectoryInfo dir = new DirectoryInfo(lblSelected.Text);
                        FileInfo[] files = dir.GetFiles();
                        foreach (FileInfo file in files)
                        {
                            if (file.Extension.ToLower() == ".pdf")
                            {
                                SignPdf(file.FullName, destFolder, posPage);
                            }
                        }
                        MessageBox.Show("Ký số thành công!");
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ký số: {ex.Message}");
            }
        }
        X509Cert.X509Certificate2 usbCert = null;
        X509Certificate[] chain = null;
        private void SignPdf(string srcPdf, string destFolder, string posPage)
        {

            try
            {
                
                if (usbCert==null)
                {
                    usbCert = GetCertificateFromStore();

                    var bcCertParser = new X509CertificateParser();
                    X509Certificate bcCert = bcCertParser.ReadCertificate(usbCert.RawData);
                    chain = new[] { bcCert };
                }
                float height = 0;

                float width = 0;
                int totalPages = 1;

                using (PdfDocument pdf = new PdfDocument(new PdfReader(srcPdf)))
                {
                    height = pdf.GetPage(1).GetPageSize().GetHeight();
                    width = pdf.GetPage(1).GetPageSize().GetWidth();
                    totalPages = pdf.GetNumberOfPages();
                }

                using (PdfReader reader = new PdfReader(srcPdf))
                {
                    string destPdf = Path.Combine(destFolder, Path.GetFileNameWithoutExtension(srcPdf) + "_signed.pdf");
                    using (FileStream stream = new FileStream(destPdf, FileMode.Create))
                    {
                        PdfSigner signer = new PdfSigner(reader, stream, new StampingProperties());

                        // 4. Configure visual appearance (Optional)
                        string commonName = chain[0].SubjectDN.GetValueList(X509Name.CN).Cast<string>().FirstOrDefault() ?? string.Empty;
                        string email = chain[0].SubjectDN.GetValueList(X509Name.E).Cast<string>().FirstOrDefault() ?? string.Empty;

                        //-------------------------------------------------
                        SignedAppearanceText appearanceText = new SignedAppearanceText();
                        SignatureFieldAppearance appearance = new SignatureFieldAppearance("app");
                        string signatureText = "";
                        if (chkName.Checked)
                        {
                            signatureText = txtName.Text+"\t" + commonName + "\n";
                        }
                        if (chkDate.Checked)
                        {
                            signatureText = signatureText + txtDate.Text+"\t" + DateTime.Now.ToString("dd / MM / yyyy hh: mm: ss") + "\n";
                        }
                        if (chkEmail.Checked)
                        {
                            signatureText = signatureText +txtEmail.Text +"\t" + email;
                        }
                        appearance.SetContent(signatureText);
                        PdfFont font = PdfFontFactory.CreateFont("c:/windows/fonts/arial.ttf", PdfEncodings.IDENTITY_H);
                        appearance.SetFont(font);
                        System.Drawing.Color systemColor = pnlColor.BackColor;
                        iText.Kernel.Colors.Color iColor = new DeviceRgb(systemColor.R, systemColor.G, systemColor.B);
                        appearance.SetFontColor(iColor);
                        appearance.SetFontSize((float)numSize.Value);
                        //------------------------------------
                        // Create the signature appearance
                        int pos = 0;

                        iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(10, height - (100 - 20), 200, 100);
                        if (rdTR.Checked)
                        {
                            rect = new iText.Kernel.Geom.Rectangle(width - 210, height - (100 - 20), 200, 100);// Do something
                        }
                        else if (rdBL.Checked)
                        {
                            rect = new iText.Kernel.Geom.Rectangle(10, 10, 200, 100);// Do something
                        }
                        else if (rdBR.Checked)
                        {
                            rect = new iText.Kernel.Geom.Rectangle(width - 210, 10, 200, 100);// Do something
                        }else if(int.TryParse(posPage,out pos))
                        {
                            rect = new iText.Kernel.Geom.Rectangle(customArea.X, customArea.Y, customArea.Width, customArea.Height);
                        }
                        int pageIndex = 1;
                        SignerProperties signerProperties = new SignerProperties()
                            .SetFieldName(commonName)
                            .SetPageRect(rect)
                            //.SetPageNumber(pageIndex)
                            .SetSignatureAppearance(appearance)
                            ;
                        if (!string.IsNullOrEmpty(posPage))
                        {
                            if (posPage == "BOF")// Do something
                            {
                                pageIndex = 1;
                                signerProperties.SetPageNumber(pageIndex);
                            }
                            else if (posPage == "EOF")
                            {
                                pageIndex = totalPages;
                                signerProperties.SetPageNumber(pageIndex);
                            }
                            else if (int.TryParse(posPage, out pos))
                            {
                                signerProperties.SetPageNumber(pos);
                            }

                        }

                        signerProperties.SetPageNumber(pageIndex);
                        signer.SetSignerProperties(signerProperties);
                        // Specify if the appearance before field is signed will be used
                        // as a background for the signed field. The "false" value is the default value.
                        signer.GetSignatureField().SetReuseAppearance(false);

                        // 5. Instantiate your custom interface wrapper using SHA-256
                        IExternalSignature externalSignature = new X509Certificate2Signature(usbCert, DigestAlgorithms.SHA256);
                        IExternalDigest externalDigest = new BouncyCastleDigest();

                        IX509Certificate[] certificateWrappers = new IX509Certificate[chain.Length];
                        for (int i = 0; i < certificateWrappers.Length; ++i)
                        {
                            certificateWrappers[i] = new X509CertificateBC(chain[i]);
                        }
                        // 6. Execute detached cryptographic signing 
                        signer.SignDetached(
                            externalDigest,
                            externalSignature,
                            certificateWrappers,
                            null,
                            null,
                            null,
                            0,
                            PdfSigner.CryptoStandard.CMS
                        );

                    }
                }

            }
            catch (Exception ex)
            {
            
                throw ex;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if(res == DialogResult.OK)
            {
                lblSelected.Text = openFileDialog1.FileName;
                isSelectedFile = true;
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                lblSelected.Text = folderBrowserDialog1.SelectedPath;
                isSelectedFile = false;
            }
        }

        private void pnlColor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pnlColor.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSelected.Text = "";
            lblSignedFolder.Text ="";
        }

        private void btnSignedFolder_Click(object sender, EventArgs e)
        {
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                lblSignedFolder.Text = folderBrowserDialog1.SelectedPath;   
                
            }
        }
        string posPage = "BOF";
        private void rdFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFirst.Checked)
            {
                posPage = "BOF";
                // Handle the case when the first radio button is checked
            }
        }

        private void rdLast_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLast.Checked)
            {
                posPage = "EOF";
                // Handle the case when the second radio button is checked
            }
        }
        Rectangle customArea = new Rectangle();
        private void btnCustom_Click(object sender, EventArgs e)
        {
            Custom customForm = new Custom();
            customForm.PDFFile = lblSelected.Text;
            customForm.ShowDialog();
            if (customForm.SignedArea != null)
            {
                customArea = customForm.SignedArea;
                posPage = customForm.SignedPage.ToString();
                btnKyDienTu.PerformClick();
            }
        }
    }
}
