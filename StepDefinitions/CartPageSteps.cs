using System;
using TechTalk.SpecFlow;
using RedCrossWithBDD.Pages;
using OpenQA.Selenium;
using RedCrossWithBDD.Utility;
using NUnit.Framework;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class CartPageSteps : LinksUtility
    {
        XPathUtility xpathUtility = new XPathUtility();
        HomePageSteps homePageSteps=new HomePageSteps();
        MethodsUtility methodsUtility = new MethodsUtility();


        [When(@"user selected a page to shop")]
        public void WhenUserSelectedAPageToShop()
        {
            var products = driver.FindElements(By.XPath(xpathUtility.menubarXpath));
            products.Count();
            driver.FindElement(By.XPath("(" + xpathUtility.menubarXpath + ")" + "[2]")).Click();
        }

        [When(@"user selected a product to add in cart")]
        [Then(@"user selected another product to add in cart")]
        public void WhenUserSelectedAProductToAddInCart()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            newinpageProducts.Count();
            driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[1]")).Click();
        }

        [When(@"user added that product to cart")]
        [Then(@"user added that another product to cart")]
        public void WhenUserAddedThatProductToCart()
        {
            driver.FindElement(By.XPath(xpathUtility.addToCartXpath)).Click();
        }
        [Then(@"user selected another page to shop")]
        public void ThenUserSelectedAnotherPageToShop()
        {

            var products = driver.FindElements(By.XPath(xpathUtility.menubarXpath));
            products.Count();
            driver.FindElement(By.XPath("(" + xpathUtility.menubarXpath + ")" + "[7]")).Click();
        }
        [Then(@"user validate quantity updation in new arrival's cart page")]
        public void ThenUserValidateQuantityUpdationInNewArrivalsCartPage()
        {
            var totalamount = driver.FindElements(By.XPath(xpathUtility.totalamountXpath));
            for (int j = 1; j <= (totalamount.Count / 2); j++)
            {
                string originalPrice = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + ((j * 2) - 1) + "]")).Text;
                Double priceBeforeUpdation = Convert.ToDouble(originalPrice.Substring(1));
                driver.FindElement(By.XPath(xpathUtility.qIncXpath + "[" + (j * 2) + "]")).Click();
                string priceAfterInc = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
                Double priceAInc = Convert.ToDouble(priceAfterInc.Substring(1));
                Assert.AreEqual(priceBeforeUpdation * j * 2, priceAInc);
                driver.FindElement(By.XPath(xpathUtility.qDecXpath + "[" + (j * 2) + "]")).Click();
                string priceAfterDec = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
                Double priceADec = Convert.ToDouble(priceAfterDec.Substring(1));
                Assert.AreEqual(priceBeforeUpdation, priceADec);
                if (j == (totalamount.Count / 2))
                {
                    break;
                }
;
            }
        }
        [Then(@"user validate new added products are above already added products in cart")]
        public void ThenUserValidateNewAddedProductsAreAboveAlreadyAddedProductsInCart()
        {
            var newInPageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            for (int i = 1; i <= newInPageProducts.Count; i++)
            {
                if (i == 5 || i == 19 || i == 22 || i == 28 || i == 31)
                {
                    continue;
                }
                string newInPage = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + i + "]")).Text;
                Console.WriteLine("newinpage: " + newInPage);
                IWebElement newInPageProduct = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + i + "]"));
                newInPageProduct.Click();

                driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
                string fText = driver.FindElement(By.XPath(xpathUtility.fTextXpath)).Text;
                Console.WriteLine("Incart: " + fText);
                Assert.AreEqual(newInPage, fText);
                driver.FindElement(By.XPath(xpathUtility.newInButtonXpath)).Click();
                if (i == 4)
                {
                    break;
                }
            }

        }
    }
}
