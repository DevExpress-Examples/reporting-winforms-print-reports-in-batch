Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Namespace BatchPrinting
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private prnSettings As PrinterSettings

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim report1 As New XtraReport1()
            Dim reports() As XtraReport = { _
                New XtraReport2(), _
                New XtraReport3() _
            }

            Dim pt1 As New ReportPrintTool(report1)
            AddHandler pt1.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint

            For Each report As XtraReport In reports
                Dim pts As New ReportPrintTool(report)
                AddHandler pts.PrintingSystem.StartPrint, AddressOf reportsStartPrintEventHandler
            Next report

            If pt1.PrintDialog() = True Then
                For Each report As XtraReport In reports
                    Dim pts As New ReportPrintTool(report)
                    pts.Print()
                Next report
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