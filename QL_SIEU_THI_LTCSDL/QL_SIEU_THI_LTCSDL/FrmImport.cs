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
    public partial class FrmImport : DevExpress.XtraEditors.XtraForm
    {
        private Table<tbl_Product> tbl_Product;
        private DatabaseDataContext db;

        public FrmImport()
        {
            InitializeComponent();
        }

        private void FrmImport_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            LoadDatabaseToDataListView();
        }

        private void LoadDatabaseToDataListView()
        {
            tbl_Product = db.tbl_Products;
            
        }
    }
}