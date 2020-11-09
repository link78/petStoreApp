using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.ComponentModel;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System;

namespace PetSoreApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver ;
        private string url;

        [TestMethod]
        public void TestCreateOwner()
        {
            driver.Navigate().GoToUrl(url + "/Owners/Create");
            driver.FindElement(By.Id("FirstName")).SendKeys("Louise");
            driver.FindElement(By.Id("LastName")).SendKeys("Wiliamson");
            driver.FindElement(By.CssSelector("input[id='email'")).SendKeys("williams.l@gmail.com");
            driver.FindElement(By.CssSelector("#Photo")).SendKeys("yes");
            driver.FindElement(By.Id("PhoneNumber")).SendKeys("402-005-1215");
            driver.FindElement(By.CssSelector("input[value='Create'")).Click();
        }


        [TestMethod]
        public void TestEditOwner()
        {
            driver.Navigate().GoToUrl(url + "/Owners/Edit/2");
            driver.FindElement(By.Id("FirstName")).SendKeys("Johnny");
            driver.FindElement(By.Id("LastName")).SendKeys("Chris");
            driver.FindElement(By.CssSelector("input[id='email'")).SendKeys("jhonny_chris@yahoo.com");
            driver.FindElement(By.CssSelector("#Photo")).SendKeys("none");
            driver.FindElement(By.Id("PhoneNumber")).SendKeys("646-120-3030");
            driver.FindElement(By.CssSelector("input[value='Save'")).Click();
        }

        /**
        [TestMethod]
        public void TestDeleteOwner()
        {
            driver.Navigate().GoToUrl(url + "/Owners/Delete/4");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("input[value='Delete'")).Click();
        }
        **/

        [TestMethod]
        public void TestCreatePet()
        {
            driver.Navigate().GoToUrl(url + "/Pets/Create");
            driver.FindElement(By.Id("Name")).SendKeys("Wally");
            driver.FindElement(By.Id("OwnerId")).Click();
            driver.FindElement(By.CssSelector("option[value='7'")).Click();
            driver.FindElement(By.CssSelector("#Age")).SendKeys("3");
            driver.FindElement(By.Id("Picture")).SendKeys("yes");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("input[value='Create'")).Click();
        }


        [TestMethod]
        public void TestEditPet()
        {
            driver.Navigate().GoToUrl(url + "/Pets/Edit/2");
            driver.FindElement(By.Id("Name")).SendKeys("Bumpy");
            driver.FindElement(By.Id("OwnerId")).Click();
            driver.FindElement(By.CssSelector("option[value='2'")).Click();
            driver.FindElement(By.CssSelector("#Age")).SendKeys("2");
            driver.FindElement(By.Id("Picture")).SendKeys("yes");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("input[value='Save'")).Click();
        }

        /**
        [TestMethod]
        public void TestDeletePet()
        {
            driver.Navigate().GoToUrl(url + "/Pets/Delete/1");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("input[value='Delete'")).Click();
        }  **/



        [TestInitialize()]
        public void SetupTest()
        {
            url = "http://localhost:54117";
            string browser = "Chrome";

            switch (browser)
            {

                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}

