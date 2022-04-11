using RedCrossWithBDD.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class StationarySteps:BasePage
    {   private  string t="(//div//div[@class='aspect-ratio '])[%s]";
        StationaryModule stationaryModule = new StationaryModule();
        [When(@"user clicked on Stationary menu button")]
        [Given(@"user clicked on Stationary menu button")]
        public void WhenUserClickedOnStationaryMenuButton()
        {
            stationaryModule.UserClickedOnStationaryMenuButton();
        }

        [When(@"user selected greeting cards catagory to shop")]
        [Given(@"user selected greeting cards catagory to shop")]
        public void ThenUserSelectedGreetingCardsCatagoryToShop()
        {
            stationaryModule.UserSelectedGreetingCardsCatagoryToShop();
        }

        [Then(@"user is on greeting cards page")]
        [When(@"user is on greeting cards page")]
        [Given(@"user is on greeting cards page")]
        public void ThenUserIsOnGreetingCardsPage()
        {
            Assert.AreEqual(stationaryGreetingsPageUrl, driver.Url);
        }

        [When(@"user selected Birthday cards catagory to shop")]
        public void ThenUserSelectedBirthdayCardsCatagoryToShop()
        {
            stationaryModule.UserSelectedBirthdayCardsCatagoryToShop();
        }

        [Then(@"user is on Birthday cards page")]
        public void ThenUserIsOnBirthdayCardsPage()
        {
            Assert.AreEqual(stationaryBirthdayCardPage, driver.Url);
        }

        [When(@"user selected Congratulations cards catagory to shop")]
        public void ThenUserSelectedCongratulationsCardsCatagoryToShop()
        {
            stationaryModule.UserSelectedCongratulationsCardsCatagoryToShop();
        }

        [Then(@"user is on Congratulations cards page")]
        public void ThenUserIsOnCongratulationsCardsPage()
        {
            Assert.AreEqual(stationaryCongratulationsCardPage, driver.Url);
        }

        [When(@"user selected Thankyou cards catagory to shop")]
        public void ThenUserSelectedThankyouCardsCatagoryToShop()
        {
            stationaryModule.UserSelectedThankyouCardsCatagoryToShop();
        }

        [Then(@"user is on Thankyou cards page")]
        public void ThenUserIsOnThankyouCardsPage()
        {
            Assert.AreEqual(stationaryThankyouCardPage, driver.Url);
        }

        [When(@"user selected Wrapping paper catagory to shop")]
        public void ThenUserSelectedWrappingPaperCatagoryToShop()
        {
            stationaryModule.UserSelectedWrappingPaperCatagoryToShop();
        }

        [Then(@"user is on Wrapping paper page")]
        public void ThenUserIsOnWrappingPaperPage()
        {
            Assert.AreEqual(stationaryWrappingPaperPage, driver.Url);
        }
        [When(@"user selected Notebooks catagory to shop")]
        public void ThenUserSelectedNotebooksCatagoryToShop()
        {
            stationaryModule.UserSelectedNotebooksCatagoryToShop();
        }

        [Then(@"user is on Notebooks page")]
        public void ThenUserIsOnNotebooksPage()
        {
            Assert.AreEqual(stationaryNotebooksPage, driver.Url);
        }

        [When(@"user selected Enamel Pin Badges catagory to shop")]
        public void ThenUserSelectedEnamelPinBadgesCatagoryToShop()
        {
            stationaryModule.UserSelectedEnamelPinBadgesCatagoryToShop();
        }

        [Then(@"user is on Enamel Pin Badges page")]
        public void ThenUserIsOnEnamelPinBadgesPage()
        {
            Assert.AreEqual(stationaryEnamelPinPage, driver.Url);
        }

        [Then(@"user selected display filter")]
        [When(@"user selected display filter")]
        public void ThenUserSelectedDisplayFilter()
        {
            stationaryModule.UserSelectedDisplayFilter();
        }

        [Then(@"selected (.*) per page")]
        public void ThenSelectedPerPage(int p0)
        {
            stationaryModule.SelectedPerPage(p0);
        }

        [Then(@"page filtered with items (.*) per page")]
        public void ThenPageFilteredWithItemsPerPage(int p0)
        {
            stationaryModule.PageFilteredWithItemsPerPage(p0);
        }

        [When(@"user selected BestSelling filter")]
        public void WhenUserSelectedBestSellingFilter()
        {
            stationaryModule.UserSelectedBestSellingFilter();
        }

        [Then(@"selected Alphabetically A-Z")]
        public void ThenSelectedAlphabeticallyA_Z()
        {
            stationaryModule.SelectedAlphabeticallyA_Z();
        }

        [Then(@"page filtered with items Alphabetically A-Z")]
        public void ThenPageFilteredWithItemsAlphabeticallyA_Z()
        {
            throw new PendingStepException();
        }
        //[Then(@"user select greeting card to send")]
        //public void ThenUserSelectGreetingCardToSend()
        //{
        //    IWebElement t = driver.FindElement(By.XPath("//div//div[@class='product-list product-list--collection product-list--with-sidebar']"));
        //    t.Size.ToString();

        //    for (int i = 1; i < 28; i++)
        //    {
        //        driver.FindElement(By.XPath(String.Format(t, i)).Click();
        //    }


        }


    }
}
