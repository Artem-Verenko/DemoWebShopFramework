using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoWebShopFramework
{
    public class СategoryPage
    {
        
        [FindsBy(How = How.XPath, Using = "//div[@class=\"page-title\"]", Priority = 0)]
        [FindsBy(How = How.ClassName, Using = "page-title", Priority = 1)]
        private IWebElement categoryName;
        public string CategoryName 
        {
            get { return this.categoryName.Text; }  
        }
    }
}
