
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TurnUpPortalAutomation.Utilities
{
    public class CommonDriver
    { 
        public static IWebDriver InitializeWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            
            IWebDriver driver = new ChromeDriver(options);

            return driver;
        }
    }

}






