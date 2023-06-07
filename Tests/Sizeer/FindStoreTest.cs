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
            string city = "Kaunas";
            string expectedCityLabel = "KAUNO MEGA SIZEER";

            FindStore.ClickStoreButton();
            FindStore.EnterStoreCity(city);
            string actualCityLabel = FindStore.GetStoreName();

            Assert.AreEqual(expectedCityLabel, actualCityLabel);
        }
    }
}
