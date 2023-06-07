namespace Framework.Pages.Sizeer
{
    public class Category
    {
        public static void ClickTshirtsLink()
        {
            Common.WaitForElementToBeClickable(Locators.Category.categoryTshirts);
            Common.ClickElement(Locators.Category.categoryTshirts);
        }

        public static string GetHideDataButtonLabel()
        {
            return Common.GetElementText(Locators.Category.hideFiltersButton);
        }

    }
}
