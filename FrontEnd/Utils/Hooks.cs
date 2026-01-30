using TechTalk.SpecFlow;
using OpenQA.Selenium;

[Binding]
public class Hooks
{
    [AfterScenario]
    public void TearDown()
    {
        DriverConfig.shared().QuitDriver();
    }
}