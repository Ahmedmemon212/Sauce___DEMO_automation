using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDEMO
{
    public class SelectitemPage:corepage
    {


         By sortprodPrice = By.CssSelector("#inventory_filter_container > select > option:nth-child(3)");
        By item1SelectbTn = By.CssSelector("#inventory_container > div > div:nth-child(1) > div.pricebar > button");
        By item1SelectbTn2 = By.CssSelector("#inventory_container > div > div:nth-child(3) > div.pricebar > button");
        By Cartbtn = By.CssSelector("#shopping_cart_container > a > svg");



        public void Selectitmes()
        {

           
             driver.FindElement(sortprodPrice).Click();
            driver.FindElement(item1SelectbTn).Click();
             driver.FindElement(item1SelectbTn2).Click();
            driver.FindElement(Cartbtn).Click();

        }
    }
}
