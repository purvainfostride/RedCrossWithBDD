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
    {   CartPage cartPage=new CartPage();

        [When(@"user selected keeping in touch")]
        [Then(@"user selected keeping in touch")]
        public void ThenUserSelectedKeepingInTouch()
        {
            cartPage.UserSelectedKeepingInTouch();
        }
        [Then(@"user checkout the product from cart")]
        public void ThenUserCheckoutTheProductFromCart()
        {
            cartPage.UserCheckoutTheProductFromCart();
        }
        [Then(@"user selected another gift from suggestions")]
        public void ThenUserSelectedAnotherGiftFromSuggestions()
        {
            cartPage.UserSelectedAnotherGiftFromSuggestions();
        }

        [Then(@"user entered personal details")]
        public void ThenUserEnteredPersonalDetails()
        {
            cartPage.UserEnteredPersonalDetails();
        }
        [Then(@"user continued the payment process")]
        public void ThenUserContinuedThePaymentProcess()
        {
            cartPage.UserContinuedThePaymentProcess();
        }


        

    }
}
