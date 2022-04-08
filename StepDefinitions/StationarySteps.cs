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
    {
        [When(@"user clicked on Stationary menu button")]
        [Given(@"user clicked on Stationary menu button")]
        public void WhenUserClickedOnStationaryMenuButton()
        {
            driver.FindElement(By.XPath("((//nav[@class='nav-bar']//li)[12]//a)[1]")).Click();
        }
     

        [Then(@"user selected greeting cards catagory to shop")]
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

        [Then(@"user selected Birthday cards catagory to shop")]
        public void ThenUserSelectedBirthdayCardsCatagoryToShop()
        {
            driver.FindElement(By.XPath("(//nav[@class='nav-bar']//li)[15]//a")).Click();
        }

        [Then(@"user is on Birthday cards page")]
        public void ThenUserIsOnBirthdayCardsPage()
        {
            Assert.AreEqual(stationaryBirthdayCardPage, driver.Url);
        }
        
        [Then(@"user selected Congratulations cards catagory to shop")]
        public void ThenUserSelectedCongratulationsCardsCatagoryToShop()
        {
            driver.FindElement(By.XPath("(//nav[@class='nav-bar']//li)[16]//a")).Click();
        }

        [Then(@"user is on Congratulations cards page")]
        public void ThenUserIsOnCongratulationsCardsPage()
        {
            Assert.AreEqual(stationaryCongratulationsCardPage, driver.Url);
        }

        [Then(@"user selected Thankyou cards catagory to shop")]
        public void ThenUserSelectedThankyouCardsCatagoryToShop()
        {
            driver.FindElement(By.XPath("(//nav[@class='nav-bar']//li)[17]//a")).Click();
        }

        [Then(@"user is on Thankyou cards page")]
        public void ThenUserIsOnThankyouCardsPage()
        {
            Assert.AreEqual(stationaryThankyouCardPage, driver.Url);
        }

        [Then(@"user selected Wrapping paper catagory to shop")]
        public void ThenUserSelectedWrappingPaperCatagoryToShop()
        {
            driver.FindElement(By.XPath("(//nav[@class='nav-bar']//li)[18]//a")).Click();
        }

        [Then(@"user is on Wrapping paper page")]
        public void ThenUserIsOnWrappingPaperPage()
        {
            Assert.AreEqual(stationaryWrappingPaperPage, driver.Url);
        }
        [Then(@"user selected Notebooks catagory to shop")]
        public void ThenUserSelectedNotebooksCatagoryToShop()
        {
            driver.FindElement(By.XPath("(//nav[@class='nav-bar']//li)[19]//a")).Click();
        }

        [Then(@"user is on Notebooks page")]
        public void ThenUserIsOnNotebooksPage()
        {
            Assert.AreEqual(stationaryNotebooksPage, driver.Url);
        }

        [Then(@"user selected Enamel Pin Badges catagory to shop")]
        public void ThenUserSelectedEnamelPinBadgesCatagoryToShop()
        {
            driver.FindElement(By.XPath("(//nav[@class='nav-bar']//li)[20]//a")).Click();
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
        //(//button[@class='value-picker__choice-item link '])[2]
        //(//button[@class='value-picker__choice-item link '])[3]

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

        [Then(@"page filtered with items  Alphabetically A-Z")]
        public void ThenPageFilteredWithItemsAlphabeticallyA_Z()
        {
            throw new PendingStepException();
        }


    }
}
