Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraReports.UI

Namespace BeforePrintEvent
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel2.BeforePrint, xrLabel1.BeforePrint, xrLabel6.BeforePrint
			' Obtain the current label.
			Dim label As XRLabel = CType(sender, XRLabel)

			' Get the total value.
			Dim total As Double = Convert.ToDouble(GetCurrentColumnValue("Total"))

			' Customize the label's appearance.
			If total < 100 Then
				label.ForeColor = Color.White
				label.BackColor = Color.Red
			ElseIf total > 1000 Then
				label.ForeColor = Color.White
				label.BackColor = Color.Green
			Else
				label.ForeColor = Color.Black
				label.BackColor = Color.Transparent
			End If
		End Sub

	End Class
End Namespace
