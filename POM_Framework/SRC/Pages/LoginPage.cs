using Docker.DotNet.Models;
using OpenQA.Selenium;
using POM_Framework.SRC.BaseClass;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_Framework.SRC.Pages
{
    public class LoginPage: TestBase
    {
        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        public IWebElement username;

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//input[@value='Next']")]
        public IWebElement nextBtn;

        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        public IWebElement loginBtn;

        public LoginPage()
        {
        }

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void LoginToWebApp(string un, string pwd)
        {
            username.SendKeys(un);
            nextBtn.Click();
            password.SendKeys(pwd);
            loginBtn.Click();
  
        }
    }

    
}
