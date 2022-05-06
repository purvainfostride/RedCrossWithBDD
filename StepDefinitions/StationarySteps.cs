using RedCrossWithBDD.Pages;
using RedCrossWithBDD.Utility;
using OpenQA.Selenium;
using NUnit.Framework;
using RedCrossWithBDD.Utility;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class StationarySteps:LinksUtility
    {   private  string t="(//div//div[@class='aspect-ratio '])[%s]";
        StationaryModule stationaryModule = new StationaryModule();
        XPathUtility xpathUtility = new XPathUtility();
        MethodsUtility utilMethods=new MethodsUtility();
        HomePage homePage = new HomePage(); 
        
        [Given(@"user selected greeting cards catagory to shop")]
        [When(@"user selected greeting cards catagory to shop")]
        [Then(@"user selected greeting cards catagory to shop")]
        public void ThenUserSelectedGreetingCardsCatagoryToShop()
        {
            stationaryModule.UserSelectedGreetingCardsCatagoryToShop();
        }
   
        [Then(@"user is redirecting to sub pages of stationary page")]
        public void ThenUserIsRedirectingToSubPagesOfStationaryPage()
        {
            var stationaryDropDown = driver.FindElements(By.XPath(xpathUtility.stationaryDropDownXpath));
            for (int i = 1; i <= stationaryDropDown.Count; i++)
            {
                driver.FindElement(By.XPath(xpathUtility.stationaryDropDownXpath + "[" + i + "]")).Click();
                if (i == stationaryDropDown.Count - 1) { break; }
                homePage.UserClickedOnStationaryMenuButton();

            }
        }

        [Then(@"user is redirecting to sub pages of stationary page by side Navigation bar")]
        public void WhenUserClickedOnSelectedNavbarOption()
        {
            driver.FindElement(By.XPath(xpathUtility.stationaryDropDownXpath +"[1]")).Click();
            var stationaryNavigationBar = driver.FindElements(By.XPath(xpathUtility.stationaryNavigationBarXpath));
            for (int i = 2; i <= stationaryNavigationBar.Count; i++)
            {
                driver.FindElement(By.XPath(xpathUtility.stationaryNavigationBarXpath + "[" + i + "]")).Click();
            }
        }

        [Then(@"user is on greeting cards page")]
        [When(@"user is on greeting cards page")]
        [Given(@"user is on greeting cards page")]
        public void ThenUserIsOnGreetingCardsPage()
        {
            Assert.AreEqual(stationaryGreetingsPageUrl, driver.Url);
        }

        [Then(@"user selected Birthday cards catagory to shop")]
        [When(@"user selected birthday cards catagory to shop")]
        public void ThenUserSelectedBirthdayCardsCatagoryToShop()
        {
            stationaryModule.UserSelectedBirthdayCardsCatagoryToShop();
        }

        [Then(@"user is on Birthday cards page")]
        public void ThenUserIsOnBirthdayCardsPage()
        {
            Assert.AreEqual(stationaryBirthdayCardPage, driver.Url);
        }

        [Then(@"user selected Congratulations cards catagory to shop")]
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
        [Then(@"user selected Thankyou cards catagory to shop")]
        public void ThenUserSelectedThankyouCardsCatagoryToShop()
        {
            stationaryModule.UserSelectedThankyouCardsCatagoryToShop();
        }

        [Then(@"user is on Thankyou cards page")]
        public void ThenUserIsOnThankyouCardsPage()
        {
            Assert.AreEqual(stationaryThankyouCardPage, driver.Url);
        }
        [When(@"user selected Wrapping cards catagory to shop")]
        [Then(@"user selected Wrapping paper catagory to shop")]
        public void ThenUserSelectedWrappingPaperCatagoryToShop()
        {
            stationaryModule.UserSelectedWrappingPaperCatagoryToShop();
        }

        [Then(@"user is on Wrapping paper page")]
        public void ThenUserIsOnWrappingPaperPage()
        {
            Assert.AreEqual(stationaryWrappingPaperPage, driver.Url);
        }
        [Then(@"user selected Notebooks catagory to shop")]
        [When(@"user selected Notebooks cards catagory to shop")]
        public void ThenUserSelectedNotebooksCatagoryToShop()
        {
            stationaryModule.UserSelectedNotebooksCatagoryToShop();
        }

        [Then(@"user is on Notebooks page")]
        public void ThenUserIsOnNotebooksPage()
        {
            Assert.AreEqual(stationaryNotebooksPage, driver.Url);
        }

        [Then(@"user selected Enamel Pin Badges catagory to shop")]
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


        [Then(@"greeting cards page Products count is same as displayed")]
        public void ThenGreetingCardsPageProductsCountIsSameAsDisplayed()
        {
            var count = 0;
            
            for (int i = 1; i <= 2; i++)
            {
                var greetingsPageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
                var p1 = greetingsPageProducts.Count;
                count = count + p1;

                if (i == 2)
                {
                    Assert.AreEqual(38, count);
                    break;
                }

                driver.FindElement(By.XPath(xpathUtility.nextbuttonXpath)).Click();
                Thread.Sleep(2000);
            }

        }
        [Then(@"birthday cards page Products count is same as displayed")]
        public void ThenBirthdayCardsPageProductsCountIsSameAsDisplayed()
        {
            var stationarypageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            var p1 = stationarypageProducts.Count;
            Assert.AreEqual(7, p1);
        }

        [Then(@"Congratulations cards page Products count is same as displayed")]
        public void ThenCongratulationsCardsPageProductsCountIsSameAsDisplayed()
        {
            var stationarypageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            var p1 = stationarypageProducts.Count;
            Assert.AreEqual(4, p1);
        }

        [Then(@"Thankyou cards page Products count is same as displayed")]
        public void ThenThankyouCardsPageProductsCountIsSameAsDisplayed()
        {
            var stationarypageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            var p1 = stationarypageProducts.Count;
            Assert.AreEqual(7, p1);
        }

        [Then(@"Wrapping cards page Products count is same as displayed")]
        public void ThenWrappingCardsPageProductsCountIsSameAsDisplayed()
        {
            utilMethods.CountAllProducts();
            //Assert.AreEqual(4);
        }

        [Then(@"Notebooks cards page Products count is same as displayed")]
        public void ThenNotebooksCardsPageProductsCountIsSameAsDisplayed()
        {
            throw new PendingStepException();
        }


        [Then(@"Enamel Pin Badges page Products count is same as displayed")]
        public void ThenEnamelPinBadgesPageProductsCountIsSameAsDisplayed()
        {
            throw new PendingStepException();
        }
        [Then(@"user is able to redirect to next pages of GreetingcardsPage with numbers")]
        public void ThenUserIsAbleToRedirectToNextPagesOfGreetingcardsPageWithNumbers()
        {
            var nextbynumbers = driver.FindElements(By.XPath(xpathUtility.nextpageByNumbersXPath));

            for (int i = 1; i <= nextbynumbers.Count; i++)
            {
                IWebElement nextpagebynumbers = driver.FindElement(By.XPath("(" + xpathUtility.nextpageByNumbersXPath + ")" + "[" + i + "]"));
                nextpagebynumbers.Click();
                int a = i + 1;
                Assert.AreEqual(greetingsPage + a, driver.Url);
            }
        }
        [Then(@"user is able to redirect to next pages of GreetingcardsPage")]
        public void ThenUserIsAbleToRedirectToNextPagesOfGreetingcardsPage()
        {
            var greetingsPageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            greetingsPageProducts.Count();
            driver.FindElement(By.XPath(xpathUtility.nextbuttonXpath)).Click();
            Thread.Sleep(2000);
            int a = 2;
            Assert.AreEqual(greetingsPage + a, driver.Url);
            
        }

        [Then(@"user is able to redirect to previous pages of GreetingcardsPage")]
        public void ThenUserIsAbleToRedirectToPreviousPagesOfGreetingcardsPage()
        {
            var greetingsPageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            greetingsPageProducts.Count();
            driver.FindElement(By.XPath(xpathUtility.prevbuttonXpath)).Click();
            Thread.Sleep(2000);
            int a = 1;
            Assert.AreEqual(greetingsPage + a, driver.Url);

        }
        [Then(@"user validate whether Display Filter of greetingsPage is Sorting the products by range")]
        public void ThenUserValidateWhetherDisplayFilterOfGreetingsPageIsSortingTheProductsByRange()
        {
            var a = 24;
            for (int i = 1; i <= 3; i++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,250);");
                driver.FindElement(By.XPath(xpathUtility.displayFilterGreetingXpath)).Click();
                driver.FindElement(By.XPath(xpathUtility.displayFilterButtonGreetingXpath + "[" + i + "]")).Click();
                Thread.Sleep(2000);
                var greetingsPageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
                var displayFilterCount = greetingsPageProducts.Count();
                Assert.AreEqual(a, displayFilterCount);
                a = a + 12;
            }
        }

        [Then(@"user validate whether Sort by Filter of greetingsPage is Sorting the products by range")]
        public void ThenUserValidateWhetherSortByFilterOfGreetingsPageIsSortingTheProductsByRange()
        {
            for (int i = 4; i <= 11; i++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,300);");
                driver.FindElement(By.XPath(xpathUtility.displayFilterGreetingXpath)).Click();
                driver.FindElement(By.XPath(xpathUtility.displayFilterButtonGreetingXpath + "[" + i + "]")).Click();
                Thread.Sleep(3000);
                var greetingsPageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
                for (int j = 1; j <= greetingsPageProducts.Count; j++)
                {
                    IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + j + "]"));
                    Console.WriteLine(j + ": " + d.Text);
                }
            }
        }

    }


}




