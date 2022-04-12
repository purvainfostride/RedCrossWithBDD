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

        public string newinPageProducts = "(//div[@class='product-item__info-inner']//a)";
        public string nextpagebynumbers = "(//div[@class='pagination__nav']//a)";
        public string nextpage = "//div[@class='pagination__inner']//a[@title='Next']";
        public string prevpage = "//div[@class='pagination__inner']//a[@title='Previous']";
        public string pagesUrl = "https://giftshop.redcross.org.uk/collections/new-in?page=";
        [Then(@"New Arrival's Product count is same as displayed")]
        public void ThenNewArrivalsProductCountIsSameAsDisplayed()
        {   
            IWebElement NewIn = driver.FindElement(By.XPath("//span[@class='collection__showing-count hidden-pocket hidden-lap']"));
            Assert.AreEqual("Showing 1 - 36 of 79 products", NewIn.Text.ToString());
           
            //div[@class='pagination__inner']//a
        }
        [Then(@"New Arrival's Products are clickable")]
        public void ThenNewArrivalsProductsAreClickable()
        {
            for (int i = 1; i <= 37; i++)
            {
                IWebElement d = driver.FindElement(By.XPath(newinPageProducts + "[" + i + "]"));
                d.Click();
                driver.Navigate().Back();
                Thread.Sleep(5000);
            }

        }
        [Then(@"user is able to redirect to next pages with numbers")]
        public void ThenUserIsAbleToRedirectToNextPagesWithNumbers()
        {
            for (int i = 1; i <nextpage.Length; i++)
            {
               IWebElement nextbynumbers = driver.FindElement(By.XPath(nextpagebynumbers + "[" + i + "]"));
                nextbynumbers.Click();
               int a = i + 1;
               Assert.AreEqual(pagesUrl+a, driver.Url);
            }
        }
        [Then(@"user is able to redirect to next pages")]
        public void ThenUserIsAbleToRedirectToNextPages()
        {
            IWebElement next = driver.FindElement(By.XPath(nextpage));
            while (next.Displayed)
            { 
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement SearchResult = wait.Until(ExpectedConditions.ElementExists(By.XPath(nextpage)));
                SearchResult.Click();
            }

        }



    }
}
