using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminControls;
using ObjectLibrary;

namespace da_features
{
    public partial class FrmTest : Form
    {
        List<KeSach> lstKS;

        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SachThuVien stv = new SachThuVien();
            stv.SetTenSach(txtTenSach.Text);
            kstv.ThemSachVaoKe(stv);
            txtTenSach.Clear();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_DB_DA_FEATURES.KeSach' table. You can move, or remove it, as needed.
            this.keSachTableAdapter.Fill(this.dataSet_DB_DA_FEATURES.KeSach);
            lstKS = Helper.ConvertDataTable<KeSach>(this.dataSet_DB_DA_FEATURES.KeSach);

            foreach (KeSach ks in lstKS)
            {
                KeSachThuVien kstv = new KeSachThuVien();
                kstv.SetTenKeSach(ks.TenKeSach);
                fpnlDSKeSach.Controls.Add(kstv);
            }
        }

        private void keSachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.keSachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_DB_DA_FEATURES);
        }
    }
}
