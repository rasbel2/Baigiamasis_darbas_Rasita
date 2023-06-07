using System.ComponentModel;

namespace Framework.Pages.Sizeer
{
    public class Menu
    {
        public enum MenuNames
        {
            [Description("Moterims")]
            Moterims,
            [Description("Vyrams")]
            Vyrams,
        }

        public enum CategoryNames
        {
            [Description("Marškinėliai")]
            Marskineliai,
            [Description("Kepurės")]
            Kepures,
        }
        
        public static void HoverMenuByName(string menuName)
        {
            Common.HoverElement(Locators.Menu.MenuByName(menuName));
        }

        public static void ClickCategoryByName(MenuNames menuName, CategoryNames categoryName)
        {
            string menuNameString = Common.GetEnumDescriptionValue(menuName);
            string categoryNameString = Common.GetEnumDescriptionValue(categoryName);
            string categoryLocator = Locators.Menu.CategoryByName(menuNameString, categoryNameString);
            HoverMenuByName(menuNameString);
            Common.WaitForElementToBeClickable(categoryLocator);
            Common.ClickElement(categoryLocator);
        }
    }
}
