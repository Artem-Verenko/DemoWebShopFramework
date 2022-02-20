using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoWebShopFramework
{
    public static class Browser
    {
        private static IWebDriver webDriver;
        public static WebDriverWait wait;

        public static void Init()
        {
            webDriver = new ChromeDriver(@"C:\CD");
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        public static string Title 
        { 
            get { return webDriver.Title; } 
        }

        public static IWebDriver Driver 
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}