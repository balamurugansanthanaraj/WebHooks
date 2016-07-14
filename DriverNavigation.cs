using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralTest.WebUI.Framework
{
    public static class DriverNavigation
    {
        
        static DriverNavigation()
        {
            Driver.Initialize();
        }

        public static void Navigate(string URL)
        {
            if (Driver.WebDriverInstance == default(object))
            {
                throw new NullReferenceException("WebDriver instance is null");
            }

            Driver.WebDriverInstance.Navigate().GoToUrl(URL);
        }

    }
}
