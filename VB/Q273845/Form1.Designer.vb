Namespace Q273845
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.gridControl1.DataSource = Me.productsBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(386, 538)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            Me.productsBindingSource.DataMember = "Products"
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colUnitsInStock, Me.colUnitPrice, Me.colPrice, Me.colCategory})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", Me.colUnitPrice, "", "UnitPrice"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitsInStock", Me.colUnitsInStock, "", "UnitsInStock"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Me.colPrice, "", "Price")})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategory, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.colProductName.Caption = "Product Name"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            Me.colUnitsInStock.Caption = "Units In Stock"
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.colUnitsInStock.Visible = True
            Me.colUnitsInStock.VisibleIndex = 1
            Me.colUnitPrice.Caption = "UnitPrice"
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            Me.colPrice.Caption = "Price"
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
            Me.colPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 3
            Me.colCategory.Caption = "Category"
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 4
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(386, 538)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private productsBindingSource As System.Windows.Forms.BindingSource
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
