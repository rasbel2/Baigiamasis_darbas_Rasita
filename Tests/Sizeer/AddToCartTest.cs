using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class AddToCartTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            AddToCart.Open("https://sizeer.lt/");
        }

        [Test]
        public void AddCartTest()
        {
            CheckForCookiePopUp();

            AddToCart.HoverCategoryWomen();
            AddToCart.ClickCapsLink();
            AddToCart.ClickFirstItem(); 

            string firstItemName = AddToCart.GetFirstItemName();

            AddToCart.ClickAddToCartButton();
            AddToCart.WaitForSideCart();
            //AddToCart.ClickSideBarCloseButton();
            //AddToCart.WaitCartButton();
            //AddToCart.ClickCartButton();

            //AddToCart.Navigate("https://sizeer.lt/krepselis/sarasas");

            string cartItemName = AddToCart.GetCartItemName();

            Assert.AreEqual(firstItemName, cartItemName);
        }
    }
}
