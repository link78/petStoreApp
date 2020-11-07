using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.ComponentModel;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace PetSoreApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver ;
        private string url;
        

        
        [TestMethod]
        public void TestMethod1()
        {

            driver.Navigate().GoToUrl(url + "autocomplete");

       

            driver.FindElement(By.Id("autocomplete")).SendKeys("7221 Greenwood Ct, Lincoln, Nebraska");

            Thread.Sleep(500);

            driver.FindElement(By.ClassName("pac-item")).Click();


            
        }


        [TestMethod]
        public void TestForm()
        {

            driver.Navigate().GoToUrl(url + "form");

            driver.FindElement(By.Id("first-name")).SendKeys("kade");

            driver.FindElement(By.Id("last-name")).SendKeys("abdul");

            driver.FindElement(By.Id("job-title")).SendKeys("DevOps Engineer");

            driver.FindElement(By.Id("radio-button-2")).Click();
            
            driver.FindElement(By.Id("checkbox-1")).Click();

            driver.FindElement(By.CssSelector(".btn")).Click();


     



        }

        [TestMethod]
        public void TestDragBox()
        {
            driver.Navigate().GoToUrl(url + "dragdrop");

            driver.FindElement(By.Id("image")).Click();

            driver.FindElement(By.Id("box"));
            Thread.Sleep(500);
            Actions actions = new Actions(driver);
            actions.DragAndDrop(driver.FindElement(By.Id("image")), driver.FindElement(By.Id("box"))).Build().Perform();
        }

        [TestInitialize()]
        public void SetupTest()
        {
            url = "https://formy-project.herokuapp.com/";
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
            driver.Quit();
        }
    }
}
