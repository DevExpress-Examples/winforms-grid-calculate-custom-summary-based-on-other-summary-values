using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace Q273845 {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }

        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            GridView view = (GridView)sender;
            if (e.Column == colPrice)
                if (e.IsGetData) 
                    e.Value = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colUnitPrice)) * 
                        Convert.ToInt32(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colUnitsInStock));
        }

        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e) {
            if (e.Column == colPrice) 
                e.Info.DisplayText = (Convert.ToDecimal(colUnitPrice.SummaryItem.SummaryValue) * 
                    Convert.ToDecimal(colUnitsInStock.SummaryItem.SummaryValue)).ToString();
        }

        private void gridView1_CustomDrawRowFooterCell(object sender, FooterCellCustomDrawEventArgs e) {
            if (e.Column == colPrice) {
                GridView view = (GridView)sender;
                e.Info.DisplayText = (Convert.ToDecimal(view.GetGroupSummaryValue(e.RowHandle, 
                    (GridGroupSummaryItem)view.GroupSummary["UnitPrice"])) *
                    Convert.ToDecimal(view.GetGroupSummaryValue(e.RowHandle, 
                    (GridGroupSummaryItem)view.GroupSummary["UnitsInStock"]))).ToString();
            }
        }
    }
}