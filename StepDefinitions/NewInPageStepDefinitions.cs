using RedCrossWithBDD.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RedCrossWithBDD.Utility;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.Util;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class NewInPageStepDefinitions : LinksUtility
    {
        HomePage homePage = new HomePage();
        XPathUtility xpathUtility = new XPathUtility();


        [Then(@"New Arrival's Product count is same as displayed")]
        public void ThenNewArrivalsProductCountIsSameAsDisplayed()
        {
            var count = 0;
            for (int i = 0; i <= 2; i++)
            {
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
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
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
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
                js.ExecuteScript("window.scrollBy(0,400);");
                driver.FindElement(By.XPath(xpathUtility.sortbyFilterXpath)).Click();
                driver.FindElement(By.XPath(xpathUtility.displayFilterButtonXpath + "[" + i + "]")).Click();
                Thread.Sleep(3000);
                var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
                for (int j = 1; j <= newinpageProducts.Count; j++)
                {
                    IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + j + "]"));
                    Console.WriteLine(j + ": " + d.Text);
                }
            }
            //string path = @"C:\\Users\\Purva\\C#\\RedCrossWithBDD\\TestData\\NewInPageData.xls";
            //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //HSSFWorkbook wb = new HSSFWorkbook(fs);
            //ISheet sheet = wb.GetSheetAt(0);
            //if (sheet != null)
            //{
            //    int rowCount = sheet.LastRowNum;
            //    Console.WriteLine(rowCount);
            //    for (int i = 0; i < rowCount; i++)
            //    {
            //        IRow curRow = sheet.GetRow(i);
            //        var cellvalue0 = curRow.GetCell(0).StringCellValue.Trim();
            //        Console.WriteLine(cellvalue0);
            //    }

            //}
        }

        [Then(@"user Validate total price of cart products is same as displayed in total")]
        public void ThenUserValidateTotalPriceOfCartProductsIsSameAsDisplayedInTotal()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            var price =0.0;
            for (int i = 1; i <= newinpageProducts.Count; i++)
            {
                IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + i + "]"));
                d.Click();
                driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
                var totalamount = driver.FindElements(By.XPath(xpathUtility.totalamountXpath));
                for (int j = 1; j <= (totalamount.Count / 2); j++)
                {
                    string text1 = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
                    Double textsub = Convert.ToDouble(text1.Substring(1));
                    Console.WriteLine("textsub " + textsub);
                    price = price + textsub;
                    Console.WriteLine("price " + price);
                    string text2 = driver.FindElement(By.XPath("(//div[@class='cart-recap__price-line text--pull']//span)[2]")).Text;
                    Double priceShown = Convert.ToDouble(text2.Substring(1));
                    Console.WriteLine("Totalshown: " + priceShown);
                    Assert.AreEqual(priceShown, price);
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath(xpathUtility.newInButtonXpath)).Click();
                    if (j == (totalamount.Count / 2))
                    { 
                        break;
                    }
                    
                }
              

            }

        }
        [Then(@"user validate quantity updation in new arrival's cart page")]
        public void ThenUserValidateQuantityUpdationInNewArrivalsCartPage()
        {
            //            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            //            //var price = 0.0;
            //            for (int i = 1; i <= newinpageProducts.Count; i++)
            //            {
            //                newinpageProducts.Count();
            //                IWebElement d = driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[" + i + "]"));
            //                d.Click();
            //                driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
            //                var totalamount = driver.FindElements(By.XPath(xpathUtility.totalamountXpath));
            //                for (int j = 1; j <= (totalamount.Count/2); j++)
            //                {
            //                    Console.WriteLine((totalamount.Count / 2));
            //                    string textBeforeInc = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
            //                    Double textBefore = Convert.ToDouble(textBeforeInc.Substring(1)); 
            //                    Console.WriteLine("textBefore: " + textBefore);
            //                    driver.FindElement(By.XPath(xpathUtility.qIncXpath + "[" + (j * 2) + "]")).Click();
            //                    string textAfterInc = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
            //                    Double textAfter = Convert.ToDouble(textAfterInc.Substring(1));
            //                    Console.WriteLine("textAfter: " + textAfter);
            //                    Thread.Sleep(2000);
            //                    driver.FindElement(By.XPath(xpathUtility.newInButtonXpath)).Click();
            //                    if (j == (totalamount.Count / 2))
            //                    {
            //                        break;
            //                    }
            //;
            //                }
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            newinpageProducts.Count();
            driver.FindElement(By.XPath("(" + xpathUtility.allProductsXpath + ")" + "[1]")).Click();
            driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
            var totalamount = driver.FindElements(By.XPath(xpathUtility.totalamountXpath));
            for (int j = 1; j <= (totalamount.Count / 2); j++)
            {
                string textBeforeInc = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
                Double textBeforeUpdation = Convert.ToDouble(textBeforeInc.Substring(1));
                driver.FindElement(By.XPath(xpathUtility.qIncXpath + "[" + (j * 2) + "]")).Click();
                string textAfterInc = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
                Double textAInc = Convert.ToDouble(textAfterInc.Substring(1));
                Assert.AreEqual(textBeforeUpdation * j*2, textAInc);
                driver.FindElement(By.XPath(xpathUtility.qDecXpath + "[" + (j * 2) + "]")).Click();
                string textAfterDec = driver.FindElement(By.XPath(xpathUtility.totalamountXpath + "[" + (j * 2) + "]")).Text;
                Double textADec = Convert.ToDouble(textAfterDec.Substring(1));
                Assert.AreEqual(textBeforeUpdation, textADec);
                //Thread.Sleep(2000);
                //driver.FindElement(By.XPath(xpathUtility.newInButtonXpath)).Click();
                if (j == (totalamount.Count / 2))
                {
                    break;
                }
;
            }
        }
    }


    }

   

