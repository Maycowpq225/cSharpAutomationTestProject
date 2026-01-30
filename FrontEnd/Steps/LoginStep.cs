using TechTalk.SpecFlow;
using OpenQA.Selenium;

[Binding]
public class LoginStep
{    private LoginPO loginPO = new();

    [When(@"User enter with the username ""(.*)"" and password ""(.*)""")]
    public void LoginWith(string username, string password)
    {
        loginPO.SetUsername(username);
        loginPO.SetPassword(password);
        loginPO.ClickLogin();
    }
}
