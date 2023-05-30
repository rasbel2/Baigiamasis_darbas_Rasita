namespace Framework.Pages.Sizeer
{
    internal class Locators
    {
        internal class CookiePopUp
        {
            internal static string buttonOk = "//*[@id='onetrust-accept-btn-handler']";
            internal static string cookiePopUp = "//*[@id='onetrust-banner-sdk']";
        }
        
        internal class UserSignIn
        {
            internal static string profileInButton = "//*[@class='b-userMenu_item b-userMenu_itemUser']";
            internal static string enterMailField = "//*[@id='enp_customer_form_login_username']";
            internal static string enterPasswordField = "//*[@id='enp_customer_form_login_password']";
            internal static string submitButton = "//*[@id='_submit']";
            internal static string yourDataMassage = "//*[@class='s-subheadlineMedium g-pb10']";
        }

        internal class Category
        {
            internal static string categoryTshirts = "//*[@class='m-menu_subItem js-menu_subItemData']/a[@href='/moterims/apranga/marskineliai']";
            internal static string hideFiltersButton = "//*[@class='m-toolbar js-listingForm']/a[@data-hide='Slėpti filtrus']";
            internal static string categoryWomen = "//*[@class='m-menu_item js-menu_item js-menu_itemData' and @data-name='Moterims']";

        }

        internal class AddToCart
        {
            internal static string categoryCaps = "//*[@class='m-menu_subItem js-menu_subItemData']/a[@href='/moterims/aksesuarai/kepures']";
            internal static string firstItem = "//*[@id='js-offerList']/div/div/div/a";
            internal static string addToCartButton = "//a[@class='m-btn m-btn_primary js-pre-add-cart']";
            internal static string itemName = "//h1[@class='m-productDescr_headline js-offerTooltip_call']";
            internal static string cartItemName = "//*[contains(@class, 'm-cartList_itemProductName')]/a";
            internal static string cartSlideBarClose = "//*[@class='b-cartSlidebar_close js-cartSlidebar_close']";
            internal static string cartNavigationButton = "//*[@class='b-userMenu_item sb-toggle-right b-userMenu_itemCart']";
        }
        
        internal class LanguageChange
        {
            internal static string languageListArrowId = "language-desktop";
            internal static string languageSelectFlagHref = "https://sizeer.de/";
            internal static string languageIdentifier = "//*[@class='b-userMenu_item b-userMenu_itemUser']/span[@class='b-userMenu_name js-header_loginDE']";

        }

        internal class StoreAddress
        {
            internal static string storeListButton = "//a[contains(@class, 's-headerInfo_item') and @href='https://sizeer.lt/parduotuves']";
            internal static string findStoreField = "//*[@id='js-storefinder_search']";
            internal static string storeIdentifier = "//li[@data-marker='59']/p[@class='m-storeFinder_listName js-storefinder_listName']";
        }

    }
}
