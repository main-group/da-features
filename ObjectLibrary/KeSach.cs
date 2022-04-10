using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class KeSach
    {
        public int MaKeSach { get; set; }
        public string TenKeSach { get; set; }

        public KeSach() { }

        public KeSach(int maKeSach, string tenKeSach)
        {
            this.MaKeSach = maKeSach;
            this.TenKeSach = tenKeSach;
        }
    }
}
