using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDEMO.myproject2.checkoutpage
{
    public class chechOUT:corepage
    {
        By firstname = By.Id("first-name");
        By lastname = By.Id("last-name");
        By zipCOde = By.Id("postal-code");
        By contBtn = By.CssSelector("#checkout_info_container > div > form > div.checkout_buttons > input");

        public void checkout()
        {
            driver.FindElement(firstname).SendKeys("ahmed");
            driver.FindElement(lastname).SendKeys("memon");
            driver.FindElement(zipCOde).SendKeys("memon");
            driver.FindElement(contBtn).Click();
        }
    }
}
