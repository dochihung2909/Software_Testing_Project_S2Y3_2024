using UnplashTest_78_Hung;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NUnit_Test_78_Hung
{
    [TestClass]
    public class TestQuadratic_78_Hung
    {
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void TC1_MotNghiem_78_Hung()
        {
            double a_78_Hung = 0;
            double b_78_Hung = 2;
            double c_78_Hung = 3;
            string expected_78_Hung = "Phuong trinh co mot nghiem x = -1.5";

            Quadratic_78_Hung quad_78_Hung = new Quadratic_78_Hung(a_78_Hung, b_78_Hung, c_78_Hung);

            string result_78_Hung = quad_78_Hung.Solve_78_Hung();
            Assert.AreEqual(result_78_Hung, expected_78_Hung);
        }

        [TestMethod]
        public void TC2_VoNghiem_78_Hung()
        {
            double a_78_Hung = 0;
            double b_78_Hung = 0;
            double c_78_Hung = 2;
            string expected_78_Hung = "Phuong trinh vo nghiem";

            Quadratic_78_Hung quad_78_Hung = new Quadratic_78_Hung(a_78_Hung, b_78_Hung, c_78_Hung);

            string result_78_Hung = quad_78_Hung.Solve_78_Hung();
            Assert.AreEqual(result_78_Hung, expected_78_Hung);
        }

        [TestMethod]
        public void TC3_VoSoNghiem_78_Hung()
        {
            double a_78_Hung = 0;
            double b_78_Hung = 0;
            double c_78_Hung = 0;
            string expected_78_Hung = "Phuong trinh vo so nghiem";

            Quadratic_78_Hung quad_78_Hung = new Quadratic_78_Hung(a_78_Hung, b_78_Hung, c_78_Hung);

            string result_78_Hung = quad_78_Hung.Solve_78_Hung();
            Assert.AreEqual(result_78_Hung, expected_78_Hung);
        }   

        [TestMethod]
        public void TC4_NghiemPhanBiet_78_Hung()
        {
            double a_78_Hung = 1;
            double b_78_Hung = -3;
            double c_78_Hung = 2;
            string expected_78_Hung = "Phuong trinh co hai nghiem phan biet x1 = 2 x2 = 1";

            Quadratic_78_Hung quad_78_Hung = new Quadratic_78_Hung(a_78_Hung, b_78_Hung, c_78_Hung);

            string result_78_Hung = quad_78_Hung.Solve_78_Hung();
            Assert.AreEqual(result_78_Hung, expected_78_Hung);
        }

        [TestMethod]
        public void TC5_NghiemKep_78_Hung()
        {
            double a_78_Hung = 1;
            double b_78_Hung = -2;
            double c_78_Hung = 1;
            string expected_78_Hung = "Phuong trinh co nghiem kep x = 1";

            Quadratic_78_Hung quad_78_Hung = new Quadratic_78_Hung(a_78_Hung, b_78_Hung, c_78_Hung);

            string result_78_Hung = quad_78_Hung.Solve_78_Hung();
            Assert.AreEqual(result_78_Hung, expected_78_Hung);
        }

        [TestMethod]
        public void TC6_VoNghiem_78_Hung()
        {
            double a_78_Hung = 1;
            double b_78_Hung = 0;
            double c_78_Hung = 1;
            string expected_78_Hung = "Phuong trinh vo nghiem";

            Quadratic_78_Hung quad_78_Hung = new Quadratic_78_Hung(a_78_Hung, b_78_Hung, c_78_Hung);

            string result_78_Hung = quad_78_Hung.Solve_78_Hung();
            Assert.AreEqual(result_78_Hung, expected_78_Hung);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\DataUnitTestQuadratic.csv",
            "DataUnitTestQuadratic#csv", DataAccessMethod.Sequential)] 
        [TestMethod]
        public void TC1_2_3_4_5_6_78_Hung()
        {
            double a_78_Hung = double.Parse(TestContext.DataRow[0].ToString()); 
            double b_78_Hung = double.Parse(TestContext.DataRow[1].ToString()); 
            double c_78_Hung = double.Parse(TestContext.DataRow[2].ToString());
            string expected_78_Hung = TestContext.DataRow[3].ToString();

            Quadratic_78_Hung quad_78_Hung = new Quadratic_78_Hung(a_78_Hung, b_78_Hung, c_78_Hung);

            string result_78_Hung = quad_78_Hung.Solve_78_Hung();
            Assert.AreEqual(result_78_Hung, expected_78_Hung);
        }
    }
}
