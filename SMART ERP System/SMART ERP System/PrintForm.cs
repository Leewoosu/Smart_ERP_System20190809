using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_ERP_System
{
    public partial class PrintForm : MetroForm
    {
        private PrintDocument prtDoc = new PrintDocument();
        private PrinterSettings prtSet = new PrinterSettings();
        private PageSettings pgSet = new PageSettings();

        public PrintForm()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            prtDoc.PrinterSettings = prtSet;
            prtDoc.DefaultPageSettings = pgSet;

            PrintDialog prtDialog = new PrintDialog();
            prtDialog.Document = prtDoc;

            if (prtDialog.ShowDialog() == DialogResult.OK)
                prtDoc.Print();
        }

        private void BtnPrtSet_Click(object sender, EventArgs e)
        {
            PageSetupDialog pgSetDialog = new PageSetupDialog();
            pgSetDialog.AllowPrinter = true;
            pgSetDialog.AllowOrientation = true;
            pgSetDialog.AllowMargins = true;
            pgSetDialog.PageSettings = pgSet;
            pgSetDialog.PrinterSettings = prtSet;

            pgSetDialog.ShowDialog();
        }

        private void BtnPreView_Click(object sender, EventArgs e)
        {
            prtDoc.PrinterSettings = prtSet;
            prtDoc.DefaultPageSettings = pgSet;

            PrintPreviewDialog prtPreviewDialog = new PrintPreviewDialog();
            prtDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            prtPreviewDialog.Document = prtDoc;
            prtPreviewDialog.ShowDialog();
        }

        // 프린트 핸들러
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            String textToPrint = ".Net Printing is Easy";
            Font printFont = new Font("Courier New", 40);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            float width = e.PageSettings.PaperSize.Width;
            float height = e.PageSettings.PaperSize.Height;

            //// 이미지는 각자 경로로 변경
            Image img = Image.FromFile(@"C:\Users\301-02\source\repos\SMART ERP System\SMART ERP System\Resources\print-preview.png");
            e.Graphics.DrawImage(img, 0, 0, (int)width, (int)height);
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Red, 50, 100);
        }
    }
}
