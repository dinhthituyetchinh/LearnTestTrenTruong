using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class SoNguyen
    {
       public SoNguyen(int soThuNhat, int soThuHai)
       {
           this.A = soThuNhat;
           this.B = soThuHai;
       }
        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        private int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }

       public int tinhTong()
        {
            return A + B;
        }
    }
}
