using TurnUpportalLogin.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


public class Program
{
    public static void Main(string[] args)
    {
        //Open the Chrome browser

        IWebDriver driver = new ChromeDriver();

        //  Login Page initialization and definition

        Loginpage loginPageObj = new Loginpage();

        loginPageObj.LoginActions(driver);


        // Home Page initialization and definition

        HomePage homeObj = new HomePage();
        homeObj.GoToTMPage(driver);


        // Time and Material initialization and definition
        // TM Edit initialization and definition
        // TM Delete initialization and definition

        TimeAndMaterialPage timeAndMaterialObj = new TimeAndMaterialPage();

        timeAndMaterialObj.CreateTimeRecord(driver);
        timeAndMaterialObj.TMEdit(driver);
        timeAndMaterialObj.TMDelete(driver);

    }
}


