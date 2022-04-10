using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminControls
{
    public partial class KeSachThuVien : UserControl
    {
        public KeSachThuVien()
        {
            InitializeComponent();
        }

        public void SetTenKeSach(string tenKeSach)
        {
            lblTenKeSach.Text = tenKeSach;
        }

        public void ThemSachVaoKe(SachThuVien stv)
        {
            int soLuong = fpnlHienThi.Controls.Count;
            if (soLuong >= 14)
            {
                MessageBox.Show("Kệ đã hết chỗ để sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            stv.Name = string.Format("lbl{0}", soLuong++);
            fpnlHienThi.Controls.Add(stv);
        }

        private void KeSachThuVien_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)
            {
                SachThuVien stv = new SachThuVien();
                stv.Name = string.Format("stvNum{0}", i);
                stv.SetTenSach(stv.Name);
                fpnlHienThi.Controls.Add(stv);
            }
        }
    }
}
