using OpenQA.Selenium;
using System.Threading;

namespace DemoWebShopFramework
{
    public class RegisterPage
    {
        private readonly By firstName = By.XPath("//input[@name=\"FirstName\"]");
        private readonly By lastName = By.XPath("//input[@name=\"LastName\"]");
        private readonly By email = By.XPath("//input[@name=\"Email\"]");
        private readonly By password = By.XPath("//input[@name=\"Password\"]");
        private readonly By confirmPassword = By.XPath("//input[@name=\"ConfirmPassword\"]");
        private readonly By enterButton = By.XPath("//input[@name=\"register-button\"]"); 
        private readonly By confirmButton = By.ClassName("register-continue-button");


        public RegisterPage setFirstName(string firstName) {
            Browser.Driver.FindElement(this.firstName).SendKeys(firstName);
            return this;
        }
        public RegisterPage setLastName(string lastName)
        {
            Browser.Driver.FindElement(this.lastName).SendKeys(lastName);
            return this;
        }
        public RegisterPage setEmail(string email)
        {
            Browser.Driver.FindElement(this.email).SendKeys(email);
            return this;
        }
        public RegisterPage setPassword(string password)
        {
            Browser.Driver.FindElement(this.password).SendKeys(password);
            return this;
        }
        public RegisterPage setConfirmPassword(string confirmPassword)
        {
            Browser.Driver.FindElement(this.confirmPassword).SendKeys(confirmPassword);
            return this;
        }
        public HomePage finishRegistration()
        {
            Browser.Driver.FindElement(this.enterButton).Click();
            Thread.Sleep(1000);
            Browser.Driver.FindElement(confirmButton).Click();
            return new HomePage();
        }


        public HomePage NewRegister(string firstName, string lastName, string email, string password, string confirmPassword) {
            Browser.Driver.FindElement(this.firstName).SendKeys(firstName);
            Browser.Driver.FindElement(this.lastName).SendKeys(lastName);
            Browser.Driver.FindElement(this.email).SendKeys(email);
            Browser.Driver.FindElement(this.password).SendKeys(password);
            Browser.Driver.FindElement(this.confirmPassword).SendKeys(confirmPassword);            
            Browser.Driver.FindElement(this.enterButton).Click();         
            Browser.Driver.FindElement(confirmButton).Click();
            return new HomePage();
        }

    }
}
