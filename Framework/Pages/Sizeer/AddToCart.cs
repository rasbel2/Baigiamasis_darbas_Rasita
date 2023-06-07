﻿namespace Framework.Pages.Sizeer
{
    public class AddToCart
    {
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
            string link = Common.GetElementAttribute(Locators.AddToCart.addToCartButton, "href");
            Common.Navigate(link);
        }

        public static string GetCartItemName()
        {
            return Common.GetElementText(Locators.AddToCart.cartItemName);
        }
    }
}
