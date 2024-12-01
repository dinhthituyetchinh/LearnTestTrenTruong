using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhThiTuyetChinh_Buoi04_Bai1TL
{
    public class TamGiac
    {

        public static string LoaiTamGiac(double a, double b, double c)
        {
            // Kiểm tra điều kiện tam giác hợp lệ
            if (a + b <= c || a + c <= b || b + c <= a)
            {
            return "Không phải tam giác";
            }

            // Kiểm tra tam giác đều
            if (a == b && b == c)
            {
            return "Tam giác đều";
            }

            // Kiểm tra tam giác cân
            if (a == b || b == c || a == c)
            {
                // Kiểm tra điều kiện tam giác vuông theo định lý Pythagoras
                double hypotenuse = Math.Max(a, Math.Max(b, c)); // Tìm cạnh huyền lớn nhất
                double side1 = (hypotenuse == a) ? b : a; // Hai cạnh còn lại
                double side2 = (hypotenuse == a) ? c : (hypotenuse == b ? c : b);

                // Kiểm tra điều kiện vuông cân (Pythagorean theorem)
                if (Math.Abs(Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(hypotenuse, 2)) < 0.0001)
                {
                    return "Tam giác vuông cân";
                }
            
                return "Tam giác cân";
            }

            // Kiểm tra tam giác vuông
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
            Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
            Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
            {
            return "Tam giác vuông";
            }

            // Nếu không thuộc loại nào ở trên, thì là tam giác thường
            return "Tam giác thường";
      }
    

    }
}
