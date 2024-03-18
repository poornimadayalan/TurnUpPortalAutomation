using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TurnupPortalSpecFlowImpl.Pages
{
    public class LoginPage
    {

        public void LoginActions(IWebDriver driver)
        {
            //Maximize the browswer
            driver.Manage().Window.Maximize();

            //Launch Turnup Portal and Navigate to Website Login Page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Identify username textbox and enter valid username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //Identify password textbox and enter valid password.
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //Identify the login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/section/form/div[3]/input[1]"));
            loginButton.Click();
        }
            
    }
}
