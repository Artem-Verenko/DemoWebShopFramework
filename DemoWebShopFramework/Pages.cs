using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;

namespace DemoWebShopFramework
{
    public static class Pages
    {
        public static HomePage HomePage 
        {
            get 
            { 
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);              
                return homePage; 
            }  
        }


    }
}
