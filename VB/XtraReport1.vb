Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
' ...

Namespace GroupPageNumbers
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private lastCategory As String = ""
		Private pageNumber As Integer = 0

		Private Sub lbGroupPageNumber_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles lbGroupPageNumber.PrintOnPage
			Dim curCategory As String = (CType(sender, XRLabel)).Tag.ToString()
			Dim pageCount As Integer = 0

			For Each page As Page In Me.Pages
				Dim brickEnum As BrickEnumerator = page.GetEnumerator()

				Do While brickEnum.MoveNext()
					Dim brick As VisualBrick = TryCast(brickEnum.Current, VisualBrick)

					If brick IsNot Nothing AndAlso brick.BrickOwner Is CType(sender, XRLabel) Then
						If brick.Value.ToString() = curCategory Then
							pageCount += 1
						End If
					End If
				Loop
			Next page

			If curCategory = lastCategory Then
				pageNumber += 1
			Else
				pageNumber = 1
			End If

			lastCategory = curCategory
			CType(sender, XRLabel).Text = "Page " & pageNumber.ToString() & " of " & pageCount.ToString()
		End Sub

	End Class
End Namespace
