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
    public partial class SachThuVien : UserControl
    {
        public SachThuVien()
        {
            InitializeComponent();
        }

        public void SetTenSach(string tenSach)
        {
            lblTenSach.Text = tenSach;
        }
    }
}
