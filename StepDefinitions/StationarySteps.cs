using RedCrossWithBDD.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class StationarySteps:BasePage
    {   private  string t="(//div//div[@class='aspect-ratio '])[%s]";
        [When(@"user clicked on Stationary menu button")]
        [Given(@"user clicked on Stationary menu button")]
        public void WhenUserClickedOnStationaryMenuButton()
        {
            driver.FindElement(By.XPath("((//nav[@class='nav-bar']//li)[12]//a)[1]")).Click();
        }


        [When(@"user selected greeting cards catagory to shop")]
        [Given(@"user selected greeting cards catagory to shop")]
        public void ThenUserSelectedGreetingCardsCatagoryToShop()
        {
            driver.FindElement(By.XPath("((//nav[@class='nav-bar']//li)[12]//li)[2]//a")).Click();
        }


        [Then(@"user is on greeting cards page")]
        [When(@"user is on greeting cards page")]
        [Given(@"user is on greeting cards page")]
        public void ThenUserIsOnGreetingCardsPage()
        {
            Assert.AreEqual(stationaryGreetingsPage, driver.Url);
        }

        [When(@"user selected Birthday cards catagory to shop")]
        public void ThenUserSelectedBirthdayCardsCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Birthday")).Click();
        }

        [Then(@"user is on Birthday cards page")]
        public void ThenUserIsOnBirthdayCardsPage()
        {
            Assert.AreEqual(stationaryBirthdayCardPage, driver.Url);
        }

        [When(@"user selected Congratulations cards catagory to shop")]
        public void ThenUserSelectedCongratulationsCardsCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Congratulations")).Click();
        }

        [Then(@"user is on Congratulations cards page")]
        public void ThenUserIsOnCongratulationsCardsPage()
        {
            Assert.AreEqual(stationaryCongratulationsCardPage, driver.Url);
        }

        [When(@"user selected Thankyou cards catagory to shop")]
        public void ThenUserSelectedThankyouCardsCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Thank")).Click();
        }

        [Then(@"user is on Thankyou cards page")]
        public void ThenUserIsOnThankyouCardsPage()
        {
            Assert.AreEqual(stationaryThankyouCardPage, driver.Url);
        }

        [When(@"user selected Wrapping paper catagory to shop")]
        public void ThenUserSelectedWrappingPaperCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Wrapping")).Click();
        }

        [Then(@"user is on Wrapping paper page")]
        public void ThenUserIsOnWrappingPaperPage()
        {
            Assert.AreEqual(stationaryWrappingPaperPage, driver.Url);
        }
        [When(@"user selected Notebooks catagory to shop")]
        public void ThenUserSelectedNotebooksCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Notebooks")).Click();
        }

        [Then(@"user is on Notebooks page")]
        public void ThenUserIsOnNotebooksPage()
        {
            Assert.AreEqual(stationaryNotebooksPage, driver.Url);
        }

        [When(@"user selected Enamel Pin Badges catagory to shop")]
        public void ThenUserSelectedEnamelPinBadgesCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Enamel")).Click();
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
            driver.FindElement(By.XPath("(//div[@class='collection']//span[@class='hidden-phone'])[1]")).Click();
        }

        [Then(@"selected (.*) per page")]
        public void ThenSelectedPerPage(int p0)
        {
           driver.FindElement(By.XPath("(//div[@class='value-picker__choice-list'])[1]//button[2]")).Click();
        }

        [Then(@"page filtered with items (.*) per page")]
        public void ThenPageFilteredWithItemsPerPage(int p0)
        {
            IWebElement filter = driver.FindElement(By.XPath("//div[@class='product-item product-item--vertical  1/3--tablet-and-up 1/3--desk']"));
            Console.WriteLine(filter.Size.ToString());
        }

        [When(@"user selected BestSelling filter")]
        public void WhenUserSelectedBestSellingFilter()
        {
            driver.FindElement(By.XPath("(//div[@class='collection']//span[@class='hidden-phone'])[2]")).Click();
        }

        [Then(@"selected Alphabetically A-Z")]
        public void ThenSelectedAlphabeticallyA_Z()
        {
            driver.FindElement(By.XPath("(//div[@class='value-picker__choice-list'])[2]//button[3]")).Click(); 
            driver.FindElement(By.XPath("//div[@class='product-item__info-inner']//a[contains(text(),'Bees Knees - Enamel Pin Card')]")).Click();
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
