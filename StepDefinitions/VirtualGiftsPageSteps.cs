using RedCrossWithBDD.Pages;
using OpenQA.Selenium;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class VirtualGiftsPageSteps:LinksUtility
    {
        VirtualGiftsPage virtualGiftsPage = new VirtualGiftsPage();

        [When(@"user clicked on the gift to be selected")]
        [Then(@"user clicked on the gift to be selected")]
        public void ThenUserClickedOnTheGiftToBeSelected()
        {
            virtualGiftsPage.UserClickedOnTheGiftToBeSelected();
        }

        [Then(@"user selected a greeting card")]
        public void ThenUserSelectedAGreetingCard()
        {
            virtualGiftsPage.UserSelectedAGreetingCard();
        }

        [When(@"user haven't selected a card")]
        [Then(@"user haven't selected a card")]
        public void ThenUserHaventSelectedACard()
        {
            virtualGiftsPage.UserHaventSelectedACard();
        }

        [Then(@"user selected an Ecard")]
        public void ThenUserSelectedAnEcard()
        {
            virtualGiftsPage.UserSelectedAnEcard();
        }

        [Then(@"user entered Recipient's Name")]
        public void ThenUserEnteredRecipientsName()
        {
            virtualGiftsPage.UserEnteredRecipientsName();
        }

        [Then(@"user entered his/her Name")]
        public void ThenUserEnteredHisHerName()
        {
            driver.FindElement(By.Id("ecard-field--your-name")).SendKeys("UNAME");
        }

        [Then(@"user entered the Message")]
        public void ThenUserEnteredTheMessage()
        {
            virtualGiftsPage.UserEnteredTheMessage();
        }
        [Then(@"user entered the Message with word limit")]
        public void ThenUserEnteredTheMessageWithWordLimit()
        {
            virtualGiftsPage.UserEnteredTheMessageWithWordLimit();
        }

        [When(@"user entered the Message which is optional")]
        [Then(@"user entered the Message which is optional")]
        public void ThenUserEnteredTheMessageWhichIsOptional()
        {
            virtualGiftsPage.UserEnteredTheMessageWhichIsOptional();
        }

        [Then(@"user entered the Message Recipient's Email")]
        public void ThenUserEnteredTheMessageRecipientsEmail()
        {
            virtualGiftsPage.UserEnteredTheMessageRecipientsEmail();
        }

        [Then(@"user added the gift to cart")]
        [When(@"user added the gift to cart")]
        public void ThenUserAddedTheGiftToCart()
        {
            virtualGiftsPage.UserAddedTheGiftToCart();
        }
        [When(@"user selected keeping in touch")]
        [Then(@"user selected keeping in touch")]
        public void ThenUserSelectedKeepingInTouch()
        {
            virtualGiftsPage.UserSelectedKeepingInTouch();
        }
        [Then(@"user checkout the product from cart")]
        public void ThenUserCheckoutTheProductFromCart()
        {
            virtualGiftsPage.UserCheckoutTheProductFromCart();
        }
        [Then(@"user selected another gift from suggestions")]
        public void ThenUserSelectedAnotherGiftFromSuggestions()
        {
            virtualGiftsPage.UserSelectedAnotherGiftFromSuggestions();
        }

        [Then(@"user entered personal details")]
        public void ThenUserEnteredPersonalDetails()
        {
            virtualGiftsPage.UserEnteredPersonalDetails();
        }
        [Then(@"user continued the payment process")]
        public void ThenUserContinuedThePaymentProcess()
        {
            virtualGiftsPage.UserContinuedThePaymentProcess();
        }


        //[Then(@"user checkout the product from cart")]
        //public void ThenUserCheckoutTheProductFromCart()
        //{
        //    driver.FindElement(By.XPath("//button[@class='cart-recap__checkout button button--primary button--full button--large")).Click();
        //}

    }
}
