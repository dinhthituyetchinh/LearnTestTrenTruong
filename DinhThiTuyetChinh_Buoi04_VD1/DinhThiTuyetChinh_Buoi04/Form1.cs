using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Install Package: Install-Package MSTest.TestFramework -Version 1.4.0 (.NET Framework 4.5) 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;

namespace DinhThiTuyetChinh_Buoi04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttonKT.Click += buttonKT_Click;
        }

        void buttonKT_Click(object sender, EventArgs e)
        {
           
            try
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                int kq = int.Parse(textBoxKQ.Text);
                SoNguyen dt = new SoNguyen(a, b);
                int Result_Actual = dt.tinhTong();
                int Result_Expect = kq;

                Assert.AreEqual(Result_Expect, Result_Actual);

                lblKQTest.Text = "Test Passed";
            }
            catch (AssertFailedException ex)
            {
                lblKQTest.Text = "Test Failed";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
