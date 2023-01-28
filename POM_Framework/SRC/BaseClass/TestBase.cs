using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_Framework.SRC.BaseClass
{
    public class TestBase
    {
        static IWebDriver driver;
        public void Initialize()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\\Users\\yasar\\chromedriver\\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://sit-spa.accuv.com/");
        }

        public void TearDown()
        {
            driver.Close();
        }

    }
}
