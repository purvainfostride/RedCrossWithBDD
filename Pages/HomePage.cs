using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using RedCrossWithBDD.Pages;

namespace RedCrossWithBDD.Pages
{
    public class HomePage : BasePage
    {
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
            driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();//can make a function regarding accepting or managing cookies
        }
        public void UserClickedOnMyAccountButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.PartialLinkText("account")).Click();
        }
        public void SignupDialogueBoxAppears()
        {
            driver.FindElement(By.XPath("//form[@id='header_customer_login']//following-sibling::div[@class='popover__secondary-action']//button[@class='link link--accented']")).Click();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9000);

        }
      
        public void UserEnteredValidFirstName()
        {
            IWebElement firstname = driver.FindElement(By.XPath("(//form[@class='form'])[3]//input[contains(@name, 'customer[first_name]')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Poorva';", firstname);
        }
        public void UserEnteredValidLastName()
        {
            IWebElement lastname = driver.FindElement(By.Id("customer[last_name]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Malhotra';", lastname);
        }
        public void UserEnteredValidEmail()
        {
            IWebElement email = driver.FindElement(By.Id("register-customer[email]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@gmail.com';", email);
        }
        public void UserEnteredValidPassword()
        {
            IWebElement pass = driver.FindElement(By.Id("register-customer[password]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@';", pass);

        }
        public void UserClickedOnCreateMyAccountButton()
        {
            IWebElement create = driver.FindElement(By.XPath("//button[contains(text(),'Create my account')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", create);
        }

        public void UserEnteredValidEmailID()
        {
            IWebElement emailID = driver.FindElement(By.Id("login-customer[email]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@gmail.com';", emailID);
        }


        public void UserEnteredValidUserPassword()
        {
            IWebElement userpass = driver.FindElement(By.Id("login-customer[password]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@';", userpass);
        }

        public void UserClickOnLoginButton()
        {
            IWebElement loginBtn = driver.FindElement(By.XPath("(//form[@class='form'])[1]//button"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", loginBtn);
        }


        public void UserClickedOnShopeHomeMenuButton()
        {
            driver.FindElement(By.XPath("//li[@class='nav-bar__item']//a[contains(text(),'Shop Home')]")).Click();
        }


        public void UserClickedOnNewInMenuButton()
        {
            driver.FindElement(By.XPath("//li[@class='nav-bar__item']//a[contains(text(),'New In ')]")).Click();
        }

        public void UserClickedOnVirtualGiftsMenuButton()
        {
            driver.FindElement(By.XPath("//li[@class='nav-bar__item']//a[contains(text(),'Virtual Gifts')]")).Click();
        }
        public void UserClickedOnSaleMenuButton()
        {
            driver.FindElement(By.XPath("//li[@class='nav-bar__item']//a[contains(text(),'Sale')]")).Click();
        }

       
    }
}
