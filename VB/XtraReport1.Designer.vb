Namespace BeforePrintEvent

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.nwindDataSet1 = New BeforePrintEvent.nwindDataSet()
            Me.orderDetailsTableAdapter = New BeforePrintEvent.nwindDataSetTableAdapters.OrderDetailsTableAdapter()
            Me.Total = New DevExpress.XtraReports.UI.CalculatedField()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel6, Me.xrLabel2, Me.xrLabel1})
            Me.Detail.Height = 28
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.ProductName", "{0:$0}")})
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrLabel2.Location = New System.Drawing.Point(100, 0)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.Size = New System.Drawing.Size(350, 25)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            AddHandler Me.xrLabel2.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.xrLabel_BeforePrint)
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.OrderID", "")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrLabel1.Location = New System.Drawing.Point(0, 0)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.Size = New System.Drawing.Size(100, 25)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            AddHandler Me.xrLabel1.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.xrLabel_BeforePrint)
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' orderDetailsTableAdapter
            ' 
            Me.orderDetailsTableAdapter.ClearBeforeFill = True
            ' 
            ' Total
            ' 
            Me.Total.DataMember = "OrderDetails"
            Me.Total.DataSource = Me.nwindDataSet1
            Me.Total.Expression = "[UnitPrice] * [Quantity]"
            Me.Total.FieldType = DevExpress.XtraReports.UI.FieldType.[Double]
            Me.Total.Name = "Total"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.BackColor = System.Drawing.Color.Silver
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel5, Me.xrLabel4, Me.xrLabel3})
            Me.PageHeader.ForeColor = System.Drawing.Color.Navy
            Me.PageHeader.Height = 25
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.StylePriority.UseBackColor = False
            Me.PageHeader.StylePriority.UseForeColor = False
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel4.Location = New System.Drawing.Point(100, 0)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.Size = New System.Drawing.Size(350, 25)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "Product"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel3.Location = New System.Drawing.Point(0, 0)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.Size = New System.Drawing.Size(100, 25)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            Me.xrLabel3.Text = "ID"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel5.Location = New System.Drawing.Point(450, 0)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.Size = New System.Drawing.Size(92, 25)
            Me.xrLabel5.StylePriority.UseFont = False
            Me.xrLabel5.StylePriority.UseTextAlignment = False
            Me.xrLabel5.Text = "Total Price"
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Total", "{0:$0}")})
            Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrLabel6.Location = New System.Drawing.Point(450, 0)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.Size = New System.Drawing.Size(92, 25)
            Me.xrLabel6.StylePriority.UseFont = False
            Me.xrLabel6.StylePriority.UseTextAlignment = False
            Me.xrLabel6.Text = "xrLabel2"
            Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            AddHandler Me.xrLabel6.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.xrLabel_BeforePrint)
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.Total})
            Me.DataAdapter = Me.orderDetailsTableAdapter
            Me.DataMember = "OrderDetails"
            Me.DataSource = Me.nwindDataSet1
            Me.Version = "8.2"
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private nwindDataSet1 As BeforePrintEvent.nwindDataSet

        Private orderDetailsTableAdapter As BeforePrintEvent.nwindDataSetTableAdapters.OrderDetailsTableAdapter

        Private Total As DevExpress.XtraReports.UI.CalculatedField

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
