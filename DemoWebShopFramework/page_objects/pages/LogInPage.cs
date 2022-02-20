using DemoWebShopFramework.page_objects.app;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace DemoWebShopFramework
{
    public class LogInPage
    {
        private static string Url = "http://demowebshop.tricentis.com/login";

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement _email;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement _password;

        [FindsBy(How = How.ClassName, Using = "login-button")]
        private IWebElement _enterButton;

        public HomePage NewLogIn(string email, string password) 
        {
            _email.SendKeys(email);
            _password.SendKeys(password);
            _enterButton.Click();
            
            return new HomePage();
        }

        public void Goto()
        {
            Browser.Goto(Url);
            WaitUtil.ShouldLocate(Browser.Driver, Url);
        }
    }
}