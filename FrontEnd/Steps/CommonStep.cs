using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

[Binding]
public class CommonStep
{
    private BasePO basePO;

    [Given(@"User is on the website ""(.*)"" on browser ""(.*)""")]
    public void VisitWebsite(string website, string browserName)
    {
        basePO = new(browserName);
        basePO.VisitWebsite(website);
    }
}