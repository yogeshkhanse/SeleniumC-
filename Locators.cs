using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace SeleniumLearning
{
    public class Locators
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //Implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/locatorspractice/";

        }

        [Test]
        public void Locatores()
        {
            driver.FindElement(By.Id("inputUsername")).SendKeys("YogeshKhasne");
            driver.FindElement(By.Name("inputPassword")).SendKeys("123456");
            //Xpath
            driver.FindElement(By.XPath("//*[@id=\"chkboxOne\"]")).Click();
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            //Thread.Sleep(1000);
            String errormsg = driver.FindElement(By.ClassName("error")).Text;
            TestContext.Progress.WriteLine(errormsg);

            
        }

        [TearDown] 
        public void TeardownBrowser() 
        { 
            //driver.Close();
        }
    }
}
