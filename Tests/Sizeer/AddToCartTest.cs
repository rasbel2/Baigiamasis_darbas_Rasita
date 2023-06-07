﻿using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class AddToCartTest : BaseTest
    {
        [Test]
        public void AddCartTest()
        {
            Home.Menu.ClickCategoryByName("Moterims", "Kepurės");
            AddToCart.ClickFirstItem(); 

            string firstItemName = AddToCart.GetFirstItemName();

            AddToCart.ClickAddToCartButton();

            string cartItemName = AddToCart.GetCartItemName();

            Assert.AreEqual(firstItemName, cartItemName);
        }
    }
}
