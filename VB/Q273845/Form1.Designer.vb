Imports Microsoft.VisualBasic
Imports System
Namespace Q273845
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q273845.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsTableAdapter = New Q273845.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.categoriesTableAdapter = New Q273845.nwindDataSetTableAdapters.CategoriesTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.productsBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(386, 538)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductName, Me.colUnitsInStock, Me.colUnitPrice, Me.colPrice, Me.colCategory})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", Me.colUnitPrice, "", "UnitPrice"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitsInStock", Me.colUnitsInStock, "", "UnitsInStock"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Me.colPrice, "", "Price")})
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowFooter = True
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategory, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
'			Me.gridView1.CustomDrawFooterCell += New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(Me.gridView1_CustomDrawFooterCell);
'			Me.gridView1.CustomDrawRowFooterCell += New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(Me.gridView1_CustomDrawRowFooterCell);
			' 
			' colProductName
			' 
			Me.colProductName.Caption = "Product Name"
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 0
			' 
			' colUnitsInStock
			' 
			Me.colUnitsInStock.Caption = "Units In Stock"
			Me.colUnitsInStock.FieldName = "UnitsInStock"
			Me.colUnitsInStock.Name = "colUnitsInStock"
			Me.colUnitsInStock.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
			Me.colUnitsInStock.Visible = True
			Me.colUnitsInStock.VisibleIndex = 1
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.Caption = "UnitPrice"
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 2
			' 
			' colPrice
			' 
			Me.colPrice.Caption = "Price"
			Me.colPrice.FieldName = "Price"
			Me.colPrice.Name = "colPrice"
			Me.colPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
			Me.colPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			Me.colPrice.Visible = True
			Me.colPrice.VisibleIndex = 3
			' 
			' colCategory
			' 
			Me.colCategory.Caption = "Category"
			Me.colCategory.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.colCategory.FieldName = "CategoryID"
			Me.colCategory.Name = "colCategory"
			Me.colCategory.Visible = True
			Me.colCategory.VisibleIndex = 4
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.DataSource = Me.categoriesBindingSource
			Me.repositoryItemLookUpEdit1.DisplayMember = "CategoryName"
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.ValueMember = "CategoryID"
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(386, 538)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As Q273845.nwindDataSetTableAdapters.ProductsTableAdapter
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As Q273845.nwindDataSetTableAdapters.CategoriesTableAdapter
	End Class
End Namespace

