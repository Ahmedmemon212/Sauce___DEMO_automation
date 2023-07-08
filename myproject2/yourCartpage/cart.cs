using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDEMO
{
    public class cart:corepage
    {


       //  By sortprodPrice = By.CssSelector("#inventory_filter_container > select > option:nth-child(3)");
        By itemRemoveBTN = By.CssSelector("#cart_contents_container > div > div.cart_list > div:nth-child(3) > div.cart_item_label > div.item_pricebar > button");
      //  By item1SelectbTn2 = By.CssSelector("#inventory_container > div > div:nth-child(3) > div.pricebar > button");
        By CeckoutBTN = By.CssSelector("#cart_contents_container > div > div.cart_footer > a.btn_action.checkout_button");



        public void yourCart()
        {

           
             driver.FindElement(itemRemoveBTN).Click();
            driver.FindElement(CeckoutBTN).Click();
            // driver.FindElement(item1SelectbTn2).Click();
           // driver.FindElement(Cartbtn).Click();

        }
    }
}
