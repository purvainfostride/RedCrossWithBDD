using RedCrossWithBDD.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RedCrossWithBDD.Utility;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Text;
using System.Text.RegularExpressions;

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
        [Then(@"user Validate total price of cart products is same as displayed in total")]
        //public void ThenUserValidateTotalPriceOfCartProductsIsSameAsDisplayedInTotal()
        //{
        //    driver.FindElement(By.XPath(xpathUtility.AllProductsXpath + "[1]")).Click();
        //    driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
        //    string text1 = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[2]")).Text;
        //    string t1 = text1.Substring(1);
        //    string text2 = driver.FindElement(By.XPath("(//div[@class='cart-recap__price-line text--pull']//span)[2]")).Text;
        //    string t2 = text2.Substring(1); 
        //    Assert.AreEqual(t1, t2);  
        //}
        public void ThenUserValidateTotalPriceOfCartProductsIsSameAsDisplayedInTotal()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.AllProductsXpath));
            var amount = "";
            for (int i = 1; i <= newinpageProducts.Count; i++)
            {
                newinpageProducts.Count();
                IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.AllProductsXpath + ")" + "[" + i + "]"));
                d.Click();
                driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
                var totalamount = driver.FindElements(By.XPath(xpathUtility.totalamountXpath));
                for (i=1; i <= (totalamount.Count / 2); i++)
                {
                    string text1 = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (i * 2) + "]")).Text;
                    string t1 = text1.Substring(1);
                    Console.WriteLine("total: "+t1);
                    amount =amount.Trim()+ t1;

                    float p2 = (float)Convert.ToDouble(amount) + (float)Convert.ToDouble(t1);
                    Console.WriteLine("tootal: "+ amount);
                    Console.WriteLine("tootalp2: " + p2);
                    if (i==((totalamount.Count/2)+1)){
                  
                        
                        
                        break;
                    }
                    string text2 = driver.FindElement(By.XPath("(//div[@class='cart-recap__price-line text--pull']//span)[2]")).Text;
                    string t2 = text2.Substring(1);
                    Console.WriteLine("Total: " + t2);
                    //Assert.AreEqual(t2, p2);
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                    Thread.Sleep(2000);
                }
                
            }
        }
        

        //[When(@"user Validate total price of cart products is same as displayed in total")]
        //public void GivenUserValidateTotalPriceOfCartProductsIsSameAsDisplayedInTotal()
        //{
        //    int i;
        //    driver.Navigate().Back();
        //    driver.FindElement(By.XPath(xpathUtility.AllProductsXpath + "[2]")).Click();
        //    var totalamount = driver.FindElements(By.XPath(xpathUtility.totalamountXpath));
        //    for (i = 1; i <= (totalamount.Count / 2); i++)
        //    {
        //        string text = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (i * 2) + "]")).Text;
        //        Console.WriteLine(text);
        //    }
        //}
    }
}

