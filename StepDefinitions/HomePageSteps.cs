using RedCrossWithBDD.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RedCrossWithBDD.Utility;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class HomePageSteps:LinksUtility
    {
        HomePage homePage = new HomePage();
        MethodsUtility methodsUtility = new MethodsUtility();
        XPathUtility xpathUtility = new XPathUtility();


        [Given(@"user initialized the browser")]
        [When(@"user navigated to the Application")]
        [Then(@"user is on Landing page of the application")]
        [Given(@"user is on Landing page of the application")]
        public void GivenUserIsOnLandingPageOfTheApplication()
        {
            homePage.Initialize();
            Assert.AreEqual(url,driver.Url);
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
            homePage.SignupDialogueBoxAppears();

        }
        [When(@"user entered Valid FirstName")]
        public void WhenUserEnteredValidFirstName()
        {
            homePage.UserEnteredValidFirstName();
        }

        [When(@"user entered Valid LastName")]
        public void WhenUserEnteredValidLastName()
        {
            homePage.UserEnteredValidLastName();
        }

        [When(@"user entered Valid Email")]
        public void WhenUserEnteredValidEmail()
        {
            homePage.UserEnteredValidEmail();
        }

        [When(@"user entered Valid Password")]
        public void WhenUserEnteredValidPassword()
        {
            homePage.UserEnteredValidPassword();

        }

        [Then(@"user clicked on Create My Account button")]
        [Then(@"user is able to signup successfully")]
        public void ThenUserClickedOnCreateMyAccountButton()
        {
            homePage.UserClickedOnCreateMyAccountButton();
        }
        [When(@"user entered Valid EmailID")]
        public void WhenUserEnteredValidEmailID()
        {
            homePage.UserEnteredValidEmailID();
        }

        [When(@"user entered Valid UserPassword")]
        public void WhenUserEnteredValidUserPassword()
        {
            homePage.UserEnteredValidUserPassword();    
        }
        [Then(@"user click on Login Button")]
        [Then(@"user logged in successfully")]

        public void WhenUserClickOnLoginButton()
        {
            homePage.UserClickOnLoginButton();
        }

        [When(@"user clicked on Shope Home menu button")]

        [Then(@"user is on Shope Home page of the application")]
        public void UserIsOnShopeHomePageOfTheApplication()
        {
            homePage.UserClickedOnShopeHomeMenuButton();
            Assert.AreEqual(url, driver.Url);
        }

        

        [When(@"user clicked on Virtual Gifts menu button")]
        [Given(@"user clicked on Virtual Gifts menu button")]
        [Then(@"user is on Virtual Gifts Page")]
        [Given(@"user is on Virtual Gifts Page")]
        [When(@"user is on Virtual Gifts Page")]
        [Then(@"user clicked on Virtual Gifts menu button")]
        public void UserIsRedirectedToVirtualGiftsPage()
        {
            homePage.UserClickedOnVirtualGiftsMenuButton();
            Assert.AreEqual(virtualGiftsPageUrl, driver.Url);
        }

        [When(@"user clicked on Sale menu button")]
        [Then(@"user clicked on Sale menu button")]
        [Then(@"user is redirected to Sale page")]
        public void UserIsRedirectedToSalePage()
        {
            homePage.UserClickedOnSaleMenuButton();
            Assert.AreEqual(salePageUrl, driver.Url);
        }
        


        [Then(@"user clicked on Clothing menu button")]
        public void UserClickedOnClothingMenuButton()
        {
            homePage.UserClickedOnClothingMenuButton();
        }


        [Then(@"user clicked on Homeware menu button")]
        public void UserClickedOnHomewareMenuButton()
        {
            homePage.UserClickedOnHomewareMenuButton();
        }
        [When(@"user clicked on New In menu button")]
        [Then(@"user clicked on New In menu button")]
        [Given(@"user clicked on New In menu button")]
        [Given(@"user is on New Arrivals page")]
        [When(@"user is on New Arrivals page")]
        [Then(@"user is on New Arrivals page")]
        public void UserIsRedirectedToNewArrivalsPage()
        {
            homePage.UserClickedOnNewInMenuButton();
            Assert.AreEqual(newInPageUrl, driver.Url);
        }
        [When(@"user clicked on Stationary menu button")]
        [Given(@"user clicked on Stationary menu button")]
        [Then(@"user clicked on Stationary menu button")]
        public void UserClickedOnStationaryMenuButton()
        {
            homePage.UserClickedOnStationaryMenuButton();
        }
        [When(@"user clicked on menu buttons")]
        public void WhenUserClickedOnMenuButtons()
        {
            var newinpageProducts = driver.FindElements(By.XPath(xpathUtility.menubarXpath));
            for (int i = 1; i <= newinpageProducts.Count; i++)
            {
                IWebElement menuBar = driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[" + i + "]"));
                menuBar.Click();
                //Assert.AreEqual(expected, d.Text);
                //driver.Navigate().Back();
                Thread.Sleep(1000);
            }
        }
        [AfterScenario]

        public void ThenUserClosedTheBrowser()
        {
            methodsUtility.UserClosedTheBrowser();

        }

    }
}