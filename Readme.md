<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1765)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WinForms - Print Multiple Reports in a Batch

In this example, reports are printed in a single batch instead of sending one report at a time to the printer. The Print dialog appears only for the first report; the other reports are printed without prompting with the same printer settings.

![Print dialog](/images/print.png)

## Implementation Details 

* Use the [PrintTool.PrintDialog](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPrinting.PrintTool.PrintDialog.overloads) method for the first report to display the Print dialog and specify print settings. 
* Handle the [StartPrint](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.StartPrint) event to capture these settings and apply them to each report before printing. 
* Call the [Print](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintToolBase.Print.overloads) method to print subsequent reports with the same printer settings, without prompting the user again.

```cs
// Stores the printer settings selected by the user in the print dialog.
private PrinterSettings prnSettings;

// Handles the button click event to start the batch printing process.
private void button1_Click(object sender, EventArgs e) {
    XtraReport1 report1 = new XtraReport1();
    XtraReport[] reports = new XtraReport[] { new XtraReport2(), new XtraReport3() };

    // Creates a print tool for the first report and subscribe to the StartPrint event.
    ReportPrintTool pt1 = new ReportPrintTool(report1);
    pt1.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);

    // Subscribes to the StartPrint event for each additional report.
    foreach (XtraReport report in reports) {
        ReportPrintTool pts = new ReportPrintTool(report);
        pts.PrintingSystem.StartPrint += new PrintDocumentEventHandler(reportsStartPrintEventHandler);
    }

    // Shows the print dialog for the first report.
    if(pt1.PrintDialog() == true) {
        // If the user confirms, print all additional reports with the selected printer settings
        foreach(XtraReport report in reports) {
            ReportPrintTool pts = new ReportPrintTool(report);
            pts.Print();
        }
    }
 }

// Event handler to capture the printer settings from the print dialog.
void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
    prnSettings = e.PrintDocument.PrinterSettings;
}

// Event handler to apply the captured printer settings to each report before printing.
private void reportsStartPrintEventHandler(object sender, PrintDocumentEventArgs e) {
   int pageCount = e.PrintDocument.PrinterSettings.ToPage;
   e.PrintDocument.PrinterSettings = prnSettings;

   // Ensures all pages are printed, even if reports have different page counts.
   e.PrintDocument.PrinterSettings.ToPage = pageCount;
}
```


## Files to Review

* [Form1.cs](CS/BatchPrinting/Form1.cs) (VB: [Form1.vb](VB/BatchPrinting/Form1.vb))

## Documentation

- [Printing System](https://docs.devexpress.com/WindowsForms/10733/controls-and-libraries/printing-exporting/concepts/basic-terms/printing-system)
- [Printing-Exporting](https://docs.devexpress.com/WindowsForms/2079/controls-and-libraries/printing-exporting)
- [Print a Report](https://docs.devexpress.com/XtraReports/5191/winforms-reporting/winforms-reporting-print-api/print-a-report)
- [Merge Reports](https://docs.devexpress.com/XtraReports/3320/detailed-guide-to-devexpress-reporting/merge-reports)

## More Examples

- [How to programmatically select a printe](https://github.com/DevExpress-Examples/Reporting_how-to-programmatically-select-a-printer-e1766)
- [How to determine the settings of the selected printer when the OK button is pressed in the Printer dialog](https://github.com/DevExpress-Examples/Reporting_how-to-determine-the-settings-of-the-selected-printer-when-the-ok-button-is-pressed-e1767)
- [How to dynamically select the paper source and set the printer resolution](https://github.com/DevExpress-Examples/Reporting_how-to-dynamically-select-the-paper-source-and-set-the-printer-resolution-e332)
- [How to programmatically print a specified range of report pages](https://github.com/DevExpress-Examples/Reporting_how-to-programmatically-print-a-specified-range-of-report-pages-e1768)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-print-reports-in-batch&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-print-reports-in-batch&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->



