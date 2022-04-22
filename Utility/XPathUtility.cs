using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCrossWithBDD.Utility
{
    public class XPathUtility
    {
        public string allProductsXpath = "(//div[@class='product-list product-list--collection product-list--with-sidebar']//a[@class='product-item__title text--strong link'])";
        public string nextpageByNumbersXPath = "//div[@class='pagination__nav']//a";
        public string nextbuttonXpath = "//div[@class='pagination__inner']//a[@title='Next']";
        public string prevbuttonXpath = "//div[@class='pagination__inner']//a[@title='Previous']";

        public string displayFilterXpath = "((//div[@class='collection__toolbar ']//div[@class='value-picker-wrapper'])//span[@class='hidden-phone'])[1]";
        public string displayFilterButtonXpath = "((//div[@class='collection__toolbar ']//div[@class='value-picker__choice-list'])//button)";
        public string sortbyFilterXpath = "((//div[@class='collection__toolbar ']//div[@class='value-picker-wrapper'])//span[@class='hidden-phone'])[2]";
        
        public string displayFilterGreetingXpath= "(//div[@class='collection__toolbar collection__toolbar--bordered']//button[@class='value-picker-button'])[1]";
        public string displayFilterButtonGreetingXpath = "(//div[@class='collection__toolbar collection__toolbar--bordered']//div[@class='value-picker__choice-list']//button)";
        public string totalamountXpath = "(//tbody//span)";

        //menubar
        public string menubarXpath = "//li[@class='nav-bar__item']";
        public string shopHomeButtonXpath = "//li[@class='nav-bar__item']//a[contains(text(),'Clothing')]";
        public string newInButtonXpath = "//li[@class='nav-bar__item']//a[contains(text(),'New In ')]";
        public string virtualGiftsButtonXpath = "//li[@class='nav-bar__item']//a[contains(text(),'Virtual Gifts')]";
        public string saleButtonXpath = "//li[@class='nav-bar__item']//a[contains(text(),'Sale')]";
        public string clothingMenuButtonXpath = "//li[@class='nav-bar__item']//a[contains(text(),'Clothing')]";
        public string homewareMenuButtonXpath = "//li[@class='nav-bar__item']//a[contains(text(),'Homeware')]";
        public string beautyMenuButtonXpath = "//li[@class='nav-bar__item']//a[contains(text(),'Beauty')]";

        //CartPage
        public string qIncXpath = "(//div[@class='quantity-selector']//button[@data-action='increase-quantity'])";
        public string qDecXpath = "(//div[@class='quantity-selector']//button[@data-action='decrease-quantity'])";
        public string fTextXpath = "(//tbody//tr//div[@class='line-item__meta'])//a[1]";
        public string addToCartXpath = "//div[@class='product-form__payment-container']//button";

        //Navigation
        public string navigationBarXpath = "//div[@class='card']//ul[@class='collection__filter-linklist']//li/a";
        public string navigationBardropdownBtnXpath="//div[@class='card']//ul[@class='collection__filter-linklist']//li//button";
        public string menuBardropdownBtnXpath = "//li[@class='nav-bar__item']//li";
    }
}
