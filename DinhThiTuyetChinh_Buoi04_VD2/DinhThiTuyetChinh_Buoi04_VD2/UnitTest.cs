using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
namespace DinhThiTuyetChinh_Buoi04_VD2
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TC1_TimMaxMin()
        {
            SoNguyen dt = new SoNguyen();
            int resultMax, resultMin;
            dt.timMaxMin(3,7,2, out resultMax, out resultMin);

            Assert.AreEqual(7, resultMax);
            Assert.AreEqual(3, resultMin);
        }

        [TestMethod]
        public void TC2_TimMaxMin()
        {
            SoNguyen dt = new SoNguyen();
            int resultMax, resultMin;
            dt.timMaxMin(3, 7, 2, out resultMax, out resultMin);

            Assert.AreEqual(7, resultMax);
            Assert.AreEqual(2, resultMin);
        }
    }
}
