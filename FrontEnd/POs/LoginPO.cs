using OpenQA.Selenium;

public class LoginPO : BasePO
{
    private By usernameField = By.CssSelector("#user-name");
    private By passwordField = By.CssSelector("#password");
    private By loginButton = By.CssSelector("#login-button");

    public void SetUsername(string username)
    {
        SendKeysToElement(usernameField, username);
    }

    public void SetPassword(string password)
    {
        SendKeysToElement(passwordField, password);
    }

    public void ClickLogin()
    {
        ClickOnElement(loginButton);
    }
}