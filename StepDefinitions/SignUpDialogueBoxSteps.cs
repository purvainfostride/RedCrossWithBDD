using RedCrossWithBDD.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;


namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class SignUpDialogueBoxSteps:BasePage
    {
      
        [When(@"user entered Valid FirstName")]
        public void WhenUserEnteredValidFirstName()
        {
            IWebElement firstname = driver.FindElement(By.XPath("(//form[@class='form'])[3]//input[contains(@name, 'customer[first_name]')]"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", firstname); 
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='demo';",firstname);


        }

        [When(@"user entered Valid LastName")]
        public void WhenUserEnteredValidLastName()
        {
            IWebElement lastname = driver.FindElement(By.Id("customer[last_name]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='user';", lastname);
        }

        [When(@"user entered Valid Email")]
        public void WhenUserEnteredValidEmail()
        {
            IWebElement email = driver.FindElement(By.Id("register-customer[email]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='demouser1234@gmail.com';", email);
        }

        [When(@"user entered Valid Password")]
        public void WhenUserEnteredValidPassword()
        {
            IWebElement pass = driver.FindElement(By.Id("register-customer[password]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='demouser1234@';", pass);
          
        }

        [Then(@"user clicked on Create My Account button")]
        [Then(@"user is able to signup successfully")]
        public void ThenUserClickedOnCreateMyAccountButton()
        {
            IWebElement create = driver.FindElement(By.XPath("//button[contains(text(),'Create my account')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", create);
        }

       
    }
}
