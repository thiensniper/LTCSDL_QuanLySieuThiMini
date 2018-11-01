using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Linq;

namespace QL_SIEU_THI_LTCSDL
{
    public partial class FrmProduct : DevExpress.XtraEditors.XtraForm
    {
        Table<tbl_HangHoa> tbl_Product;
        DatabaseDataContext db;
        BindingManagerBase listProduct;

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            tbl_Product = db.tbl_HangHoas;

            LoadDatabaseToDataGridView();

        }

        private void LoadDatabaseToDataGridView()
        {
            dgvProduct.DataSource = tbl_Product;
        }
    }
}