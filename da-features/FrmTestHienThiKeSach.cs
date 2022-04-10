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
    public partial class FrmTestHienThiKeSach : Form
    {
        List<KeSach> lstKeSach = new List<KeSach>();

        public FrmTestHienThiKeSach()
        {
            InitializeComponent();
        }

        private void FrmTestHienThiKeSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_DB_DA_FEATURES.KeSach' table. You can move, or remove it, as needed.
            this.keSachTableAdapter.Fill(this.dataSet_DB_DA_FEATURES.KeSach);
            lstKeSach = Helper.ConvertDataTable<KeSach>(this.dataSet_DB_DA_FEATURES.KeSach);

            foreach (KeSach ks in lstKeSach)
            {
                KeSachThuVien kstv = new KeSachThuVien();
                kstv.SetTenKeSach(ks.TenKeSach);
                fpnlDSKeSach.Controls.Add(kstv);
            }
        }
    }
}
