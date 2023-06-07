using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class CategoriesTest : BaseTest
    {
        [Test]
        public void CategoryTest()
        {
            string expectedHideFiltersButton = "SLĖPTI FILTRUS";

            Menu.ClickCategoryByName(Menu.MenuNames.Moterims, Menu.CategoryNames.Marskineliai);
            string actualHideFiltersButton = Category.GetHideDataButtonLabel();

            Assert.AreEqual(expectedHideFiltersButton, actualHideFiltersButton);
        }
    }
}
