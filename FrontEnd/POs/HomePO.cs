using OpenQA.Selenium;

public class HomePO : BasePO
{

    private By lblSwagLabsTitle = By.XPath("//div[text()='Swag Labs']");

    public void ValidateHomeScreen()
    {
        WaitElementIsVisible(lblSwagLabsTitle);
    }

}