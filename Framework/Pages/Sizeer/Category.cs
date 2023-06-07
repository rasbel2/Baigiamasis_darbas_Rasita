namespace Framework.Pages.Sizeer
{
    public class Category
    {
        public static string GetHideDataButtonLabel()
        {
            return Common.GetElementText(Locators.Menu.hideFiltersButton);
        }
    }
}
