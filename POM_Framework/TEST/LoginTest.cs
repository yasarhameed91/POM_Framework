using NUnit.Framework;
using POM_Framework.SRC.BaseClass;
using POM_Framework.SRC.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_Framework.TEST
{
    public class LoginTest:TestBase
    {
        LoginPage lp;
        
        [SetUp]
        public void SetUp()
        {
            Initialize();
            lp = new LoginPage();


        }

        [Test]
        public void LoginPageTest()
        {
            lp.LoginToWebApp("yasar.hameed@accuv.com", "P@ssw0rd");

        }





        [TearDown]
        public void CloseBrowser()
        {
            TearDown();
        }

    }
}
