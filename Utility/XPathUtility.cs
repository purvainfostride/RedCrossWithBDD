using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCrossWithBDD.Utility
{
    public class XPathUtility
    {
        public string AllProductsXpath = "(//div[@class='product-list product-list--collection product-list--with-sidebar']//a[@class='product-item__title text--strong link'])";
        public string nextpageByNumbersXPath = "//div[@class='pagination__nav']//a";
        public string nextbuttonXpath = "//div[@class='pagination__inner']//a[@title='Next']";
        public string prevbuttonXpath = "//div[@class='pagination__inner']//a[@title='Previous']";

        public string displayFilterXpath = "((//div[@class='collection__toolbar ']//div[@class='value-picker-wrapper'])//span[@class='hidden-phone'])[1]";
        public string displayFilterButtonXpath = "((//div[@class='collection__toolbar ']//div[@class='value-picker__choice-list'])//button)";
        public string sortbyFilterXpath = "((//div[@class='collection__toolbar ']//div[@class='value-picker-wrapper'])//span[@class='hidden-phone'])[2]";

        public string totalamountXpath = "(//tbody//span)";
    
    }
}
