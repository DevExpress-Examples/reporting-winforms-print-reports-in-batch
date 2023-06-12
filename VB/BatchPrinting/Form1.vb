Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

' ...
Namespace BatchPrinting

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private prnSettings As PrinterSettings

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report1 As XtraReport1 = New XtraReport1()
            Dim reports As XtraReport() = New XtraReport() {New XtraReport2(), New XtraReport3()}
            Dim pt1 As ReportPrintTool = New ReportPrintTool(report1)
            AddHandler pt1.PrintingSystem.StartPrint, New PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)
            For Each report As XtraReport In reports
                Dim pts As ReportPrintTool = New ReportPrintTool(report)
                AddHandler pts.PrintingSystem.StartPrint, New PrintDocumentEventHandler(AddressOf reportsStartPrintEventHandler)
            Next

            If pt1.PrintDialog() = True Then
                For Each report As XtraReport In reports
                    Dim pts As ReportPrintTool = New ReportPrintTool(report)
                    pts.Print()
                Next
            End If
        End Sub

        Private Sub PrintingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
            prnSettings = e.PrintDocument.PrinterSettings
        End Sub

        Private Sub reportsStartPrintEventHandler(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
            Dim pageCount As Integer = e.PrintDocument.PrinterSettings.ToPage
            e.PrintDocument.PrinterSettings = prnSettings
            ' Do this if your reports contain different number of pages,
            ' and you always need to print all pages in a report.
            e.PrintDocument.PrinterSettings.ToPage = pageCount
        End Sub
    End Class
End Namespace
