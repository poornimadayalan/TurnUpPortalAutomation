using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open the Chrome browser

IWebDriver driver = new ChromeDriver();

// Login functionality
 
System.Console.WriteLine("Start Automation - Login functionality");

//Launch TurnUp portal and navigate to website login page

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify username textbox and enter valid username

IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
usernameTextBox.SendKeys("hari");

//Identify password textbox and enter valid password

IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");


//Identify the login button and click on the button

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

//Check if user has logged in successfully

IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (hellohari.Text == "Hello hari!")
{
    System.Console.WriteLine("User Hari is correctly logged in!");
}
else
{
    System.Console.WriteLine("Login failed for User Hari. Please try again.");
}

System.Console.WriteLine("End Automation - Login functionality");

