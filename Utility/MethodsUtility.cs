using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RedCrossWithBDD.Utility
{
    public class MethodsUtility:LinksUtility
    {
        XPathUtility xpathUtility = new XPathUtility();

        public void CountAllProducts()
        {   
            var stationarypageProducts = driver.FindElements(By.XPath(xpathUtility.allProductsXpath));
            var p1 = stationarypageProducts.Count();
        }
        
        public void UserClosedTheBrowser()
        {
            driver.Quit();  
        }

        public void Enter()
        {
            Console.WriteLine("Choose A page to shop: /n ShopHome 1 /n NewArrival");
            int menubutton = Console.Read();
            Console.WriteLine("menubutton is: " + menubutton);

        }

    }
}
