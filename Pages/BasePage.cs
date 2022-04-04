using OpenQA.Selenium;

namespace RedCrossWithBDD.Pages
{
    public class BasePage
    {
        public static WebDriver driver;
        public static string url = "https://giftshop.redcross.org.uk/";
        public static string homePageUrl = "https://giftshop.redcross.org.uk/challenge";
        public static string loginPageUrl = "https://giftshop.redcross.org.uk/account/login";
        
    }
}
