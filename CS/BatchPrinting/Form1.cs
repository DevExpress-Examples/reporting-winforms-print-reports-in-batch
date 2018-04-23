using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...

namespace BatchPrinting {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private PrinterSettings prnSettings;

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report1 = new XtraReport1();
            XtraReport[] reports = new XtraReport[] { new XtraReport2(), new XtraReport3() };

            report1.PrintingSystem.StartPrint += new PrintDocumentEventHandler(report1StartPrintEventHandler);
            foreach (XtraReport report in reports) {
                report.PrintingSystem.StartPrint += new PrintDocumentEventHandler(reportsStartPrintEventHandler);
            }

            report1.PrintDialog();
            foreach (XtraReport report in reports) {
                report.Print();
            }
        }

        private void report1StartPrintEventHandler(object sender, PrintDocumentEventArgs e) {
            prnSettings = e.PrintDocument.PrinterSettings;
        }

        private void reportsStartPrintEventHandler(object sender, PrintDocumentEventArgs e) {
            int pageCount = e.PrintDocument.PrinterSettings.ToPage;
            e.PrintDocument.PrinterSettings = prnSettings;

            // Do this if your reports contain different number of pages,
            // and you always need to print all pages in a report.
            e.PrintDocument.PrinterSettings.ToPage = pageCount;
        }

    }
}