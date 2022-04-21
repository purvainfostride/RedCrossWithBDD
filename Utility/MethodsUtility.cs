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
        public void Excel()
        {
            string path = @"C:\\Users\\Purva\\C#\\RedCrossWithBDD\\TestData\\NewInPageData.xls";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            HSSFWorkbook wb = new HSSFWorkbook(fs);
            ISheet sheet = wb.GetSheetAt(0);
            int rowCount = sheet.LastRowNum;
            for (int i = 0; i < rowCount; i++)
            {
                IRow curRow = sheet.GetRow(i);
                var cellvalue0 = curRow.GetCell(0).StringCellValue.Trim();
            }
        }
        public static void Textfile()
        {
            
            string textFile = @"C:\Users\Purva\C#\RedCrossWithBDD\TestData\NewinPageFilter.txt";

            //if (File.Exists(textFile))
            //{
            //    // Read entire text file content in one string    
            //    string text = File.ReadAllText(textFile);
            //    Console.WriteLine("Read entire text file content in one string "+text);
            //}

            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                //foreach (string line in lines)
                //    //Console.WriteLine("Read a text file line by line: " + line);
                
                for(int i = 1; i < lines.Length; i++)
                {
                        Console.WriteLine("Read a text file line by line: " +lines[i]);
                }


            }
            
            //if (File.Exists(textFile))
            //{
            //    // Read file using StreamReader. Reads file line by line  
            //    using (StreamReader file = new StreamReader(textFile))
            //    {
            //        int counter = 0;
            //        string ln;

            //        while ((ln = file.ReadLine()) != null)
            //        {
            //            Console.WriteLine("Read file using StreamReader. Reads file line by line "+ln);
            //            counter++;
            //        }
            //        file.Close();
            //        Console.WriteLine();
            //    }
            //}

            //Console.ReadKey();
        }
        
    }
}
