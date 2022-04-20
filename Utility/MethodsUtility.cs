using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RedCrossWithBDD.Utility
{
    public class MethodsUtility : LinksUtility
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

        public void excel()
        {
            string path = @"C:\\Users\\Purva\\C#\\RedCrossWithBDD\\TestData\\NewInPageData.xls";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            HSSFWorkbook wb = new HSSFWorkbook(fs);
            ISheet sheet = wb.GetSheetAt(0);
            if (sheet != null)
            {
                int rowCount = sheet.LastRowNum;
                for (int i = 0; i < rowCount; i++)
                {
                    IRow curRow = sheet.GetRow(i);
                    var cellvalue0 = curRow.GetCell(0).StringCellValue.Trim();
                }
            }

        }
    }
}
