using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace RedCrossWithBDD.Pages
{
    public class VirtualGiftsPage:LinksUtility
    { 
        public void UserClickedOnTheGiftToBeSelected()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("((//div[@class='gift-image'])[1]//img)[2]")).Click();
        }
        public void UserSelectedAGreetingCard()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("//label[@title='Happy Birthday']//span")).Click();
        }
        public void UserHaventSelectedACard()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("//span[contains(text(),'Send an e-card')]/following::span[1]")).Click();
        }
        public void UserSelectedAnEcard()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("//label[contains(@title,'Send an e-card')]//span")).Click();
        }
        public void UserEnteredRecipientsName()
        {

            driver.FindElement(By.Id("ecard-field--recipients-name")).SendKeys("RNAME");
        }
        public void UserEnteredTheMessage()
        {
            driver.FindElement(By.XPath("(//div[@class='ecard-field'])[5]/textarea")).SendKeys("Sending message");
        }
        public void UserEnteredTheMessageWithWordLimit()
        {
            driver.FindElement(By.XPath("(//div[@class='ecard-field'])[3]/textarea")).SendKeys("Sending message");
        }
        public void UserEnteredTheMessageWhichIsOptional()
        {
            driver.FindElement(By.XPath("(//div[@class='ecard-fields ecard-fields--nothing'])//div//textarea")).SendKeys("Sending message");
        }
        public void UserEnteredTheMessageRecipientsEmail()
        {
            driver.FindElement(By.Id("ecard-field--recipients-email")).SendKeys("RName@gmail.com");
        }
        public void UserAddedTheGiftToCart()
        {
            driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
            Assert.AreEqual(cartPageUrl, driver.Url);
        }
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
