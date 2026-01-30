using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

[Binding]
public class HomeStep
{
    private HomePO homePO = new();

    [Then(@"User validate he is on the homescreen")]
    public void ValidateHomeScreen()
    {
        homePO.ValidateHomeScreen();
    }
}
