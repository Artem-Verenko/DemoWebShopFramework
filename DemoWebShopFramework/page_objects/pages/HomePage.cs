using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;

namespace DemoWebShopFramework
{
    public class HomePage
    {
        private static string Url = "http://demowebshop.tricentis.com/";
        private static string PageTitle = "Demo Web Shop";

        [FindsBy(How = How.XPath, Using = "//a[@class=\"ico-register\"]")]
        private IWebElement registerButton;

        [FindsBy(How = How.XPath, Using = "//a[@class=\"ico-login\"]")]
        private IWebElement logInButton;

        [FindsBy(How = How.ClassName, Using = "account")]
        private IWebElement currentLogin;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectСategory(string categoriesName)
        {
            var category = Browser.Driver.FindElement(By.XPath("//ul[@class=\"top-menu\"]//*[contains(text(),\"" + categoriesName +"\")]"));
            category.Click();
        }

        public bool IsAtСategoryPage(string categoryName)
        {
            var categoryPage = new СategoryPage();
            PageFactory.InitElements(Browser.Driver, categoryPage);
            return categoryPage.CategoryName == categoryName;
        }
     
        public RegisterPage Register()
        {
            this.registerButton.Click();
            return new RegisterPage();
        }

        public LogInPage LogIn()
        {
            this.logInButton.Click();
            return new LogInPage();
        }

        public bool IsAtCurrentLogin(string currentLogin)
        {
            return this.currentLogin.Text == currentLogin;
        }

    }
}
