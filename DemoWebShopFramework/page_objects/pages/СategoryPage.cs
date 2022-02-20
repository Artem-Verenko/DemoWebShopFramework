using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoWebShopFramework
{
    public class СategoryPage
    {
        
        
        [FindsBy(How = How.ClassName, Using = "page-title")]
        private IWebElement _categoryName;
        public string CategoryName 
        {
            get { return _categoryName.Text; }  
        }
    }
}
