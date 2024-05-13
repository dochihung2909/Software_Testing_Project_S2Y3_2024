using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Test_78_Hung
{
    [TestClass]
    public class TestLogin_78_Hung
    {
        private ChromeDriverService chrome_78_Hung; 
        private IWebDriver Driver_78_Hung;
        public TestContext TestContext { get; set; }
        [TestInitialize] 
        public void Init() 
        {
            chrome_78_Hung = ChromeDriverService.CreateDefaultService();
            chrome_78_Hung.HideCommandPromptWindow = true;
            Driver_78_Hung = new ChromeDriver(chrome_78_Hung);
            Driver_78_Hung.Navigate().GoToUrl("https://unsplash.com/");
        }
        [TestMethod]
        public void TC1_Login_Success_78_Hung()
        { 
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Sử dụng XPath để xác định thẻ Log in
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"app\"]/div/div[1]/div/header/nav/div[2]/div[3]/a")).Click();
            Assert.AreEqual(Driver_78_Hung.Url, "https://unsplash.com/login?referrer=%2F"); 
            // Chở 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm thẻ Email và Password bằng name sau đó điền thông tin đăng nhập
            string username = "2151053026hung@ou.edu.vn";
            string password = "Itouedu123";

            Driver_78_Hung.FindElement(By.Name("email")).SendKeys(username);
            Driver_78_Hung.FindElement(By.Name("password")).SendKeys(password);
            // Tìm kiếm nút Login bằng CssSelector
            Driver_78_Hung.FindElement(By.CssSelector("button[value='Login']")).Click();
            // Kiểm tra đăng nhập thành công hay chưa
            Thread.Sleep(2000);
            Assert.IsTrue(Driver_78_Hung.FindElement(By.Id("popover-avatar-loggedin-menu")).Displayed); 
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\DataLogin.csv",
            "DataLogin#csv", DataAccessMethod.Sequential)]   
        [TestMethod]
        public void TestCase2_3_4_5_Login_Fail_78_Hung()
        {
            string email = TestContext.DataRow[0].ToString(); 
            string password = TestContext.DataRow[1].ToString();

            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Sử dụng XPath để xác định thẻ Log in
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"app\"]/div/div[1]/div/header/nav/div[2]/div[3]/a")).Click();
            Assert.AreEqual(Driver_78_Hung.Url, "https://unsplash.com/login?referrer=%2F");
            // Chở 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm thẻ Email và Password bằng name sau đó điền thông tin đăng nhập  
            Driver_78_Hung.FindElement(By.Name("email")).SendKeys(email);
            Driver_78_Hung.FindElement(By.Name("password")).SendKeys(password);
            // Tìm kiếm nút Login bằng CssSelector
            Driver_78_Hung.FindElement(By.CssSelector("button[value='Login']")).Click();
            // Kiểm tra đăng nhập thất bại
            Thread.Sleep(2000);
            Assert.IsTrue(Driver_78_Hung.FindElement(By.ClassName("ESPog")).Displayed);
        }
    }
}
