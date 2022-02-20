using DemoWebShopFramework.page_objects.app;
using OpenQA.Selenium;
using System.Threading;

namespace DemoWebShopFramework
{
    public class RegisterPage
    {
        private readonly By _firstName = By.Id("FirstName");
        private readonly By _lastName = By.Id("LastName");
        private readonly By _email = By.Id("Email");
        private readonly By _password = By.Id("Password");
        private readonly By _confirmPassword = By.Id("ConfirmPassword");
        private readonly By _enterButton = By.Id("register-button"); 
        private readonly By _confirmButton = By.ClassName("register-continue-button");


        public RegisterPage setFirstName(string firstName) {
            WaitUtil.WaitElementVisible(Browser.Driver, _firstName);
            Browser.Driver.FindElement(_firstName).SendKeys(firstName);
            return this;
        }
        public RegisterPage setLastName(string lastName)
        {
            Browser.Driver.FindElement(_lastName).SendKeys(lastName);
            return this;
        }
        public RegisterPage setEmail(string email)
        {
            Browser.Driver.FindElement(_email).SendKeys(email);
            return this;
        }
        public RegisterPage setPassword(string password)
        {
            Browser.Driver.FindElement(_password).SendKeys(password);
            return this;
        }
        public RegisterPage setConfirmPassword(string confirmPassword)
        {           
            Browser.Driver.FindElement(_confirmPassword).SendKeys(confirmPassword);
            return this;
        }
        public HomePage finishRegistration()
        {
            WaitUtil.WaitElementClickable(Browser.Driver, _enterButton);
            Browser.Driver.FindElement(_enterButton).Click();
            WaitUtil.WaitElementClickable(Browser.Driver, _confirmButton);
            Browser.Driver.FindElement(_confirmButton).Click();
            return new HomePage();
        }


        public HomePage NewRegister(string firstName, string lastName, string email, string password, string confirmPassword) {
            Browser.Driver.FindElement(_firstName).SendKeys(firstName);
            Browser.Driver.FindElement(_lastName).SendKeys(lastName);
            Browser.Driver.FindElement(_email).SendKeys(email);
            Browser.Driver.FindElement(_password).SendKeys(password);
            Browser.Driver.FindElement(_confirmPassword).SendKeys(confirmPassword);            
            Browser.Driver.FindElement(_enterButton).Click();         
            Browser.Driver.FindElement(_confirmButton).Click();
            return new HomePage();
        }

    }
}
