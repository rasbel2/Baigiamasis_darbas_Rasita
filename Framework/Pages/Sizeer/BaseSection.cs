namespace Framework.Pages.Sizeer
{
    public class BaseSection
    {
        public static void ClickCookieOkButton()
        {
            Common.WaitForElementToBeVisible(Locators.CookiePopUp.cookiePopUp);
            Common.ClickElement(Locators.CookiePopUp.buttonOk);
        }

        public static void Open(string url)
        {
            Driver.OpenUrl(url);
        }

        public static void Navigate(string url)
        {
            Common.Navigate(url);
        }

        public static void HoverCategoryWomen()
        {
            Common.HoverElement(Locators.Category.categoryWomen);
        }
    }
}
