using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace RedCrossWithBDD.Pages
{
    public class CartPage:BasePage
    {
        public void UserSelectedKeepingInTouch()
        {
            SelectElement Select = new SelectElement(driver.FindElement(By.XPath("//div[@class='consent-front-wrapper']//select")));
            Select.SelectByIndex(2);
        }
        public void UserCheckoutTheProductFromCart()
        {
            driver.FindElement(By.XPath("//button[@name='checkout']")).Click();
        }
        public void UserSelectedAnotherGiftFromSuggestions()
        {
            driver.Navigate().Back();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.LinkText("A hygiene pack for a refugee")).Click();
        }
        public void UserEnteredPersonalDetails()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys("purvamalhotra815@gmail.com");
            SelectElement Select = new SelectElement(driver.FindElement(By.XPath("(//select)[1]")));
            Select.SelectByIndex(0);
            driver.FindElement(By.XPath("//input[@placeholder='First name']")).SendKeys("Purva");
            driver.FindElement(By.XPath("//input[@placeholder='Last name']")).SendKeys("Malhotra");
            driver.FindElement(By.XPath("//input[@placeholder='Address']")).SendKeys("Sector-18");
            driver.FindElement(By.XPath("//input[@placeholder='City']")).SendKeys("Albaston");
            driver.FindElement(By.XPath("//input[@placeholder='Postcode']")).SendKeys("SW1A1AA");
        }
        public void UserContinuedThePaymentProcess()
        {
            driver.FindElement(By.XPath("((//form)[1]//button)[3]/span")).Click();

        }
    }
}
