using OpenQA.Selenium;
using System.Threading;

namespace DemoWebShopFramework
{
    public class LogInPage
    {
        private readonly By email = By.XPath("//input[@name=\"Email\"]");
        private readonly By password = By.XPath("//input[@name=\"Password\"]");
        private readonly By enterButton = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input");


        public HomePage NewLogIn(string email, string password) 
        {
            Browser.Driver.FindElement(this.email).SendKeys(email);
            Browser.Driver.FindElement(this.password).SendKeys(password);
            Browser.Driver.FindElement(this.enterButton).Click();
            

            return new HomePage();
        }
    }
}