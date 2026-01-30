using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Diagnostics;

public class BasePO
{

    public WebDriverWait wait;
    public IWebDriver driver;


    public BasePO(string browserName)
    {
        this.driver = DriverConfig.shared(browserName).driver;
        this.wait = DriverConfig.shared().wait;
    }

    public BasePO()
    {
        this.driver = DriverConfig.shared().driver;
        this.wait = DriverConfig.shared().wait;
    }

    public void VisitWebsite(string website)
    {
        driver.Navigate().GoToUrl(website);
    }

    public void ClickOnElement(By element)
    {
        wait.Until(ExpectedConditions.ElementIsVisible(element)).Click();
    }

    public void SendKeysToElement(By element, String key)
    {
        wait.Until(ExpectedConditions.ElementIsVisible(element)).SendKeys(key);
    }

    public void WaitElementIsVisible(By element)
    {
        wait.Until(ExpectedConditions.ElementIsVisible(element));
    }

    public By WaitElementIsClickable(By element)
    {
        wait.Until(ExpectedConditions.ElementToBeClickable(element));
        return element;
    }

    public void WaitElementIsClickableAndClick(By element, int timeoutSeconds)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < timeoutSeconds)
        {
            try
            {
                driver.FindElement(element).Click();
                timer.Stop();
            }
            catch (ElementClickInterceptedException e)
            {
                Console.WriteLine("Element not clickable at "
                        + timer.Elapsed.TotalSeconds
                        + " seconds");
                if (timer.Elapsed.TotalSeconds > 4) throw e;
            }
        }
    }
}