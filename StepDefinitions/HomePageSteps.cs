using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using RedCrossWithBDD.Pages;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps:BasePage
    {
        [Given(@"user is on Home page")]
        public void GivenUserIsOnHomePage()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        [Given(@"user managed the cookies")]
        public void GivenUserManagedTheCookies()
        {
            driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();//can make a function regarding accepting or managing cookies
        }

        [When(@"user clicked on My Account button")]
        [Given(@"user clicked on My Account button")]
        [Given(@"Login dialogue box appears")]
        [When(@"Login dialogue box appears")]
        public void WhenUserClickedOnMyAccountButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.PartialLinkText("account")).Click();
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
        [Then(@"user is on landing page of the application")]
        public void WhenUserClickedOnShopeHomeMenuButton()
        {
            driver.FindElement(By.PartialLinkText("Shop Home")).Click();
        }
        [When(@"user clicked on New In menu button")]
        [Then(@"user is redirected to New Arrivals page")]
        public void WhenUserClickedOnNewInMenuButton()
        {
            driver.FindElement(By.PartialLinkText("New In")).Click();
        }

        [When(@"user clicked on Virtual Gifts menu button")]
        [Then(@"user is redirected to Virtual Gifts page")]
        public void WhenUserClickedOnVirtualGiftsMenuButton()
        {
            driver.FindElement(By.PartialLinkText("Virtual Gifts")).Click();
        }

        [When(@"user clicked on Sale menu button")]
        [Then(@"user is redirected to Sale page")]
        public void WhenUserClickedOnSaleMenuButton()
        {
            driver.FindElement(By.PartialLinkText("Sale")).Click();
        }




        [Then(@"user closed the browser")]
        public void ThenUserClosedTheBrowser()
        {
            Thread.Sleep(2000);
            driver.Quit();
            
        }



    }
}