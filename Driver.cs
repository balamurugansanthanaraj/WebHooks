using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralTest.WebUI.Framework
{
    public class Driver
    {
        
        public static IWebDriver WebDriverInstance { get; private set; }

        public static void Initialize()
        {
            if (WebDriverInstance == default(IWebDriver))
            {
                WebDriverInstance = new ChromeDriver();
                //WebDriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                WebDriverInstance.Manage().Window.Maximize();
            }
            
        }

        public static void Close()
        {
            if (WebDriverInstance == default(IWebDriver)) return;

            WebDriverInstance.Close();
        }

        public static void Quit()
        {
            if (WebDriverInstance == default(IWebDriver)) return;

            WebDriverInstance.Quit();
        }

        //public static void Navigate(string URL)
        //{
        //    if (WebDriverInstance == default(IWebDriver))
        //    {
        //        throw new NullReferenceException("WebDriver instance is null");
        //    }

        //    WebDriverInstance.Navigate().GoToUrl(URL);

        //}
    }
}
