using RedCrossWithBDD.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class NewInPageStepDefinitions:BasePage
    {
        public string newinpageProductsXpath = "//div[@class='product-list product-list--collection product-list--with-sidebar']//a[@class='product-item__title text--strong link']";
        public string nextpageByNumbersXPath = "//div[@class='pagination__nav']//a";
        public string nextbuttonXpath = "(//div[@class='pagination__inner']//a[@title='Next'])";
        public string prevbuttonXpath = "//div[@class='pagination__inner']//a[@title='Previous']";
        public string pagesUrl = "https://giftshop.redcross.org.uk/collections/new-in?page=";

        [Then(@"New Arrival's Product count is same as displayed")]
        public void ThenNewArrivalsProductCountIsSameAsDisplayed()
        {
            var newinpageProduct1 = driver.FindElements(By.XPath(newinpageProductsXpath));
            var p1 = newinpageProduct1.Count;
            Console.WriteLine(newinpageProduct1.Count);
            driver.FindElement(By.XPath(nextbuttonXpath)).Click();
            Thread.Sleep(2000);
            var newinpageProduct2 = driver.FindElements(By.XPath(newinpageProductsXpath));
            var p2 = newinpageProduct2.Count;
            Console.WriteLine(newinpageProduct2.Count);
            driver.FindElement(By.XPath(nextbuttonXpath)).Click();
            Thread.Sleep(2000);
            var newinpageProduct3 = driver.FindElements(By.XPath(newinpageProductsXpath));
            var p3 = newinpageProduct3.Count;
            Console.WriteLine(newinpageProduct3.Count);
            var p4 = p1 + p2 + p3;
            Assert.AreEqual(79, p4);
            //var newinpageProducts = driver.FindElements(By.XPath(newinpageProductsXpath));
            //for (int i = 0; i <= 2; i++)
            //{

            //    Console.WriteLine(newinpageProducts.Count);
            //    driver.FindElement(By.XPath(nextbuttonXpath)).Click();
            //    Thread.Sleep(2000);
            //}

        }
        [Then(@"New Arrival's Products are clickable")]
        public void ThenNewArrivalsProductsAreClickable()
        {
            var newinpageProducts = driver.FindElements(By.XPath(newinpageProductsXpath));
            for (int i = 1; i <= newinpageProducts.Count; i++)
            {
                IWebElement d = driver.FindElement(By.XPath("(" + newinpageProductsXpath + ")" + "[" + i + "]"));
                d.Click();
                driver.Navigate().Back();
                Thread.Sleep(5000);
            }

        }
        [Then(@"user is able to redirect to next pages with numbers")]
        public void ThenUserIsAbleToRedirectToNextPagesWithNumbers()
        {
            var nextbynumbers = driver.FindElements(By.XPath(nextpageByNumbersXPath));
            
            for (int i = 1; i <= nextbynumbers.Count; i++)
            { 
                IWebElement nextpagebynumbers = driver.FindElement(By.XPath("("+nextpageByNumbersXPath+")" + "[" + i + "]"));
                nextpagebynumbers.Click();
                int a = i + 1;
               Assert.AreEqual(pagesUrl+a, driver.Url);
            }
        }
        [Then(@"user is able to redirect to next pages")]
        public void ThenUserIsAbleToRedirectToNextPages()
        {
            var newinpageProducts = driver.FindElements(By.XPath(newinpageProductsXpath));
            for (int i = 1; i <= 2; i++)
            {
                newinpageProducts.Count();
                driver.FindElement(By.XPath(nextbuttonXpath)).Click();
                Thread.Sleep(2000);
            }

        }
        [Then(@"user is able to redirect to previous pages")]
        public void ThenUserIsAbleToRedirectToPreviousPages()
        {
            var newinpageProducts = driver.FindElements(By.XPath(newinpageProductsXpath));
            for (int i = 1; i <= 2; i++)
            {
                newinpageProducts.Count();
                driver.FindElement(By.XPath(prevbuttonXpath)).Click();
                Thread.Sleep(2000);
            }
        }



    }
}
