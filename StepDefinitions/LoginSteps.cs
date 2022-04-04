using RedCrossWithBDD.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace RedCrossWithBDD.StepDefinitions
{
    [Binding]
    public class LoginSteps:BasePage
    {
        [When(@"user entered Valid EmailID")]
        public void WhenUserEnteredValidEmailID()
        {
            IWebElement emailID = driver.FindElement(By.Id("login-customer[email]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@gmail.com';", emailID);
        }

        [When(@"user entered Valid UserPassword")]
        public void WhenUserEnteredValidUserPassword()
        {
            IWebElement userpass = driver.FindElement(By.Id("login-customer[password]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='poorvamalhotra815@';", userpass);
        }
        [Then(@"user click on Login Button")]
       
        [Then(@"user logged in successfully")]

        public void WhenUserClickOnLoginButton()
        {
            IWebElement loginBtn = driver.FindElement(By.XPath("(//form[@class='form'])[1]//button"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", loginBtn);
        }
    }
}
