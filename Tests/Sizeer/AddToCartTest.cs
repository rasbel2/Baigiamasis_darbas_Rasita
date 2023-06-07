using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class AddToCartTest : BaseTest
    {
        [Test]
        public void AddCartTest()
        {
            Menu.ClickCategoryByName(Menu.MenuNames.Moterims, Menu.CategoryNames.Kepures);
            AddToCart.ClickFirstItem(); 
            string firstItemName = AddToCart.GetFirstItemName();
            AddToCart.ClickAddToCartButton();
            string cartItemName = AddToCart.GetCartItemName();

            Assert.AreEqual(firstItemName, cartItemName);
        }
    }
}
