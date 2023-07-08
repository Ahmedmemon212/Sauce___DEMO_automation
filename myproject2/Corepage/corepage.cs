using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDEMO
{
    public class corepage
    {
        public static IWebDriver driver;
        public static void SeleniumInit(string bro)
        {
            if (bro == "Chrome")
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("--start-maximized");
                IWebDriver chromeDriver = new ChromeDriver(chromeOptions);
                driver = chromeDriver;
            }
            else if(bro == "FireFox")
            {

            }

        }
        
    }
}
