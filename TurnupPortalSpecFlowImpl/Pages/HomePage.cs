using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TurnupPortalSpecFlowImpl.Pages
{
    public class HomePage
    {
        public void GoToTimeandMaterialPage(IWebDriver driver)
        {
            try
            {
                //Create new Time record
                //Click on administration and select time and materials

                driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("User clicked on Time and Materials");
            }
            catch (Exception exception)
            {
                Assert.Fail("Turnup portal to Time and material navigation was not successful");            
                Console.WriteLine(exception.Message);
            }
        }
        public void VerifyLoggedInUser(IWebDriver driver) 
        {
            //Check if user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("/html/body/div[3]/div/div/form/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("User has logged in Successfully");

            }

            else
            {
                Console.WriteLine("User hasn't been logged in");
            }
        }
    }
}
