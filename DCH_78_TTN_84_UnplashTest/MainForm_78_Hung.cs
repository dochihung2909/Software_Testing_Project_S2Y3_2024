using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace UnplashTest_78_Hung
{
    public partial class MainForm_78_Hung : Form
    {
        public MainForm_78_Hung()
        {
            InitializeComponent();
        }

        private void DCH_78_TTN_84_Login_btn_Click(object sender, EventArgs e)
        {
            ChromeDriverService DCH_78_TTN_84_chrome = ChromeDriverService.CreateDefaultService();
            DCH_78_TTN_84_chrome.HideCommandPromptWindow = true;
            IWebDriver DCH_78_TTN_84_Driver = new ChromeDriver(DCH_78_TTN_84_chrome); 
            DCH_78_TTN_84_Driver.Navigate().GoToUrl("https://unsplash.com/");
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Sử dụng XPath để xác định thẻ Log in
            DCH_78_TTN_84_Driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div[1]/div/header/nav/div[2]/div[3]/a")).Click();
            // Chở 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm thẻ Email và Password bằng name sau đó điền thông tin đăng nhập
            DCH_78_TTN_84_Driver.FindElement(By.Name("email")).SendKeys("2151053026hung@ou.edu.vn"); 
            DCH_78_TTN_84_Driver.FindElement(By.Name("password")).SendKeys("Itouedu123");
            // Tìm kiếm nút Login bằng CssSelector
            DCH_78_TTN_84_Driver.FindElement(By.CssSelector("button[value='Login']")).Click(); 
        }

        private void DCH_78_TTN_84_Search_btn_Click(object sender, EventArgs e)
        {
            ChromeDriverService DCH_78_TTN_84_chrome = ChromeDriverService.CreateDefaultService();
            DCH_78_TTN_84_chrome.HideCommandPromptWindow = true;
            IWebDriver DCH_78_TTN_84_Driver = new ChromeDriver(DCH_78_TTN_84_chrome);
            DCH_78_TTN_84_Driver.Navigate().GoToUrl("https://unsplash.com/");
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm ô search input
            DCH_78_TTN_84_Driver.FindElement(By.Name("searchKeyword")).SendKeys("Software testing");
            // Nhấn Nút Enter để thực hiện tìm kiếm
            Actions DCH_78_TTN_84_builder = new Actions(DCH_78_TTN_84_Driver); 
            DCH_78_TTN_84_builder.KeyDown(OpenQA.Selenium.Keys.Enter).Build().Perform();  
        }

        private void DCH_78_TTN_84_Upload_btn_Click(object sender, EventArgs e)
        {
            ChromeDriverService DCH_78_TTN_84_chrome = ChromeDriverService.CreateDefaultService();
            DCH_78_TTN_84_chrome.HideCommandPromptWindow = true;
            IWebDriver DCH_78_TTN_84_Driver = new ChromeDriver(DCH_78_TTN_84_chrome);
            DCH_78_TTN_84_Driver.Navigate().GoToUrl("https://unsplash.com/");
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000);
            // Tìm kiếm nút Submit a photo
            DCH_78_TTN_84_Driver.FindElement(By.LinkText("Submit a photo")).Click();
            // Chờ 2 giây để load trang web
            Thread.Sleep(2000); 
            // Tìm kiếm input file 
            IWebElement DCH_78_TTN_84_file = DCH_78_TTN_84_Driver.FindElement(By.CssSelector("input[type='file']"));
            DCH_78_TTN_84_file.SendKeys("hello");
        }
    }
}
