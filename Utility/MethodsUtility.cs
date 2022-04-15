﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RedCrossWithBDD.Utility
{
    public class MethodsUtility:LinksUtility
    {
        
        public void CountAllProducts()
        {   
            var stationarypageProducts = driver.FindElements(By.XPath(AllProductsXpath));
            var p1 = stationarypageProducts.Count();
        }

        public void UserClosedTheBrowser()
        {
            driver.Quit();  
        }
    }
}