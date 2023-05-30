namespace Framework.Pages.Sizeer
{
    public class BaseSection
    {
        public static string BaseUrl { get; set; }

        public static void ClickCookieOkButton()
        {
            Common.WaitForElementToBeVisible(Locators.CookiePopUp.cookiePopUp);
            Common.ClickElement(Locators.CookiePopUp.buttonOk);
        }

        public static void Open()
        {
            Driver.OpenUrl(BaseUrl);
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
