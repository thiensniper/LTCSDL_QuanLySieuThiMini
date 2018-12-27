using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SIEU_THI_LTCSDL
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.QLSieuThiMiniConnectionString);

            string query = "select * from tbl_DetailedBill, tbl_Product, tbl_Bill where tbl_Bill.BillID = tbl_DetailedBill.IDBill and tbl_DetailedBill.IDProduct = tbl_Product.ProductID";
            if (txtYear.Text.Trim().Length > 0)
                query += " and tbl_Bill.BilledDate/10000 = " + txtYear.Text;
            if (txtMonth.Text.Trim().Length > 0)
                query += " and (tbl_Bill.BilledDate/100)%100 = " + txtMonth.Text;
            if (txtMonth.Text.Trim().Length > 0)
                query += " and tbl_Bill.BilledDate%100 = " + txtDay.Text;

            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();

            da.Fill(dt);

            crRevenue rpt = new crRevenue();
            rpt.SetDataSource(dt.DefaultView);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
