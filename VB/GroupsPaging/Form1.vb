Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Namespace GroupsPaging
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a report, and specify its data source.
			Dim report As New XtraReport()
			Dim ds As New nwindDataSet()
			CType(New nwindDataSetTableAdapters.CategoryProductsTableAdapter(), nwindDataSetTableAdapters.CategoryProductsTableAdapter).Fill(ds.CategoryProducts)
			report.DataSource = ds
			report.DataMember = "CategoryProducts"

			' Add a detail band and define its contents.
			Dim detailBand As New DetailBand()
			detailBand.Height = 100
			report.Bands.Add(detailBand)

			Dim detailLabel As New XRLabel()
			detailLabel.DataBindings.Add("Text", report.DataSource, "ProductName")
			detailLabel.Width = 200
			detailBand.Controls.Add(detailLabel)

			' Add a group header band and define its contents.
			Dim ghBand As New GroupHeaderBand()
			ghBand.Height = 20
			report.Bands.Add(ghBand)

			Dim ghLabel As New XRLabel()
			ghLabel.DataBindings.Add("Text", report.DataSource, "CategoryName")
			ghLabel.Width = 200
			ghLabel.BackColor = Color.LightBlue
			ghBand.Controls.Add(ghLabel)

			' Define a grouping criteria for the group header band.
			Dim groupField As New GroupField()
			groupField.FieldName = "CategoryName"
			ghBand.GroupFields.Add(groupField)

			' Create a group footer band.
			Dim gfBand As New GroupFooterBand()
			gfBand.Height = 20
			' You can force the group header to be repeated on each page.
			gfBand.RepeatEveryPage = True
			' It's important to set its Band.PageBreak property to AfterBand,
			' because the page numbers are displayed for the last group on a page.
			' So, if there are two distinct groups appearing on the same page, 
			' this will result in improper page numbering. 
			gfBand.PageBreak = PageBreak.AfterBand
			report.Bands.Add(gfBand)

			' Create an instance of the XRPageInfo control.
			Dim myPageInfo As New XRPageInfo()
			' Set the group header band as the running band for this control.
			myPageInfo.RunningBand = ghBand
			' Adjust other properties of XRPageInfo.
			myPageInfo.Width = 200
			myPageInfo.BackColor = Color.LightBlue
			myPageInfo.PageInfo = PageInfo.NumberOfTotal
			myPageInfo.Format = "Pages in this Group: {0} of {1}"
			gfBand.Controls.Add(myPageInfo)

			' Show the report's print preview.
			report.ShowPreview()
		End Sub

	End Class
End Namespace