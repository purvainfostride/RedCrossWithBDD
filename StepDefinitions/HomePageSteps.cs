using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using RedCrossWithBDD.Pages;
using NUnit.Framework;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps:BasePage
    {   HomePage homePage=new HomePage();   
        [Given(@"user is on Home page")]
        public void GivenUserIsOnHomePage()
        {
            homePage.Initialize();
        }
        [Given(@"user managed the cookies")]
        public void GivenUserManagedTheCookies()
        {
            homePage.UserManagedTheCookies();
        }

        [Given(@"user clicked on My Account button")]
        [Given(@"Login dialogue box appears")]
        public void GivenUserClickedOnMyAccountButton()
        {
            homePage.UserClickedOnMyAccountButton();
        }
        [When(@"user clicked on Create your account Button")]
        [Given(@"user clicked on Create your account Button")]
        [Given(@"Signup dialogue box appears")]
        [Then(@"Signup dialogue box appears")]
        public void ThenSignupDialogueBoxAppears()
        {
            driver.FindElement(By.XPath("//form[@id='header_customer_login']//following-sibling::div[@class='popover__secondary-action']//button[@class='link link--accented']")).Click();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9000);

        }

        [When(@"user clicked on Shope Home menu button")]
        public void WhenUserClickedOnShopeHomeMenuButton()
        {
            driver.FindElement(By.PartialLinkText("Shop Home")).Click();
        }

        [Then(@"user is on landing page of the application")]
        public void ThenUserIsOnLandingPageOfTheApplication()
        {
            Assert.AreEqual(url,driver.Url);
        }

        [When(@"user clicked on New In menu button")]
        public void WhenUserClickedOnNewInMenuButton()
        {
            driver.FindElement(By.PartialLinkText("New In")).Click();
        }

        [Then(@"user is redirected to New Arrivals page")]
        public void ThenUserIsRedirectedToNewArrivalsPage()
        {
            Assert.AreEqual(newInPageUrl, driver.Url);
        }

        [When(@"user clicked on Virtual Gifts menu button")]
        [Given(@"user clicked on Virtual Gifts menu button")]
        public void WhenUserClickedOnVirtualGiftsMenuButton()
        {
            driver.FindElement(By.PartialLinkText("Virtual Gifts")).Click();
        }

        [Then(@"user is redirected to Virtual Gifts page")]
        [When(@"user is redirected to Virtual Gifts page")]
        public void ThenUserIsRedirectedToVirtualGiftsPage()
        {
            Assert.AreEqual(virtualGiftsPageUrl, driver.Url);
        }

        [When(@"user clicked on Sale menu button")]
        public void WhenUserClickedOnSaleMenuButton()
        {
            driver.FindElement(By.PartialLinkText("Sale")).Click();
        }

        [Then(@"user is redirected to Sale page")]
        public void ThenUserIsRedirectedToSalePage()
        {
            Assert.AreEqual(salePageUrl, driver.Url);
        }

        [Then(@"user closed the browser")]
        public void ThenUserClosedTheBrowser()
        {
            Thread.Sleep(2000);
            driver.Quit();
            
        }



    }
}