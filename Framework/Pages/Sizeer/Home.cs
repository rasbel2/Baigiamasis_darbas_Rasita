namespace Framework.Pages.Sizeer
{
    public class Home
    {
        public static void ClickCookieOkButton()
        {
            Common.WaitForElementToBeVisible(Locators.CookiePopUp.cookiePopUp);
            Common.ClickElement(Locators.CookiePopUp.buttonOk);
        }

        public class Menu
        {
            public static void HoverMenuByName(string menuName)
            {
                Common.HoverElement(Locators.Menu.MenuByName(menuName));
            }

            public static void ClickCategoryByName(string menuName, string categoryName)
            {
                string categoryLocator = Locators.Menu.CategoryByName(menuName, categoryName);
                HoverMenuByName(menuName);
                Common.WaitForElementToBeClickable(categoryLocator);
                Common.ClickElement(categoryLocator);
            }
        }
    }
}
