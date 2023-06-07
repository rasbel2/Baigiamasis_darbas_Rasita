namespace Framework.Pages.Sizeer
{
    public class BaseSection
    {
        public static void ClickCookieOkButton()
        {
            Common.WaitForElementToBeVisible(Locators.CookiePopUp.cookiePopUp);
            Common.ClickElement(Locators.CookiePopUp.buttonOk);
        }

        public static void HoverCategoryWomen()
        {
            Common.HoverElement(Locators.Category.categoryWomen);
        }
    }
}
