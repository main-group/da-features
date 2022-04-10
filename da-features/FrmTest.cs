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

namespace da_features
{
    public partial class FrmTest : Form
    {
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
    }
}
