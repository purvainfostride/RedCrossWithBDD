using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using RedCrossWithBDD.Pages;
using RedCrossWithBDD.Utility;
namespace RedCrossWithBDD.Pages
{
    public class HomePage : LinksUtility
    {
        
        XPathUtility xpathUtility = new XPathUtility();

        By cookiesOk = By.Id("onetrust-accept-btn-handler");
        By myAccount = By.PartialLinkText("account");
        By signupBox = By.XPath("//form[@id='header_customer_login']//following-sibling::div[@class='popover__secondary-action']//button[@class='link link--accented']");

        By firstnameSignup = By.XPath("(//form[@class='form'])[3]//input[contains(@name, 'customer[first_name]')]");
        By lastnameSignup = By.Id("customer[last_name]");
        By emailSignup = By.Id("register-customer[email]");
        By passSignup = By.Id("register-customer[password]");
        By createMyAccount = By.XPath("//button[contains(text(),'Create my account')]");
        By emailLogin = By.Id("login-customer[email]");
        By passLogin = By.Id("login-customer[password]");
        By loginB = By.XPath("(//form[@class='form'])[1]//button");
        public void Initialize()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        public void UserManagedTheCookies()
        {
            driver.FindElement(cookiesOk).Click();//can make a function regarding accepting or managing cookies
        }
        public void UserClickedOnMyAccountButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(myAccount).Click();
        }
        public void SignupDialogueBoxAppears()
        {
            driver.FindElement(signupBox).Click();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9000);

        }
      
        public void UserEnteredValidFirstName()
        {
            IWebElement firstname = driver.FindElement(firstnameSignup);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Poorva';", firstname);
        }
        public void UserEnteredValidLastName()
        {
            IWebElement lastname = driver.FindElement(lastnameSignup);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Malhotra';", lastname);
        }
        public void UserEnteredValidEmail()
        {
            IWebElement email = driver.FindElement(emailSignup);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@gmail.com';", email);
        }
        public void UserEnteredValidPassword()
        {
            IWebElement pass = driver.FindElement(passSignup);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@';", pass);

        }
        public void UserClickedOnCreateMyAccountButton()
        {
            IWebElement create = driver.FindElement(createMyAccount);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", create);
        }

        public void UserEnteredValidEmailID()
        {
            IWebElement emailID = driver.FindElement(emailLogin);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@gmail.com';", emailID);
        }


        public void UserEnteredValidUserPassword()
        {
            IWebElement userpass = driver.FindElement(passLogin);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@';", userpass);
        }

        public void UserClickOnLoginButton()
        {
            IWebElement loginBtn = driver.FindElement(loginB);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", loginBtn);
        }


        public void UserClickedOnShopeHomeMenuButton()
        {
            driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[1]")).Click();
        }


        public void UserClickedOnNewInMenuButton()
        {
            driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[2]")).Click();
        }

        public void UserClickedOnVirtualGiftsMenuButton()
        {
            driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[7]")).Click();
        }
        public void UserClickedOnSaleMenuButton()
        {
            driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[8]")).Click();
        }
        public void UserClickedOnClothingMenuButton()
        {
            driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[3]")).Click();
        }
        public void UserClickedOnHomewareMenuButton()
        {
            driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[5]")).Click();
        }
        public void UserClickedOnStationaryMenuButton()
        {
            driver.FindElement(By.XPath(xpathUtility.menubarXpath + "[4]")).Click();
        }
        
    }
}
