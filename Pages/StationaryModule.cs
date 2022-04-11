using OpenQA.Selenium;
using NUnit.Framework;

namespace RedCrossWithBDD.Pages
{
    public class StationaryModule:BasePage
    {
        public void UserClickedOnStationaryMenuButton()
        {
            driver.FindElement(By.XPath("((//nav[@class='nav-bar']//li)[12]//a)[1]")).Click();
        }
        public void UserSelectedGreetingCardsCatagoryToShop()
        {
            driver.FindElement(By.XPath("((//nav[@class='nav-bar']//li)[12]//li)[2]//a")).Click();
        }
        public void UserSelectedBirthdayCardsCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Birthday")).Click();
        }
        public void UserSelectedCongratulationsCardsCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Congratulations")).Click();
        }
        public void UserSelectedThankyouCardsCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Thank")).Click();
        }
        public void UserSelectedWrappingPaperCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Wrapping")).Click();
        }
        public void UserSelectedNotebooksCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Notebooks")).Click();
        }
        public void UserSelectedEnamelPinBadgesCatagoryToShop()
        {
            driver.FindElement(By.PartialLinkText("Enamel")).Click();
        }
        public void UserSelectedDisplayFilter()
        {
            driver.FindElement(By.XPath("(//div[@class='collection']//span[@class='hidden-phone'])[1]")).Click();
        }
        public void SelectedPerPage(int p0)
        {
            driver.FindElement(By.XPath("(//div[@class='value-picker__choice-list'])[1]//button[2]")).Click();
        }
        public void PageFilteredWithItemsPerPage(int p0)
        {
            IWebElement filter = driver.FindElement(By.XPath("//div[@class='product-item product-item--vertical  1/3--tablet-and-up 1/3--desk']"));
            Console.WriteLine(filter.Size.ToString());
        }
        public void UserSelectedBestSellingFilter()
        {
            driver.FindElement(By.XPath("(//div[@class='collection']//span[@class='hidden-phone'])[2]")).Click();
        }
        public void SelectedAlphabeticallyA_Z()
        {
            driver.FindElement(By.XPath("(//div[@class='value-picker__choice-list'])[2]//button[3]")).Click();
            driver.FindElement(By.XPath("//div[@class='product-item__info-inner']//a[contains(text(),'Bees Knees - Enamel Pin Card')]")).Click();
        }
    }
}
