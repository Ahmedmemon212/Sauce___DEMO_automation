using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDEMO
{
    public class loginPage:corepage
    {

        By usernames = By.Id("user-name");
        By pass = By.Id("password");
        By loginBTN= By.Id("login-button");

        public void login(string url, string username, string password)
        {

            //IWebDriver driver = new ChromeDriver();
            driver.Url = url;
            driver.FindElement(usernames).SendKeys(username);
            driver.FindElement(pass).SendKeys(password);
            driver.FindElement(loginBTN).Click();
        }
    }
}
