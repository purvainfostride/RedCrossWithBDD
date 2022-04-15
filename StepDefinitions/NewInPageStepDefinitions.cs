using RedCrossWithBDD.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RedCrossWithBDD.Utility;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class NewInPageStepDefinitions : LinksUtility
    {
        HomePage homePage = new HomePage();
        XPathUtility xpathUtility= new XPathUtility();
        
        [Then(@"New Arrival's Product count is same as displayed")]
        public void ThenNewArrivalsProductCountIsSameAsDisplayed()
        {
            var count = 0;
            for (int i = 0; i <= 2; i++)
            {
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.AllProductsXpath));
                var p1 = newinpageProducts.Count;
                count = count + p1;

                if (i == 2)
                {
                    Assert.AreEqual(79, count);
                    break;
                }

                driver.FindElement(By.XPath(xpathUtility.nextbuttonXpath)).Click();
                Thread.Sleep(2000);
            }

        }
        [Then(@"New Arrival's Products are clickable")]
        public void ThenNewArrivalsProductsAreClickable()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.AllProductsXpath));
            for (int i = 1; i <= newinpageProducts.Count; i++)
            {
                Console.WriteLine(newinpageProducts.Count);
                IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.AllProductsXpath + ")" + "[" + i + "]"));
                d.Click();
                //Assert.AreEqual(expected, d.Text);
                driver.Navigate().Back();
                Thread.Sleep(3000);
            }

        }
        [Then(@"user is able to redirect to next pages with numbers")]
        public void ThenUserIsAbleToRedirectToNextPagesWithNumbers()
        {
            var nextbynumbers = driver.FindElements(By.XPath(xpathUtility.nextpageByNumbersXPath));

            for (int i = 1; i <= nextbynumbers.Count; i++)
            {
                IWebElement nextpagebynumbers = driver.FindElement(By.XPath("(" + xpathUtility.nextpageByNumbersXPath + ")" + "[" + i + "]"));
                nextpagebynumbers.Click();
                int a = i + 1;
                Assert.AreEqual(pagesUrl + a, driver.Url);
            }
        }
        [Then(@"user is able to redirect to next pages")]
        public void ThenUserIsAbleToRedirectToNextPages()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.AllProductsXpath));
            for (int i = 1; i <= 2; i++)
            {
                newinpageProducts.Count();
                driver.FindElement(By.XPath(xpathUtility.nextbuttonXpath)).Click();
                Thread.Sleep(2000);
                int a = i + 1;
                Assert.AreEqual(pagesUrl + a, driver.Url);
            }

        }
        [Then(@"user is able to redirect to previous pages")]
        public void ThenUserIsAbleToRedirectToPreviousPages()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.AllProductsXpath));
            var a = 4;
            for (int i = 1; i <= 2; i++)
            {
                a = a - 1;
                Assert.AreEqual(pagesUrl + a, driver.Url);
                newinpageProducts.Count();
                driver.FindElement(By.XPath(xpathUtility.prevbuttonXpath)).Click();
                Thread.Sleep(2000);

            }
        }
        [When(@"user clicked on New In menu button")]
        [Then(@"user clicked on New In menu button")]
        [Given(@"user clicked on New In menu button")]
        [Given(@"user is redirected to New Arrivals page")]
        [Then(@"user is redirected to New Arrivals page")]
        public void ThenUserIsRedirectedToNewArrivalsPage()
        {
            homePage.UserClickedOnNewInMenuButton();
            Assert.AreEqual(newInPageUrl, driver.Url);
        }
        [Then(@"user validate whether Display Filter is Sorting the products by range")]
        public void WhenUserSelectedDisplayFilter()
        {
            var a = 24;
            for (int i = 1; i <= 3; i++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,250);");
                driver.FindElement(By.XPath(xpathUtility.displayFilterXpath)).Click();
                driver.FindElement(By.XPath(xpathUtility.displayFilterButtonXpath + "[" + i + "]")).Click();
                Thread.Sleep(2000);
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.AllProductsXpath));
                var displayFilterCount = newinpageProducts.Count();
                Assert.AreEqual(a, displayFilterCount);
                a = a + 12;
            }
        }
        [Then(@"user validate whether Sort by Filter is Sorting the products by range")]
        public void WhenUserSelectedSortByFilterToSortTheProductsByRange()
        {
           
            for (int i = 4; i <= 11; i++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,250);");
                driver.FindElement(By.XPath(xpathUtility.sortbyFilterXpath)).Click();
                driver.FindElement(By.XPath(xpathUtility.displayFilterButtonXpath + "[" + i + "]")).Click();
                Thread.Sleep(3000);
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.AllProductsXpath));
                for (int j = 1; j <= newinpageProducts.Count; j++)
                {   
                    IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.AllProductsXpath + ")" + "[" + i + "]"));
                    Console.WriteLine(i+": "+d.Text);
                }
            }
        }


    }
}

