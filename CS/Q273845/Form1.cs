using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace Q273845
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsBindingSource.DataSource = GetProductsDataTable();
        }

        DataTable GetProductsDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Products";
            table.Columns.Add(new DataColumn("ProductName", typeof(string)));
            table.Columns.Add(new DataColumn("UnitsInStock", typeof(int)));
            table.Columns.Add(new DataColumn("UnitPrice", typeof(double)));
            table.Columns.Add(new DataColumn("Category", typeof(string)));
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                int index = i + 1;
                table.Rows.Add("Product " + index, random.Next(1, 20), Math.Round(random.NextDouble() * 1000, 3), "Category " + i % 7);
            }
            return table;
        }

        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if(e.Column == colPrice)
                e.Info.DisplayText = (Convert.ToDecimal(colUnitPrice.SummaryItem.SummaryValue) *
                    Convert.ToDecimal(colUnitsInStock.SummaryItem.SummaryValue)).ToString();
        }

        private void gridView1_CustomDrawRowFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if(e.Column == colPrice)
            {
                GridView view = (GridView)sender;
                e.Info.DisplayText = (Convert.ToDecimal(view.GetGroupSummaryValue(e.RowHandle,
                    (GridGroupSummaryItem)view.GroupSummary["UnitPrice"])) *
                    Convert.ToDecimal(view.GetGroupSummaryValue(e.RowHandle,
                    (GridGroupSummaryItem)view.GroupSummary["UnitsInStock"]))).ToString();
            }
        }

        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = (GridView)sender;
            if(e.Column == colPrice)
                if(e.IsGetData)
                    e.Value = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colUnitPrice)) *
                        Convert.ToInt32(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colUnitsInStock));
        }
    }
}