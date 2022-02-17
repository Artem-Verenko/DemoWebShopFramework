using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;

namespace DemoWebShopFramework
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }
        public static LogInPage LogInPage
        {
            get
            {
                var loginPage = new LogInPage();
                PageFactory.InitElements(Browser.Driver, loginPage);
                return loginPage;
            }
        }

        public static RegisterPage RegisterPage
        {
            get
            {
                var registerPage = new RegisterPage();
                PageFactory.InitElements(Browser.Driver, registerPage);
                return registerPage;
            }
        }

        public static СategoryPage СategoryPage
        {
            get
            {
                var categoryPage = new СategoryPage();
                PageFactory.InitElements(Browser.Driver, categoryPage);
                return categoryPage;
            }
        }

    }
}
