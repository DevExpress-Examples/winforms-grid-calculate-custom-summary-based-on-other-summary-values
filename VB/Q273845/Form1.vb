Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Namespace Q273845
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

		End Sub

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			Dim view As GridView = CType(sender, GridView)
			If e.Column Is colPrice Then
				If e.IsGetData Then
					e.Value = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colUnitPrice)) * Convert.ToInt32(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colUnitsInStock))
				End If
			End If
		End Sub

		Private Sub gridView1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawFooterCell
			If e.Column Is colPrice Then
				e.Info.DisplayText = (Convert.ToDecimal(colUnitPrice.SummaryItem.SummaryValue) * Convert.ToDecimal(colUnitsInStock.SummaryItem.SummaryValue)).ToString()
			End If
		End Sub

		Private Sub gridView1_CustomDrawRowFooterCell(ByVal sender As Object, ByVal e As FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawRowFooterCell
			If e.Column Is colPrice Then
				Dim view As GridView = CType(sender, GridView)
				e.Info.DisplayText = (Convert.ToDecimal(view.GetGroupSummaryValue(e.RowHandle, CType(view.GroupSummary("UnitPrice"), GridGroupSummaryItem))) * Convert.ToDecimal(view.GetGroupSummaryValue(e.RowHandle, CType(view.GroupSummary("UnitsInStock"), GridGroupSummaryItem)))).ToString()
			End If
		End Sub
	End Class
End Namespace