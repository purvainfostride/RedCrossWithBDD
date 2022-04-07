using RedCrossWithBDD.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class CartPageSteps:BasePage
    {
        [Then(@"user selected keeping in touch")]
        public void ThenUserSelectedKeepingInTouch()
        {
         SelectElement Select = new SelectElement(driver.FindElement(By.XPath("//div[@class='consent-front-wrapper']//select")));
            Select.SelectByIndex(2);    
        }
        [Then(@"user checkout the product from cart")]
        public void ThenUserCheckoutTheProductFromCart()
        {
            driver.FindElement(By.XPath("//button[@name='checkout']")).Click();
        }
        
        [Then(@"user added another gift from suggestion to cart")]
        public void ThenUserAddedAnotherGiftFromSuggestionToCart()
        {
            driver.FindElement(By.XPath("(//form)[5]//button")).Click();
        }
        [Then(@"user entered personal details")]
        public void ThenUserEnteredPersonalDetails()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys("purvamalhotra815@gmail.com");
            SelectElement Select = new SelectElement(driver.FindElement(By.XPath("(//select)[1]")));
            Select.SelectByIndex(0);
            //driver.FindElement(By.XPath("(//div[@class='field__input-wrapper']//input)[2]")).SendKeys("Purva");
            //driver.FindElement(By.XPath("(//div[@class='field__input-wrapper']//input)[3]")).SendKeys("Malhotra");
            //driver.FindElement(By.XPath("(//div[@class='field__input-wrapper']//input)[4]")).SendKeys("Sector-18");
            //driver.FindElement(By.XPath("(//div[@class='field__input-wrapper']//input)[5]")).SendKeys("Sector18,ABC");
            //driver.FindElement(By.XPath("(//div[@class='field__input-wrapper']//input)[6]")).SendKeys("Albaston");
            //SelectElement Select2 = new SelectElement(driver.FindElement(By.XPath("(//select)[2]")));
            //Select2.SelectByValue("HR");
            //driver.FindElement(By.XPath("(//div[@class='field__input-wrapper']//input)[7]")).SendKeys("SW1A1AA");
            //driver.FindElement(By.XPath("(//div[@class='field field--optional']//input)[2]")).SendKeys("+441579382391");
            driver.FindElement(By.XPath("//input[@placeholder='First name']")).SendKeys("Purva");
            driver.FindElement(By.XPath("//input[@placeholder='Last name']")).SendKeys("Malhotra");
            driver.FindElement(By.XPath("//input[@placeholder='Address']")).SendKeys("Sector-18");
            driver.FindElement(By.XPath("//input[@placeholder='City']")).SendKeys("Albaston");
            //SelectElement Select2 = new SelectElement(driver.FindElement(By.XPath("(//select)[2]")));
            //Select2.SelectByValue("HR");
            driver.FindElement(By.XPath("//input[@placeholder='Postcode']")).SendKeys("SW1A1AA");
        }
        [Then(@"user continued the payment process")]
        public void ThenUserContinuedThePaymentProcess()
        {
            driver.FindElement(By.XPath("((//form)[1]//button)[3]/span")).Click();
            
        }


        

    }
}
