using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyDienTu
{
    public class PDFPage
    {
        public Size  PageSize { get; set; }
        public Image PageImage { get; set; }
        public float PageIndex { get; set; }
    }
}
