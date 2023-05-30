using Framework.Pages.Sizeer;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Sizeer
{
    internal class FindStoreTest : BaseTest
    {
        [Test]
        public void StoreFindTest()
        {
            CheckForCookiePopUp();

            FindStore.ClickStoreButton();
            FindStore.EnterStoreCity("Kaunas");

            string expectedCityLabel = "KAUNO MEGA SIZEER";
            string actualCityLabel = FindStore.GetStoreName();

            Assert.AreEqual(expectedCityLabel, actualCityLabel);
        }
    }
}
