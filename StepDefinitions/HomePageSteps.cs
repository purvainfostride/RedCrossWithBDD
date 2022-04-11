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
    {
        HomePage homePage = new HomePage();

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
            driver.FindElement(By.XPath("//form[@id='header_customer_login']//following-sibling::div[@class='popover__secondary-action']//button[@class='link link--accented']")).Click();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9000);

        }
        [When(@"user entered Valid FirstName")]
        public void WhenUserEnteredValidFirstName()
        {
            IWebElement firstname = driver.FindElement(By.XPath("(//form[@class='form'])[3]//input[contains(@name, 'customer[first_name]')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Poorva';", firstname);


        }

        [When(@"user entered Valid LastName")]
        public void WhenUserEnteredValidLastName()
        {
            IWebElement lastname = driver.FindElement(By.Id("customer[last_name]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Malhotra';", lastname);
        }

        [When(@"user entered Valid Email")]
        public void WhenUserEnteredValidEmail()
        {
            IWebElement email = driver.FindElement(By.Id("register-customer[email]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@gmail.com';", email);
        }

        [When(@"user entered Valid Password")]
        public void WhenUserEnteredValidPassword()
        {
            IWebElement pass = driver.FindElement(By.Id("register-customer[password]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@';", pass);

        }

        [Then(@"user clicked on Create My Account button")]
        [Then(@"user is able to signup successfully")]
        public void ThenUserClickedOnCreateMyAccountButton()
        {
            IWebElement create = driver.FindElement(By.XPath("//button[contains(text(),'Create my account')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", create);
        }
        [When(@"user entered Valid EmailID")]
        public void WhenUserEnteredValidEmailID()
        {
            IWebElement emailID = driver.FindElement(By.Id("login-customer[email]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@gmail.com';", emailID);
        }

        [When(@"user entered Valid UserPassword")]
        public void WhenUserEnteredValidUserPassword()
        {
            IWebElement userpass = driver.FindElement(By.Id("login-customer[password]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@';", userpass);
        }
        [Then(@"user click on Login Button")]
        [Then(@"user logged in successfully")]

        public void WhenUserClickOnLoginButton()
        {
            IWebElement loginBtn = driver.FindElement(By.XPath("(//form[@class='form'])[1]//button"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", loginBtn);
        }

        [When(@"user clicked on Shope Home menu button")]
        public void WhenUserClickedOnShopeHomeMenuButton()
        {
            driver.FindElement(By.PartialLinkText("Shop Home")).Click();
        }

        [Then(@"user is on Shope Home page of the application")]
        public void ThenUserIsOnShopeHomePageOfTheApplication()
        {
            Assert.AreEqual(url, driver.Url);
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