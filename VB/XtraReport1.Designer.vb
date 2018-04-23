Imports Microsoft.VisualBasic
Imports System
Namespace GroupPageNumbers
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.nwindDataSet1 = New GroupPageNumbers.nwindDataSet()
			Me.categoryProductsTableAdapter = New GroupPageNumbers.nwindDataSetTableAdapters.CategoryProductsTableAdapter()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.lbGroupPageNumber = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.Detail.Height = 25
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(223))))))
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.ProductName", "")})
			Me.xrLabel2.Location = New System.Drawing.Point(33, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(275, 25)
			Me.xrLabel2.StylePriority.UseBackColor = False
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.Height = 33
			Me.GroupHeader1.KeepTogether = True
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(217))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(255))))))
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.CategoryName", "")})
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.Location = New System.Drawing.Point(8, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(300, 25)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoryProductsTableAdapter
			' 
			Me.categoryProductsTableAdapter.ClearBeforeFill = True
			' 
			' PageFooter
			' 
			Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbGroupPageNumber})
			Me.PageFooter.Height = 39
			Me.PageFooter.KeepTogether = True
			Me.PageFooter.Name = "PageFooter"
			' 
			' lbGroupPageNumber
			' 
			Me.lbGroupPageNumber.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "CategoryProducts.CategoryName", "")})
			Me.lbGroupPageNumber.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.lbGroupPageNumber.Location = New System.Drawing.Point(450, 0)
			Me.lbGroupPageNumber.Name = "lbGroupPageNumber"
			Me.lbGroupPageNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbGroupPageNumber.Size = New System.Drawing.Size(175, 25)
			Me.lbGroupPageNumber.StylePriority.UseFont = False
			Me.lbGroupPageNumber.Text = "lbGroupPageNumber"
'			Me.lbGroupPageNumber.PrintOnPage += New DevExpress.XtraReports.UI.PrintOnPageEventHandler(Me.lbGroupPageNumber_PrintOnPage);
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.GroupHeader1, Me.PageFooter})
			Me.DataAdapter = Me.categoryProductsTableAdapter
			Me.DataMember = "CategoryProducts"
			Me.DataSource = Me.nwindDataSet1
			Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 213)
			Me.PageHeight = 583
			Me.PageWidth = 827
			Me.PaperKind = System.Drawing.Printing.PaperKind.A5Rotated
			Me.Version = "8.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private nwindDataSet1 As nwindDataSet
		Private categoryProductsTableAdapter As GroupPageNumbers.nwindDataSetTableAdapters.CategoryProductsTableAdapter
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private WithEvents lbGroupPageNumber As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
