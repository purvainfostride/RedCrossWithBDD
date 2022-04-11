using RedCrossWithBDD.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class VirtualGiftsSteps:BasePage
    {
        [When(@"user clicked on the gift to be selected")]
        [Then(@"user clicked on the gift to be selected")]
        public void ThenUserClickedOnTheGiftToBeSelected()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("((//div[@class='gift-image'])[1]//img)[2]")).Click();
        }

        [Then(@"user selected a greeting card")]
        public void ThenUserSelectedAGreetingCard()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("//label[@title='Happy Birthday']//span")).Click();
        }

        [Then(@"user haven't selected a card")]
        public void ThenUserHaventSelectedACard()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("//span[contains(text(),'Send an e-card')]/following::span[1]")).Click();
        }

        [Then(@"user selected an Ecard")]
        public void ThenUserSelectedAnEcard()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("//label[contains(@title,'Send an e-card')]//span")).Click();
        }

        [Then(@"user entered Recipient's Name")]
        public void ThenUserEnteredRecipientsName()
        {
           
            driver.FindElement(By.Id("ecard-field--recipients-name")).SendKeys("RNAME");
        }

        [Then(@"user entered his/her Name")]
        public void ThenUserEnteredHisHerName()
        {
            driver.FindElement(By.Id("ecard-field--your-name")).SendKeys("UNAME");
        }

        [Then(@"user entered the Message")]
        public void ThenUserEnteredTheMessage()
        {
             driver.FindElement(By.XPath("(//div[@class='ecard-field'])[5]/textarea")).SendKeys("Sending message");
        }
        [Then(@"user entered the Message with word limit")]
        public void ThenUserEnteredTheMessageWithWordLimit()
        {
            driver.FindElement(By.XPath("(//div[@class='ecard-field'])[3]/textarea")).SendKeys("Sending message");
        }

        [Then(@"user entered the Message which is optional")]
        public void ThenUserEnteredTheMessageWhichIsOptional()
        {
            driver.FindElement(By.XPath("(//div[@class='ecard-fields ecard-fields--nothing'])//div//textarea")).SendKeys("Sending message");
        }

        [Then(@"user entered the Message Recipient's Email")]
        public void ThenUserEnteredTheMessageRecipientsEmail()
        {
              driver.FindElement(By.Id("ecard-field--recipients-email")).SendKeys("RName@gmail.com");
        }

        [Then(@"user added the gift to cart")]
        public void ThenUserAddedTheGiftToCart()
        {
            driver.FindElement(By.XPath("//div[@class='product-form__payment-container']//button")).Click();
            Assert.AreEqual(cartPageUrl,driver.Url);
        }
        //[Then(@"user checkout the product from cart")]
        //public void ThenUserCheckoutTheProductFromCart()
        //{
        //    driver.FindElement(By.XPath("//button[@class='cart-recap__checkout button button--primary button--full button--large")).Click();
        //}

    }
}
