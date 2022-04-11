using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }

        public Sach() { }

        public Sach(int maSach, string tenSach)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
        }
    }
}
