using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TurnupPortalSpecFlowImpl.Pages
{
    public class TimeandMaterialPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Click on "Create" and Pass Data and Save

            driver.FindElement(By.XPath("/html/body/div[4]/p/a")).Click();
            Thread.Sleep(1000);

            IWebElement typeCode = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]/span"));

            typeCode.Click();
            Thread.Sleep(1000);

            IWebElement dropdownbutton = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]/span/span[1]"));
            dropdownbutton.Click();
            Thread.Sleep(1000);

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Dya Automation 24");
            Thread.Sleep(1000);

            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Demo T&M");
            Thread.Sleep(1000);

            IWebElement pricePerUnit = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("20");
            Thread.Sleep(1000);


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Submit();
            Thread.Sleep(1000);
            Console.WriteLine("Time and Materials created and submitted");

           
        }

        public void AssertCreateTMRecord(IWebDriver driver) 
        {

            //Click on the lastpage icon and verify the data we submitted  


            IWebElement selectLastPage = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
            selectLastPage.Click();

            IWebElement savedData = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(savedData.Text.Equals("Dya Automation 24"), "Data not saved in Time and Materials");

        }
        public void EditTimeRecord(IWebDriver driver)

        {
            //Edit data

            IWebElement clickOnEditButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            clickOnEditButton.Click();

            IWebElement editCodeType = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]/span/span[2]/span"));
            editCodeType.Click();
            Thread.Sleep(1000);

            IWebElement selectDropDown = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]/span/span[1]"));
            selectDropDown.Click();
            Thread.Sleep(1000);

            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys("Dya123");
            Thread.Sleep(1000);

            IWebElement editDescription = driver.FindElement(By.Name("Description"));
            editDescription.Clear();
            editDescription.SendKeys("Edited Auto Code");
            Thread.Sleep(1000);

            IWebElement editPrice = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/form[1]/div[1]/div[4]/div[1]/span[1]/span[1]/input[1]"));
            Console.WriteLine("Trying to edit in Time and Materials" + editPrice);
            //editPrice.Clear();
            editPrice.SendKeys("15");
            Thread.Sleep(2000);

            IWebElement ClickSaveButton = driver.FindElement(By.Id("SaveButton"));
            ClickSaveButton.Submit();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

        }
        public void DeleteTimeRecord(IWebDriver driver)
        {
            //click on Delete button and retrieve the alert message 

            IWebElement clickDelete = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            clickDelete.Click();
            Thread.Sleep(1000);

            IAlert alert = driver.SwitchTo().Alert();

            string alertBox = alert.Text;
            Console.WriteLine("Alert box text" + alertBox);
            alert.Accept();
            driver.Quit();
        }

    }
}

