using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCrossWithBDD.Utility
{
    public class LinksUtility
    {
        public static WebDriver driver;
        public string url = "https://giftshop.redcross.org.uk/";
        public string homePageUrl = "https://giftshop.redcross.org.uk/challenge";
        public string loginPageUrl = "https://giftshop.redcross.org.uk/account/login";
        public string newInPageUrl = "https://giftshop.redcross.org.uk/collections/new-in";

        public string stationaryGreetingsPageUrl = "https://giftshop.redcross.org.uk/collections/greetings-cards";
        public string stationaryBirthdayCardPage = "https://giftshop.redcross.org.uk/collections/birthday-cards";
        public string stationaryCongratulationsCardPage = "https://giftshop.redcross.org.uk/collections/congratulations-cards";
        public string stationaryThankyouCardPage = "https://giftshop.redcross.org.uk/collections/thank-you-cards";
        public string stationaryWrappingPaperPage = "https://giftshop.redcross.org.uk/collections/wrapping-paper";
        public string stationaryNotebooksPage = "https://giftshop.redcross.org.uk/collections/notebooks";
        public string stationaryEnamelPinPage = "https://giftshop.redcross.org.uk/collections/enamel-pin-badges";

        public string virtualGiftsPageUrl = "https://giftshop.redcross.org.uk/collections/virtual-giving";
        public string salePageUrl = "https://giftshop.redcross.org.uk/collections/sale";
        public string cartPageUrl = "https://giftshop.redcross.org.uk/cart";
        public string newInPagesUrl = "https://giftshop.redcross.org.uk/collections/new-in?page=";
        public string greetingsPage="https://giftshop.redcross.org.uk/collections/greetings-cards?page=";

        


    }
}
