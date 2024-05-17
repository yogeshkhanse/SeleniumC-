using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class SortWebTable
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
            driver.Url = "https://rahulshettyacademy.com/seleniumPractise/#/offers";

        }

        [Test]
        public void SortTable()
        {
            

            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("page-menu")));
            dropdown.SelectByText("20");

            // step 1 - Get all  veggie name into array lisy A
            ArrayList a = new ArrayList();
            IList<IWebElement> veggies = driver.FindElements(By.XPath("//tr/td[1]"));
            foreach (IWebElement veggie in veggies)
            {
                a.Add(veggie.Text);

            }
                //Step 2 - sort array list
                a.Sort();

                //step 3 - go and click on column
                driver.FindElement(By.CssSelector("th[aria-label*=\"fruit\"]")).Click();

                // Step 4 - Get all  veggie name into array lisy B

                ArrayList b = new ArrayList();

                IList<IWebElement> sortedveggies = driver.FindElements(By.XPath("//tr/td[1]"));
                foreach (IWebElement veggi in sortedveggies)
                {
                    b.Add(veggi.Text);  
                }

            // Array list A to B = equal

            Assert.AreEqual(a, b);
        }

        }
    
}
