using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
public class DriverConfig
{
    private static DriverConfig? sharedInstance;
    private static readonly object _lock = new object();
    public IWebDriver driver { get; private set; }
    public WebDriverWait wait { get; private set; }

    public static DriverConfig shared(String browserName)
    {
        lock (_lock)
        {
            sharedInstance ??= new DriverConfig();

            if (sharedInstance.driver == null)
            {
                sharedInstance.DefaultConfig(browserName);
            }
            return sharedInstance;
        }
    }

    public static DriverConfig shared()
    {
        lock (_lock)
        {
            sharedInstance ??= new DriverConfig();
            return sharedInstance;
        }
    }

    public void DefaultConfig(string browser)
    {
        driver = (browser == "Chrome") ? new ChromeDriver() : new FirefoxDriver();
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        driver.Manage().Window.Maximize();
    }

    public void QuitDriver()
    {
        driver.Quit();
        driver = null;
        wait = null;
    }
}