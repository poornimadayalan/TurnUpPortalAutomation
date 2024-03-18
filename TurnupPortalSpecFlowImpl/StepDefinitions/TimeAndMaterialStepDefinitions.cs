using System;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TurnupPortalSpecFlowImpl.Pages;
using TurnupPortalSpecFlowImpl.Utilities;

namespace TurnupPortalSpecFlowImpl.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialStepDefinitions : CommonDriver
    {

        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TimeandMaterialPage tMPageObj = new TimeandMaterialPage();

        IWebDriver driver = new ChromeDriver();

        [Given(@"I log into Turnup portal")]
        public void GivenILogIntoTurnupPortal()
        {
            loginPageObj.LoginActions(driver);

        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObj.GoToTimeandMaterialPage(driver);
        }

        [When(@"I create a new Time and Material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            tMPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the record should be saved")]
        public void ThenTheRecordShouldBeSaved()
        {
            tMPageObj.AssertCreateTMRecord(driver);
        }

        [When(@"I edit a new Time and Material record")]
        public void WhenIEditANewTimeAndMaterialRecord()
        {
            tMPageObj.EditTimeRecord(driver);
        }

        [When(@"I delete an existing Time and Material record")]
        public void WhenIDeleteAnExistingTimeAndMaterialRecord()
        {
            tMPageObj.DeleteTimeRecord(driver);
        }

        [Then(@"the record should be deleted")]
        public void ThenTheRecordShouldBeDeleted()
        {
            driver.Quit();
        }
    }

}