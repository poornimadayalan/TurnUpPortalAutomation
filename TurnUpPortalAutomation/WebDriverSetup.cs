using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverSetup
{
    public static IWebDriver InitializeWebDriver()
    {
        ChromeOptions options = new ChromeOptions();
        IWebDriver driver = new ChromeDriver(options);
        return driver;
    }
}
    