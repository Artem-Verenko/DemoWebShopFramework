using DemoWebShopFramework.page_objects.app;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;

namespace DemoWebShopFramework
{
    public class HomePage
    {
        private static string Url = "http://demowebshop.tricentis.com/";

        [FindsBy(How = How.ClassName, Using = "ico-register")]
        private IWebElement _registerButton;

        [FindsBy(How = How.ClassName, Using = "ico-login")]
        private IWebElement _logInButton;

        [FindsBy(How = How.ClassName, Using = "account")]
        private IWebElement _currentLogin;

        public void Goto()
        {
            Browser.Goto(Url);
            WaitUtil.ShouldLocate(Browser.Driver, Url);
        }
        public string GetTitlePage()
        {
            return Browser.Title.Trim();
        }

        public void SelectСategory(string categoriesName)
        {
            var category = Browser.Driver.FindElement(By.XPath("//ul[@class=\"top-menu\"]//*[contains(text(),\"" + categoriesName +"\")]"));
            category.Click();
        }      
     
        public RegisterPage Register()
        {
            _registerButton.Click();
            return new RegisterPage();
        }        

        public string GetCurrentLogin() {
            return _currentLogin.Text.Trim();
        }
    }
}
