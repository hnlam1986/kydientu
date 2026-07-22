using iText.Bouncycastle.Crypto;
using iText.Bouncycastle.X509;
using iText.Commons.Bouncycastle.Cert;
using iText.Commons.Bouncycastle.Crypto;
using iText.Forms.Fields.Properties;
using iText.Forms.Form.Element;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Crypto;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Signatures;
using Org.BouncyCastle.Asn1.Esf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Tls;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
//using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static iText.Forms.PdfSigFieldLock;



namespace KyDienTu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKyDienTu_Click(object sender, EventArgs e)
        {
            string sourcePdf = "d:\\test.pdf";
            string signedPdf = "d:\\signed_output.pdf";
            string signatureFieldName = "Signature1";
            try
            {
                string KEYSTORE = "D:\\cert.pfx";
                char[] PASSWORD = "12345678".ToCharArray();
                Pkcs12Store pk12 =new Pkcs12StoreBuilder().Build();
                using (System.IO.Stream stream = new System.IO.FileStream(KEYSTORE, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
                {
                    pk12.Load(stream, PASSWORD);
                }
                //Pkcs12Store pk12 = new Pkcs12Store(new FileStream(KEYSTORE,FileMode.Open, FileAccess.Read), PASSWORD);
                string alias = null;
                foreach (object a in pk12.Aliases)
                {
                    alias = ((string)a);
                    if (pk12.IsKeyEntry(alias))
                    {
                        break;
                    }
                }
                ICipherParameters pk = pk12.GetKey(alias).Key;

                string DEST = "d:\\signed_output.pdf";
                string SRC = "d:\\test.pdf"; ;

                X509CertificateEntry[] ce = pk12.GetCertificateChain(alias);
                X509Certificate[] chain = new X509Certificate[ce.Length];
                for (int k = 0; k < ce.Length; ++k)
                {
                    chain[k] = ce[k].Certificate;
                }

                Sign(SRC, DEST , chain, pk,
                DigestAlgorithms.SHA256, PdfSigner.CryptoStandard.CMS,
                "Test", "Ghent", null, null, null, 0);

                Console.WriteLine("Ký số thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi ký số: {ex.Message}");
            }
        }

        public void Sign(string src, string dest, X509Certificate[] chain, ICipherParameters pk,
            string digestAlgorithm, PdfSigner.CryptoStandard subfilter, string reason, string location,
            ICollection<ICrlClient> crlList, IOcspClient ocspClient, ITSAClient tsaClient, int estimatedSize)
        {
            float height = 0;
            using (PdfDocument pdf = new PdfDocument(new PdfReader(src)))
            {
                height = pdf.GetPage(1).GetPageSize().GetHeight();
            }
                

            PdfReader reader = new PdfReader(src);
            PdfSigner signer = new PdfSigner(reader, new FileStream(dest, FileMode.Create), new StampingProperties());

            //System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate2 = new System.Security.Cryptography.X509Certificates.X509Certificate2(chain[0]);
            string commonName = chain[0].SubjectDN.GetValueList(X509Name.CN).Cast<string>().FirstOrDefault() ?? string.Empty;

            //-------------------------------------------------
            SignedAppearanceText appearanceText = new SignedAppearanceText();
            SignatureFieldAppearance appearance = new SignatureFieldAppearance("app");
            appearance.SetContent("Ký bởi:\t" + commonName + "\n\r Ngày:\t"+DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            PdfFont font = PdfFontFactory.CreateFont("c:/windows/fonts/arial.ttf", PdfEncodings.IDENTITY_H);
            appearance.SetFont(font);
            //appearance.SetFontColor(new DeviceRgb(0xF9, 0x9D, 0x25));
            appearance.SetFontSize(12);
            //------------------------------------
            // Create the signature appearance
          

            iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(10, height-(100-20), 200, 100);
            SignerProperties signerProperties = new SignerProperties()
                .SetFieldName("My Signature Name")
                //.SetContact("1111111")
                //.SetSignatureCreator("222222222")
                //.SetReason(reason)
                //.SetLocation(location)
                .SetPageRect(rect)
                
                .SetPageNumber(1)
                .SetSignatureAppearance(appearance)
                
                ;
            signer.SetSignerProperties(signerProperties);
            // Specify if the appearance before field is signed will be used
            // as a background for the signed field. The "false" value is the default value.
            signer.GetSignatureField().SetReuseAppearance(false);

         
            
            

            IExternalSignature pks = new PrivateKeySignature(new PrivateKeyBC(pk), digestAlgorithm);

            IX509Certificate[] certificateWrappers = new IX509Certificate[chain.Length];
            for (int i = 0; i < certificateWrappers.Length; ++i)
            {
                certificateWrappers[i] = new X509CertificateBC(chain[i]);
            }
            
            // Sign the document using the detached mode, CMS or CAdES equivalent.
            signer.SignDetached(pks, certificateWrappers, crlList, ocspClient, tsaClient, estimatedSize, subfilter);
        }
    }
}
