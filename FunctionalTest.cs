using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V122.DOMStorage;

namespace SeleniumLearning
{
    public class FunctionalTest
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
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

        }

        [Test]
        public void dropdown()
        {

            IWebElement dropdown = driver.FindElement(By.CssSelector("#dropdown-class-example"));
            SelectElement s = new SelectElement(dropdown);
            s.SelectByText("Option1");
            s.SelectByValue("option3");
            s.SelectByIndex(1);
        }

        [Test]
        public void radiobutton()
        {
            //If id's are not unique
            IList<IWebElement> rdos = driver.FindElements(By.XPath("//input[@name=\"radioButton\"]"));
            foreach (IWebElement radiobutton in rdos)
            {
                if (radiobutton.GetAttribute("value").Equals("radio2"))
                {
                    radiobutton.Click();
                }
            }
        }
    }
}
