using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DinhThiTuyetChinh_Buoi04_Bai1TL;

namespace UnitTestProject
{
    [TestClass]
    public class KiemTraTamGiacTest
    {
        [TestMethod]
        public void TestTamGiacVuong()
        {
            Assert.AreEqual("Tam giác vuông", TamGiac.LoaiTamGiac(3, 4, 5));
        }

        [TestMethod]
        public void TestTamGiacDeu()
        {
            Assert.AreEqual("Tam giác đều", TamGiac.LoaiTamGiac(2, 2, 2));
        }

        [TestMethod]
        public void TestTamGiacCan()
        {
            Assert.AreEqual("Tam giác cân", TamGiac.LoaiTamGiac(2, 2, 3));
        }

        [TestMethod]
        public void TestTamGiacVuongCan()
        {
            Assert.AreEqual("Tam giác vuông cân", TamGiac.LoaiTamGiac(5,5, 5 * Math.Sqrt(2)));
        }

        [TestMethod]
        public void TestTamGiacThuong()
        {
            Assert.AreEqual("Tam giác thường", TamGiac.LoaiTamGiac(3, 5, 7));
        }

        [TestMethod]
        public void TestKhongPhaiTamGiac()
        {
            Assert.AreEqual("Không phải tam giác", TamGiac.LoaiTamGiac(1, 2, 3));
        }

    }
}
