using RedCrossWithBDD.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace RedCrossWithBDD.Pages
{
    public class SignupAndLoginPage:LinksUtility
    {
        public void UserEnteredValidFirstName()
        {
            IWebElement firstname = driver.FindElement(By.XPath("(//form[@class='form'])[3]//input[contains(@name, 'customer[first_name]')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Poorva';", firstname);
        }
        public void UserEnteredValidLastName()
        {
            IWebElement lastname = driver.FindElement(By.Id("customer[last_name]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Malhotra';", lastname);
        }
        public void UserEnteredValidEmail()
        {
            IWebElement email = driver.FindElement(By.Id("register-customer[email]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='purvamalhotra815@gmail.com';", email);
        }
        public void UserEnteredValidPassword()
        {
            IWebElement pass = driver.FindElement(By.Id("register-customer[password]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='purvamalhotra815@';", pass);
        }
        public void UserClickedOnCreateMyAccountButton()
        {
            IWebElement create = driver.FindElement(By.XPath("//button[contains(text(),'Create my account')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", create);
        }
        public void UserEnteredValidEmailID()
        {
            IWebElement emailID = driver.FindElement(By.Id("login-customer[email]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='purvamalhotra815@gmail.com';", emailID);
        }
        public void UserEnteredValidUserPassword()
        {
            IWebElement userpass = driver.FindElement(By.Id("login-customer[password]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='purvamalhotra815@';", userpass);
        }
        public void UserClickOnLoginButton()
        {
            IWebElement loginBtn = driver.FindElement(By.XPath("(//form[@class='form'])[1]//button"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", loginBtn);
        }
    }
}
