using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace Test_78_Hung
{ 
    [TestClass]
    public class TestUpload_78_Hung
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
        public void UL_TC1_Upload_Success_78_Hung()
        {
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"app\"]/div/div[1]/div/header/nav/div[2]/div[3]/a")).Click();
            // Chở 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm thẻ Email và Password bằng name sau đó điền thông tin đăng nhập
            Driver_78_Hung.FindElement(By.Name("email")).SendKeys("2151053026hung@ou.edu.vn");
            Driver_78_Hung.FindElement(By.Name("password")).SendKeys("Itouedu123");
            // Tìm kiếm nút Login bằng CssSelector
            Driver_78_Hung.FindElement(By.CssSelector("button[value='Login']")).Click();
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm nút Submit a photo
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"app\"]/div/div[1]/div/header/nav/div[2]/div[3]/button")).Click();
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm nút Start Uploading 
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"modal-portal\"]/div/div/div/div[2]/div/form/button")).Click();
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm input file 
            IWebElement file_78_Hung = Driver_78_Hung.FindElement(By.CssSelector("input[type='file']"));
            // Lấy đường dẫn ảnh hợp lệ 
            string filepath = @"Media\successimage.jpg";
            DirectoryInfo project_directory_info_78_Hung = new DirectoryInfo(Directory.GetCurrentDirectory());
            filepath = Path.Combine(project_directory_info_78_Hung.Parent.Parent.FullName, filepath);
            file_78_Hung.SendKeys(filepath);
            // Chờ 20 giây để load ảnh lên
            Thread.Sleep(20000);
            // Bấm nút Submit ảnh
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"modal-portal\"]/div/div/div/div[2]/div/div/form/div[2]/div[2]/button[2]")).Click();
            // Chờ 5 giây để quá trình xử lý upload ảnh
            Thread.Sleep(5000);
            // Kiểm tra upload ảnh thành công
            Assert.IsTrue(Driver_78_Hung.FindElement(By.CssSelector(".KEvrr.dgYec")).Displayed);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\DataUpload.csv",
           "DataUpload#csv", DataAccessMethod.Sequential)] 
        [TestMethod]
        public void UL_TC2_3_4_Upload_Fail_78_Hung()
        {
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"app\"]/div/div[1]/div/header/nav/div[2]/div[3]/a")).Click();
            // Chở 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm thẻ Email và Password bằng name sau đó điền thông tin đăng nhập
            Driver_78_Hung.FindElement(By.Name("email")).SendKeys("2151053026hung@ou.edu.vn");
            Driver_78_Hung.FindElement(By.Name("password")).SendKeys("Itouedu123");
            // Tìm kiếm nút Login bằng CssSelector
            Driver_78_Hung.FindElement(By.CssSelector("button[value='Login']")).Click();
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm nút Submit a photo
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"app\"]/div/div[1]/div/header/nav/div[2]/div[3]/button")).Click();
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm nút Start Uploading 
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"modal-portal\"]/div/div/div/div[2]/div/form/button")).Click(); 
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm input file 
            IWebElement file_78_Hung = Driver_78_Hung.FindElement(By.CssSelector("input[type='file']"));
            // Đọc dữ liệu từ file DataUpload để lấy filepath của các ảnh
            string filepath = TestContext.DataRow[0].ToString();
            DirectoryInfo project_directory_info_78_Hung = new DirectoryInfo(Directory.GetCurrentDirectory());
            filepath = Path.Combine(project_directory_info_78_Hung.Parent.Parent.FullName, filepath);
            file_78_Hung.SendKeys(filepath);
            // Chờ 20 giây để load ảnh lên
            Thread.Sleep(20000);  
            // Bấm nút Submit ảnh
            Driver_78_Hung.FindElement(By.XPath("//*[@id=\"modal-portal\"]/div/div/div/div[2]/div/div/form/div[2]/div[2]/button[2]")).Click();
            // Chờ 5 giây để quá trình xử lý upload ảnh
            Thread.Sleep(5000);
            // Kiểm tra upload ảnh thất bại 
            Assert.IsTrue(Driver_78_Hung.FindElement(By.CssSelector(".TsXcy")).Displayed);
        }
    }
}
