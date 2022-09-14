using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class PhanSo
    {
        private int tu;
        private int mau;
        public PhanSo(int tu = 0, int mau = 1) {
            this.tu = tu;
            if (mau == 0)
                mau = 1;
            this.mau = mau;
        }
    }
}
