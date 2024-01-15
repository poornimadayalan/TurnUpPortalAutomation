using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;

namespace TurnUpportalLogin.Pages

{
    public class Loginpage

    {

        public void LoginActions(IWebDriver driver)

        {
            //Launch TurnUp portal and navigate to website login page

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Identify username textbox and enter valid username

            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));

            userNameTextBox.SendKeys("hari");

            //Identify password textbox and enter valid password

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));

            passwordTextBox.SendKeys("123123");

            //Identify the login button and click on the button

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));

            loginButton.Click();


        }
    }
}
