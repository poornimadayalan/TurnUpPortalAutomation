using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



// 1. Login functionality
//------------------------------------------------------------------------------


System.Console.WriteLine("Start Automation - Login functionality");

//Open the Chrome browser

IWebDriver driver = new ChromeDriver();

//Launch TurnUp portal and navigate to website login page

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify username textbox and enter valid username

IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));

userNameTextBox.SendKeys("hari");

//Identify password textbox and enter valid password

IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));

passwordTextBox.SendKeys("123123");

Thread.Sleep(1000);

//Identify the login button and click on the button

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));

loginButton.Click();


//Check if user has logged in successfully

IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (hellohari.Text == "Hello hari!")
{
    System.Console.WriteLine("Login functionality: User Hari is correctly logged in!");
}
else
{
    System.Console.WriteLine("Login functionality: Login failed for User Hari. Please try again.");
}

System.Console.WriteLine("End Automation - Login functionality");


System.Console.WriteLine("------------------------------------------------------------------------------");


// 2. Time and Material module
//------------------------------------------------------------------------------
// Navigate to Administration Module

System.Console.WriteLine("Start Automation - Time and Material module");

IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));

administrationDropdown.Click();


// Select Time and Material Module

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));

tmOption.Click();

System.Console.WriteLine("Time and Material module: Click create new record button");

// Click on create new record

IWebElement createNewButton = driver.FindElement(By.XPath("/html/body/div[4]/p/a"));

createNewButton.Click();


// Enter details in the Time and Material module

// Select Type Code from drop down

IWebElement selectMainCodeDropdown = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]/span/span[1]"));

selectMainCodeDropdown.Click();

IWebElement typeCodeDropdown = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]"));

typeCodeDropdown.Click();


// Select Time from the Type Code Drropdown

IWebElement selectTypeCodeDropdown = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]/span/span[1]"));

selectTypeCodeDropdown.Click();

// Enter Code

IWebElement enterCode = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[2]/div/input"));

enterCode.SendKeys("Poornima auto record");

// Description

IWebElement enterDescription = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[3]/div/input"));

enterDescription.SendKeys("This is created for automation purpose.");

//Price

IWebElement enterPricePerunit = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span/input[1]"));

enterPricePerunit.SendKeys("56.78");

// Save file

IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));

saveButton.Click();

System.Console.WriteLine("Time and Material module: Created new record");


System.Console.WriteLine("Time and Material module: Go to last page");

Thread.Sleep(2000);

IWebElement goToTheLastPage = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));

Thread.Sleep(2000);

goToTheLastPage.Click();

// Verify the Created record is corrrect

IWebElement verifytheCreatedRecord = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[last()]/td[1]"));

System.Console.WriteLine("Time and Material module: Verify the created record");

System.Console.WriteLine("Time and Material module: Verify the last row name: " +verifytheCreatedRecord.Text.ToString());


if (verifytheCreatedRecord.Text == "Poornima auto record")
{
    System.Console.WriteLine("Time and Material module: New Record Created Sucessfully!");
}
else
{
    System.Console.WriteLine("Time and Material module: Failed! New record not created.");
}

System.Console.WriteLine("Time and Material module: Edit the created record");


//Click Edit Button

IWebElement clickEditButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

clickEditButton.Click();

Thread.Sleep(1000);


//Edit the Existing Record

// Edit Type Code

IWebElement changeTypeCodeDescription = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[2]/div/input"));

changeTypeCodeDescription.Clear();

changeTypeCodeDescription.SendKeys("Poorrnima Edited");


// Edit Description

IWebElement changeDescription = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[3]/div/input"));

changeDescription.Clear();

changeDescription.SendKeys("Edited Automation 2024");



// Edit Price

// IWebElement EditPricefield = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span"));

// EditPricefield.Clear();

// EditPricefield.SendKeys("20");



// Save the Edited Record


IWebElement savetheEditedRecord = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[7]/input"));

savetheEditedRecord.Click();

System.Console.WriteLine("Time and Material module: Save the edited record");


Thread.Sleep(2000);


//Before deleting go to the last page

System.Console.WriteLine("Time and Material module: go to the last page for deleting the record");


IWebElement goToLastPageDeleteButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));

goToLastPageDeleteButton.Click();

Thread.Sleep(1000);


// Delete the Edited Record

IWebElement deletetheEditedRecord = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));

deletetheEditedRecord.Click();

Thread.Sleep(2000);

System.Console.WriteLine("Time and Material module: Deleted the record");


// Accept the alert (click OK)

IAlert alert = driver.SwitchTo().Alert();

Thread.Sleep(2000);

alert.Accept();

// QUIT 

driver.Quit();

System.Console.WriteLine("Time and Material module: Closed the record");


System.Console.WriteLine("End Automation - Time and Material module");


System.Console.WriteLine("------------------------------------------------------------------------------");


