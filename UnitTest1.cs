using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SauceDEMO.myproject2.checkoutpage;
using SauceDEMO.myproject2.OverveiwCART;
using System;
using System.Configuration;

namespace SauceDEMO
{
    [TestClass]
    public class UnitTest1
    {
        #region setups and cleanups 

        public TestContext instance;

        public TestContext TestContext
        {

            set { instance = value; }
            get { return instance; }

        }

        [ClassInitialize()]

        public static void classint(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void classcleanup()
        {

        }

        [TestInitialize()]
        public void Testint()
        {
            corepage.SeleniumInit(ConfigurationManager.AppSettings["Browser"].ToString());
        }

        [TestCleanup()]
        public void Testcleanup()
        {
            corepage.driver.Close();
        }

        #endregion
    
        loginPage loginP = new loginPage();
        SelectitemPage select = new SelectitemPage();
        cart mycart = new cart();
        chechOUT check = new chechOUT();
        overVeiw veiw = new overVeiw();

        [TestMethod]

        public void login_with_valid()
        {
            
            loginP.login("https://www.saucedemo.com/v1/", "standard_user", "secret_sauce");
            string actualTEXT = corepage.driver.FindElement(By.ClassName("footer_copy")).Text;
            Assert.AreEqual("© 2020 Sauce Labs. All Rights Reserved. Terms of Service | Privacy Policy", actualTEXT);
           
        }
        
         [TestMethod]

         public void login_with_invalid()
         {
             
             loginP.login("https://www.saucedemo.com/v1/", "standard_user212", "secret_sauce122");
            // string actualTEXT = corepage.driver.FindElement(By.CssSelector("#login_button_container > div > form > h3")).Text;
            // Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", actualTEXT);
             
         }
        
        
        [TestMethod]

        public void productselection()
        {
            
            loginP.login("https://www.saucedemo.com/v1/", "standard_user", "secret_sauce");
            select.Selectitmes();
            
        }
        [TestMethod]

        public void cartpage__TC001()
        {
            
            loginP.login("https://www.saucedemo.com/v1/", "standard_user", "secret_sauce");
            select.Selectitmes();
            mycart.yourCart();
            
        }

        [TestMethod]

        public void checkout__TC001()
        {
            
            loginP.login("https://www.saucedemo.com/v1/", "standard_user", "secret_sauce");
            select.Selectitmes();
            mycart.yourCart();
            check.checkout();
            
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "data2.xml", "OverView__TC001", DataAccessMethod.Sequential)]

        public void OverView__TC001()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            loginP.login(url, user, pass);
            select.Selectitmes();
            mycart.yourCart();
            check.checkout();
            veiw.overveiw();
            
        }




    }
}
