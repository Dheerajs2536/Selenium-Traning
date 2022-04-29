using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace QA_Tranining
{
    public class Program
    {
       public void Home()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";

            Console.WriteLine("Test execute successfully");
        }
    }
}
