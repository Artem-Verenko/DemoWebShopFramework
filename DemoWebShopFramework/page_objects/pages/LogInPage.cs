using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace DemoWebShopFramework
{
    public class LogInPage
    {
        private static string Url = "http://demowebshop.tricentis.com/login";

        [FindsBy(How = How.XPath, Using = "//input[@name=\"Email\"]")]
        private IWebElement email;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"Password\"]")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        private IWebElement enterButton;

        public HomePage NewLogIn(string email, string password) 
        {

            this.email.SendKeys(email);
            this.password.SendKeys(password);
            this.enterButton.Click();         
            return new HomePage();
        }

        public void Goto()
        {
            Browser.Goto(Url);
        }
    }
}