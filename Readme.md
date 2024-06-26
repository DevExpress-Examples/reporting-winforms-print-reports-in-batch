<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1765)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/BatchPrinting/Form1.cs) (VB: [Form1.vb](./VB/BatchPrinting/Form1.vb))
<!-- default file list end -->
# How to print multiple reports as a single batch


<p>The following example demonstrates how to print several reports in a single batch, instead of sending one report at a time to the printer. Also, in this example, the Print dialog is invoked for the first report only, and the other reports are printed without any dialogs, but using the same print settings. <br><br>To print a report, use the PrintTool (the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPrintingPrintTool_PrintDialogtopic(YORSxg)">PrintTool.PrintDialog</a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingPrintToolBase_Printtopic">PrintToolBase.Print</a> methods). You'll also need to handle <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXtraReporttopic">XtraReport</a>'s <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingPrintingSystemBase_StartPrinttopic">PrintingSystemBase.StartPrint</a> event.</p>
<p><strong>See Also:</strong><br> - <a href="https://www.devexpress.com/Support/Center/p/E1766">How to programmatically select a printer</a>;<br> - <a href="https://www.devexpress.com/Support/Center/p/A1912">How to hide the Printing status window</a>;<br> - <a href="https://www.devexpress.com/Support/Center/p/E1767">How to determine the settings of the selected printer when the OK button is pressed in the Printer dialog</a>;<br> - <a href="https://www.devexpress.com/Support/Center/p/E332">How to dynamically select the paper source and set the printer resolution</a>;<br> - <a href="https://www.devexpress.com/Support/Center/p/E1768">How to programmatically print a specified range of report pages</a>.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-print-reports-in-batch&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-print-reports-in-batch&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
