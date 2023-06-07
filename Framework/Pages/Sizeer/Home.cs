namespace Framework.Pages.Sizeer
{
    public class Home
    {
        public static void ClickCookieOkButton()
        {
            Common.WaitForElementToBeVisible(Locators.CookiePopUp.cookiePopUp);
            Common.ClickElement(Locators.CookiePopUp.buttonOk);
        }
    }
}
