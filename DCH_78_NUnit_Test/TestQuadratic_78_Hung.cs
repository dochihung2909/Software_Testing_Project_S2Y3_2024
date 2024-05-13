using UnplashTest_78_Hung;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NUnit_Test_78_Hung
{
    [TestClass]
    public class TestQuadratic_78_Hung
    {
        public TestContext TestContext { get; set; }
         
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
