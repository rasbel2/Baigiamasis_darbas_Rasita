namespace Framework.Pages.Sizeer
{
    public class Category : BaseSection
    {
        public static void ClickTshirtsLink()
        {
            Common.ClickElement(Locators.Category.categoryTshirts);
        }

        public static string GetHideDataButtonLabel()
        {
            return Common.GetElementText(Locators.Category.hideFiltersButton);
        }

    }
}
