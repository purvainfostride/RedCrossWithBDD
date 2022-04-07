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
    }
}
