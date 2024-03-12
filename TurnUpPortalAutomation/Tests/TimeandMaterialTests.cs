using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Tests
{
    [TestFixture]
    public class TimeandMaterialTests: CommonDriver
    {
        IWebDriver driver = CommonDriver.InitializeWebDriver();

        [SetUp]
        public void SetUpTimeandMaterial()
        {
            //Login Page initialization and definition

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home Page initialization and definition

            HomePage homeObj = new HomePage();
            homeObj.VerifyLoggedInUser(driver);
            homeObj.GoToTimeandMaterialPage(driver);

        }

        //Test Case 1

        [Test, Order(1)]
        public void TestCreateTimeRecord()
        {
            //Time and Material initialization and definition
            TimeandMaterialPage timeAndMaterialObj = new TimeandMaterialPage();
            timeAndMaterialObj.CreateTimeRecord(driver);
        }

        //Test Case 2

        [Test, Order(2)]
        public void TestEditTimeRecord()
        {
            //TimeandMaterial Edit initialization and definition
            TimeandMaterialPage timeAndMaterialEditObj = new TimeandMaterialPage();
            timeAndMaterialEditObj.EditTimeRecord(driver);
        }

        //Test Case 3

        [Test, Order(3)]
        public void TestDeleteTimeRecord()
        {
            //TimeandMaterial Delete initialization and definition
            TimeandMaterialPage timeAndMaterialDelObj = new TimeandMaterialPage();
            timeAndMaterialDelObj.DeleteTimeRecord(driver);
        }

        //End of the test (It will end in teardown and again the test starts from the test 2 repeatedly until test 3 )
        [TearDown]
        public void CloseTest()
        {
        }
    }
}
