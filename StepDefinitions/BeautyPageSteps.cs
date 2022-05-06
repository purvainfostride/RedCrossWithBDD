using RedCrossWithBDD.Pages;
using RedCrossWithBDD.Utility;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class BeautyPageSteps : LinksUtility
    {
        StationaryModule stationaryModule = new StationaryModule();
        XPathUtility xpathUtility = new XPathUtility();
        MethodsUtility utilMethods = new MethodsUtility();
        HomePage homePage = new HomePage();

        [When(@"user clicked on Beauty menu button")]
        public void WhenUserClickedOnBeautyMenuButton()
        {
            driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[6]")).Click();
        }

        [Then(@"user is redirecting to sub pages of BeautyPage page")]
        public void ThenUserIsRedirectingToSubPagesOfBeautyPagePage()
        {
            var beautyDropDown = driver.FindElements(By.XPath(xpathUtility.beautyDropDownXpath));
            for (int i = 1; i <= beautyDropDown.Count; i++)
            {
                driver.FindElement(By.XPath(xpathUtility.beautyDropDownXpath + "[" + i + "]")).Click();
                if (i == beautyDropDown.Count - 1) { break; }
                WhenUserClickedOnBeautyMenuButton();

            }
        }
        [Then(@"user is redirecting to sub pages of BeautyPage by side Navigation bar")]
        public void ThenUserIsRedirectingToSubPagesOfBeautyPageBySideNavigationBar()
        {
            ThenUserIsAbleToRedirectToViewAllSubpageOfBeautyPage();
            var beautyNavigationBar = driver.FindElements(By.XPath(xpathUtility.beautyNavigationBarXpath));
            for (int i = 2; i <= beautyNavigationBar.Count; i++)
            {
                driver.FindElement(By.XPath(xpathUtility.beautyNavigationBarXpath + "[" + i + "]")).Click();
            }
        }
        [Then(@"user is able to redirect to view all subpage of beauty page")]
        [When(@"user is able to redirect to view all subpage of beauty page")]

        public void ThenUserIsAbleToRedirectToViewAllSubpageOfBeautyPage()
        {
            driver.FindElement(By.XPath(xpathUtility.beautyDropDownXpath + "[1]")).Click();
        }

        [Then(@"products of view all subpage of BeautyPage are equal in total as displayed")]
        public void ThenProductsOfViewAllSubpageOfBeautyPageAreEqualInTotalAsDisplayed()
        {
            var beautyProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));       
            string beautyNavigationBarText = driver.FindElement(By.XPath(xpathUtility.beautyNavigationBarXpath+"[1]")).Text;
            string beautyNavigationBarText2 = string.Empty;
            var matches = Regex.Matches(beautyNavigationBarText, @"\d+");
            foreach (var match in matches) { beautyNavigationBarText2 += match; }
            int beautyNavigationBarVal = int.Parse(beautyNavigationBarText2);
            Assert.AreEqual(beautyNavigationBarVal, beautyProducts.Count);       
        }
        [When(@"user is able to redirect to Face subpage of beauty page")]
        public void WhenUserIsAbleToRedirectToFaceSubpageOfBeautyPage()
        {
            driver.FindElement(By.XPath(xpathUtility.beautyDropDownXpath + "[2]")).Click();
        }
        [Then(@"products of Face subpage of BeautyPage are equal in total as displayed")]
        public void ThenProductsOfFaceSubpageOfBeautyPageAreEqualInTotalAsDisplayed()
        {
            var beautyProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            string beautyNavigationBarText = driver.FindElement(By.XPath(xpathUtility.beautyNavigationBarXpath + "[2]")).Text;
            string beautyNavigationBarText2 = string.Empty;
            var matches = Regex.Matches(beautyNavigationBarText, @"\d+");
            foreach (var match in matches) { beautyNavigationBarText2 += match; }
            int beautyNavigationBarVal = int.Parse(beautyNavigationBarText2);
            Assert.AreEqual(beautyNavigationBarVal, beautyProducts.Count);
        }
        [When(@"user is able to redirect to Body subpage of beauty page")]
        public void WhenUserIsAbleToRedirectToBodySubpageOfBeautyPage()
        {
            driver.FindElement(By.XPath(xpathUtility.beautyDropDownXpath + "[3]")).Click();
        }

        [Then(@"products of Body subpage of BeautyPage are equal in total as displayed")]
        public void ThenProductsOfBodySubpageOfBeautyPageAreEqualInTotalAsDisplayed()
        {
            var beautyProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            string beautyNavigationBarText = driver.FindElement(By.XPath(xpathUtility.beautyNavigationBarXpath + "[3]")).Text;
            string beautyNavigationBarText2 = string.Empty;
            var matches = Regex.Matches(beautyNavigationBarText, @"\d+");
            foreach (var match in matches) { beautyNavigationBarText2 += match; }
            int beautyNavigationBarVal = int.Parse(beautyNavigationBarText2);
            Assert.AreEqual(beautyNavigationBarVal, beautyProducts.Count);
        }
        [When(@"user is able to redirect to Emolyne subpage of beauty page")]
        public void WhenUserIsAbleToRedirectToEmolyneSubpageOfBeautyPage()
        {
            driver.FindElement(By.XPath(xpathUtility.beautyDropDownXpath + "[4]")).Click();
        }

        [Then(@"products of Emolyne subpage of BeautyPage are equal in total as displayed")]
        public void ThenProductsOfEmolyneSubpageOfBeautyPageAreEqualInTotalAsDisplayed()
        {
            var beautyProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            string beautyNavigationBarText = driver.FindElement(By.XPath(xpathUtility.beautyNavigationBarXpath + "[4]")).Text;
            string beautyNavigationBarText2 = string.Empty;
            var matches = Regex.Matches(beautyNavigationBarText, @"\d+");
            foreach (var match in matches) { beautyNavigationBarText2 += match; }
            int beautyNavigationBarVal = int.Parse(beautyNavigationBarText2);
            Assert.AreEqual(beautyNavigationBarVal, beautyProducts.Count);
        }

    }
}
