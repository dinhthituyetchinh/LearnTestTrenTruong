using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SoNguyen
    {
        public void timMaxMin(int A, int B, int C, out int max, out int min)
        {
            max = Math.Max(A, Math.Max(B, C));
            min = Math.Min(A, Math.Min(B, C));
        }
    }
}
