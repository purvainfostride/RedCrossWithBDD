using RedCrossWithBDD.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RedCrossWithBDD.Utility;
using System.Text.RegularExpressions;


namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class NewInPageStepDefinitions : LinksUtility
    {
        HomePage homePage = new HomePage();
        XPathUtility xpathUtility = new XPathUtility();
        CartPageSteps cartPageSteps = new CartPageSteps();

        [Then(@"New Arrival's Product count is same as displayed")]
        public void ThenNewArrivalsProductCountIsSameAsDisplayed()
        {
            var newinpageProductsCount = 0;
            for (int i = 0; i <= 2; i++)
            {
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
                var p1 = newinpageProducts.Count;
                newinpageProductsCount = newinpageProductsCount + p1;
                if (i == 2)
                {
                    string newInNavigationBarText = driver.FindElement(By.XPath(xpathUtility.NewInNavigationBarXpath)).Text;
                    string newInNavigationBarText2 = string.Empty;
                    var matches = Regex.Matches(newInNavigationBarText, @"\d+");
                    foreach (var match in matches){newInNavigationBarText2 += match;}
                    int newInNavigationBarVal = int.Parse(newInNavigationBarText2);
                    Assert.AreEqual(newInNavigationBarVal, newinpageProductsCount);
                    break;
                }
                driver.FindElement(By.XPath(xpathUtility.nextbuttonXpath)).Click();
                Thread.Sleep(2000);
            }
        }
        [Then(@"New Arrival's Products are clickable")]
        public void ThenNewArrivalsProductsAreClickable()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            for (int i = 1; i <= newinpageProducts.Count; i++)
            {
                Console.WriteLine(newinpageProducts.Count);
                IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + i + "]"));
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
                Assert.AreEqual(newInPagesUrl + a, driver.Url);
            }
        }
        [Then(@"user is able to redirect to next pages")]
        public void ThenUserIsAbleToRedirectToNextPages()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            for (int i = 1; i <= 2; i++)
            {
                newinpageProducts.Count();
                driver.FindElement(By.XPath(xpathUtility.nextbuttonXpath)).Click();
                Thread.Sleep(2000);
                int a = i + 1;
                Assert.AreEqual(newInPagesUrl + a, driver.Url);
            }
        }
        [Then(@"user is able to redirect to previous pages")]
        public void ThenUserIsAbleToRedirectToPreviousPages()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            var a = 4;
            for (int i = 1; i <= 2; i++)
            {
                a = a - 1;
                Assert.AreEqual(newInPagesUrl + a, driver.Url);
                newinpageProducts.Count();
                driver.FindElement(By.XPath(xpathUtility.prevbuttonXpath)).Click();
                Thread.Sleep(2000);
            }
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
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
                var displayFilterCount = newinpageProducts.Count();
                Assert.AreEqual(a, displayFilterCount);
                a = a + 12;
            }
        }
        [Then(@"user validate whether Sort by Filter is Sorting the products by range")]
        public void WhenUserSelectedSortByFilterToSortTheProductsByRange()
        {
            var k = 1;
            for (int i = 4; i <= 11; i++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,400);");
                driver.FindElement(By.XPath(xpathUtility.sortbyFilterXpath)).Click();
                driver.FindElement(By.XPath(xpathUtility.displayFilterButtonXpath + "[" + i + "]")).Click();
                Thread.Sleep(3000);
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
                Console.WriteLine("Filter" + i);
                string textFile = @"C:\Users\Purva\C#\RedCrossWithBDD\TestData\NewinPageFilter.txt";
                string[] lines = File.ReadAllLines(textFile);
                while (k <= lines.Length)
                {
                    for (int j = 1; j <= newinpageProducts.Count; j++)
                    {
                        IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + j + "]"));
                        Console.WriteLine(k);
                        Console.WriteLine(j);

                        Assert.AreEqual(lines[k], d.Text);
                        k++;
                    }
                    Console.WriteLine("for break: " + k);
                    Console.WriteLine(newinpageProducts.Count + 1);
                    if (k == newinpageProducts.Count + 1) { break;}
                    else if (k == (newinpageProducts.Count * 2) + 1) { break;}
                    else if (k == (newinpageProducts.Count * 3) + 1) { break; }
                    else if (k == (newinpageProducts.Count * 4) + 1) { break; }
                    else if (k == (newinpageProducts.Count * 5) + 1) { break; }
                    else if (k == (newinpageProducts.Count * 6) + 1) { break; }
                    else if (k == (newinpageProducts.Count * 7) + 1) { break; }
                    else if (k == (newinpageProducts.Count * 8) + 1) { break; }
                    k = k + 1;
                }
            }
        }
        [Then(@"user Validate total price of cart products is same as displayed in total")]
        public void ThenUserValidateTotalPriceOfCartProductsIsSameAsDisplayedInTotal()
        {
            var newInPageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            for (int i = 1; i <= newInPageProducts.Count; i++)
            {
                if (i == 5 || i == 19 || i == 28 || i == 31) {continue;}
                IWebElement newInPageProduct = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + i + "]"));
                newInPageProduct.Click();
                driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
                var totalamount = driver.FindElements(By.XPath(xpathUtility.totalamountXpath));
                var price = 0.0;
                for (int j = 1; j <= (totalamount.Count / 2); j++)
                {
                    string text1 = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
                    Double textsub = Convert.ToDouble(text1.Substring(1));
                    Console.WriteLine("textsub " + textsub);
                    price = price + textsub + 0.00;
                    Console.WriteLine("price " + price);
                    string text2 = driver.FindElement(By.XPath("(//div[@class='cart-recap__price-line text--pull']//span)[2]")).Text;
                    Double priceShown = Convert.ToDouble(text2.Substring(1));
                    Console.WriteLine("Totalshown: " + priceShown);
                    if (j == (totalamount.Count / 2))
                    {
                        Assert.AreEqual((int)priceShown, (int)price);
                        break;
                    }
                }
                driver.FindElement(By.XPath(xpathUtility.newInButtonXpath)).Click();
            }
        }       
    }
}



