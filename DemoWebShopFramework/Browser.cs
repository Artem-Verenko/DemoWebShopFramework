using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace DemoWebShopFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new ChromeDriver(@"C:\CD");

        public static string Title 
        { 
            get { return webDriver.Title; } 
        }

        public static ISearchContext Driver 
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
            Thread.Sleep(1000);
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}