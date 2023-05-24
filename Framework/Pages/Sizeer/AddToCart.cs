namespace Framework.Pages.Sizeer
{
    public class AddToCart : BaseSection
    {
        public static void ClickCapsLink()
        {
            Common.ClickElement(Locators.AddToCart.categoryCaps);
        }
        public static void ClickFirstItem()
        {
            Common.ClickElement(Locators.AddToCart.firstItem);
        }
        public static string GetFirstItemName()
        {
           return Common.GetElementText(Locators.AddToCart.itemName);
        }
        public static void ClickAddToCartButton()
        {
            Common.ClickElement(Locators.AddToCart.addToCartButton);
        }
        public static string GetCartItemName()
        {
            return Common.GetElementText(Locators.AddToCart.cartItemName);
        }
        public static void WaitForSideCart()
        {
            Common.WaitForElementToBeVisible(Locators.AddToCart.cartSlideBarClose);

        }
        public static void ClickSideBarCloseButton()
        {
            Common.ClickElement(Locators.AddToCart.cartSlideBarClose);
        }
        public static void ClickCartButton()
        {
            Common.ClickElement(Locators.AddToCart.cartNavigationButton);
        }
        public static void WaitCartButton()
        {
            Common.WaitForElementToBeVisible(Locators.AddToCart.cartNavigationButton);

        }
    }
}
