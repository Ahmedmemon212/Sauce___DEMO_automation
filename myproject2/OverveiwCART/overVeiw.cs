using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SauceDEMO.myproject2.OverveiwCART
{
    public class overVeiw:corepage
    {
        By finshBTN = By.CssSelector("#checkout_summary_container > div > div.summary_info > div.cart_footer > a.btn_action.cart_button");
        By sideBAR = By.CssSelector("#menu_button_container > div > div:nth-child(3) > div > button");
        By logBTN = By.CssSelector("#logout_sidebar_link");

        public void overveiw()
        {
            Thread.Sleep(1000);
            driver.FindElement(finshBTN).Click();
            Thread.Sleep(1000);
            driver.FindElement(sideBAR).Click();
            Thread.Sleep(1000);
            driver.FindElement(logBTN).Click();
            Thread.Sleep(1000);


        }
    }
}
