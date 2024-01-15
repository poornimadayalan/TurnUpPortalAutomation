using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TurnUpportalLogin.Pages

{
    public class HomePage

    {

        public void GoToTMPage(IWebDriver driver)

        {

            // 2. Time and Material module
            //------------------------------------------------------------------------------
            // Navigate to Administration Module

            System.Console.WriteLine("Start Automation - Time and Material module");

            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));

            administrationDropdown.Click();


            // Select Time and Material Module

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));

            tmOption.Click();

            Thread.Sleep(5000);


        }

    }



}
