using OpenQA.Selenium;
using NUnit.Framework;

namespace RedCrossWithBDD.Pages
{
    public class VirtualGiftsPage:BasePage
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
    }
}
