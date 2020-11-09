using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace PetSoreApp.Test
{
    [TestClass]
    class PetStoreUI_Testing
    {
        private IWebDriver driver;
        private string url;




[TestMethod]
public void TestMethod1()
{

    driver.Navigate().GoToUrl(url + "autocomplete");

    driver.FindElement(By.Id("autocomplete")).SendKeys("7221 Greenwood Ct, Lincoln, Nebraska");
    //  Thread.Sleep(500);
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
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
    //       Thread.Sleep(2000);
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
    driver.FindElement(By.Id("select-menu")).Click();

    driver.FindElement(By.CssSelector("option[value='3']")).Click();

    IWebElement datepicker = driver.FindElement(By.Id("datepicker"));

    datepicker.SendKeys("11/7/2020");
    datepicker.SendKeys(Keys.Return);
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
    // Thread.Sleep(4000);
    driver.FindElement(By.CssSelector(".btn.btn-lg.btn-primary")).Click();






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
    string browser = "Firefox";

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
    Thread.Sleep(500);
    driver.Quit();
}
    }
}

