namespace Framework.Pages.Sizeer
{
    public class FindStore
    {
        public static void ClickStoreButton()
        {
            Common.ClickElement(Locators.StoreAddress.storeListButton);
        }
        public static void EnterStoreCity(string storeCity)
        {
          Common.SendKeys(Locators.StoreAddress.findStoreField, storeCity);
          Common.PressEnter(Locators.StoreAddress.findStoreField);
        }
        public static string GetStoreName()
        {
            return Common.GetElementText(Locators.StoreAddress.storeIdentifier);
        }
    }
}
