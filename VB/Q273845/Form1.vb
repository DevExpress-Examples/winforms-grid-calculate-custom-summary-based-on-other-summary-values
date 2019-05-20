Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace Q273845
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			productsBindingSource.DataSource = GetProductsDataTable()
		End Sub

		Private Function GetProductsDataTable() As DataTable
			Dim table As New DataTable()
			table.TableName = "Products"
			table.Columns.Add(New DataColumn("ProductName", GetType(String)))
			table.Columns.Add(New DataColumn("UnitsInStock", GetType(Integer)))
			table.Columns.Add(New DataColumn("UnitPrice", GetType(Double)))
			table.Columns.Add(New DataColumn("Category", GetType(String)))
			Dim random As New Random()
			For i As Integer = 0 To 19
				Dim index As Integer = i + 1
				table.Rows.Add("Product " & index, random.Next(1, 20), Math.Round(random.NextDouble() * 1000, 3), "Category " & i Mod 7)
			Next i
			Return table
		End Function

		Private Sub gridView1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawFooterCell
			If e.Column Is colPrice Then
				e.Info.DisplayText = (Convert.ToDecimal(colUnitPrice.SummaryItem.SummaryValue) * Convert.ToDecimal(colUnitsInStock.SummaryItem.SummaryValue)).ToString()
			End If
		End Sub

		Private Sub gridView1_CustomDrawRowFooterCell(ByVal sender As Object, ByVal e As FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawRowFooterCell
			If e.Column Is colPrice Then
				Dim view As GridView = DirectCast(sender, GridView)
				e.Info.DisplayText = (Convert.ToDecimal(view.GetGroupSummaryValue(e.RowHandle, CType(view.GroupSummary("UnitPrice"), GridGroupSummaryItem))) * Convert.ToDecimal(view.GetGroupSummaryValue(e.RowHandle, CType(view.GroupSummary("UnitsInStock"), GridGroupSummaryItem)))).ToString()
			End If
		End Sub

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			Dim view As GridView = DirectCast(sender, GridView)
			If e.Column Is colPrice Then
				If e.IsGetData Then
					e.Value = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colUnitPrice)) * Convert.ToInt32(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colUnitsInStock))
				End If
			End If
		End Sub
	End Class
End Namespace