<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602470/22.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1765)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for WinForms - Print Multiple Reports in a Batch

In this example, the reports are printed in a single batch, instead of sending one report at a time to the printer. The **Print** dialog box is only called for the first report, the other reports are printed without prompting, with the same print settings. 
 

The [PrintTool.Printdialog](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPrinting.PrintTool.PrintDialog.overloads) method is used to print the reports. The [StartPrint](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.StartPrint) event is handled to specify print settings.


## Files to Review

* [Form1.cs](CS/BatchPrinting/Form1.cs) (VB: [Form1.vb](VB/BatchPrinting/Form1.vb))

## Documentation

- [Printing System](https://docs.devexpress.com/WindowsForms/10733/controls-and-libraries/printing-exporting/concepts/basic-terms/printing-system)
- [Printing-Exporting](https://docs.devexpress.com/WindowsForms/2079/controls-and-libraries/printing-exporting)
- [Print a Report](https://docs.devexpress.com/XtraReports/5191/winforms-reporting/winforms-reporting-print-api/print-a-report)

## More Examples

- [How to programmatically select a printe](https://github.com/DevExpress-Examples/Reporting_how-to-programmatically-select-a-printer-e1766)
- [How to determine the settings of the selected printer when the OK button is pressed in the Printer dialog](https://github.com/DevExpress-Examples/Reporting_how-to-determine-the-settings-of-the-selected-printer-when-the-ok-button-is-pressed-e1767)
- [How to dynamically select the paper source and set the printer resolution](https://github.com/DevExpress-Examples/Reporting_how-to-dynamically-select-the-paper-source-and-set-the-printer-resolution-e332)
- [How to programmatically print a specified range of report pages](https://github.com/DevExpress-Examples/Reporting_how-to-programmatically-print-a-specified-range-of-report-pages-e1768)



