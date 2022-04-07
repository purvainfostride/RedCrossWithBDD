using OpenQA.Selenium;

namespace RedCrossWithBDD.Pages
{
    public class BasePage
    {
        public static WebDriver driver;
        public string url = "https://giftshop.redcross.org.uk/";
        public string homePageUrl = "https://giftshop.redcross.org.uk/challenge";
        public string loginPageUrl = "https://giftshop.redcross.org.uk/account/login";
        public string newInPageUrl = "https://giftshop.redcross.org.uk/collections/new-in";
        public string virtualGiftsPageUrl = "https://giftshop.redcross.org.uk/collections/virtual-giving";
        public string salePageUrl= "https://giftshop.redcross.org.uk/collections/sale";
        public string cartPageUrl = "https://giftshop.redcross.org.uk/cart";
        
    }
}
