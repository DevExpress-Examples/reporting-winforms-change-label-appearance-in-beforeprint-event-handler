Imports System
Imports System.Drawing
Imports DevExpress.XtraReports.UI

Namespace BeforePrintEvent

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub xrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
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
