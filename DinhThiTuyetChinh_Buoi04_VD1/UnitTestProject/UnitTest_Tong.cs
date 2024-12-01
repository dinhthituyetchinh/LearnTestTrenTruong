using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest_Tong
    {
        [TestMethod]
        public static void TC1_testTongHaiSoNguyen()
        {
            SoNguyen dt = new SoNguyen(5, 7);
            int Result_Actual = dt.tinhTong();
            int Result_Expect = 12;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }

        [TestMethod]
        public static void TC2_testTongHaiSoNguyen()
        {
            SoNguyen dt = new SoNguyen(2, 7);
            int Result_Actual = dt.tinhTong();
            int Result_Expect = 12;
            Assert.AreEqual(Result_Expect, Result_Actual);
        }
    }
}
