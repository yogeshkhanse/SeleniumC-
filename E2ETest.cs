using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class E2ETest
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
            driver.Url = "https://rahulshettyacademy.com/seleniumPractise/#/";

        }

        [Test]
        public void EndToEndFlow()
        {
            String[] expectedproducts = { "Brocolli - 1 Kg", "Cauliflower - 1 Kg" };

            IList<IWebElement> product = driver.FindElements(By.XPath("//div[@class=\"product\"]"));
            foreach (IWebElement card in product)
            {
                if (expectedproducts.Contains(card.FindElement(By.CssSelector(".product-name")).Text))
                {
                    //click on cart
                    card.FindElement(By.CssSelector(".product-action button")).Click();
                }

                TestContext.Progress.WriteLine(card.FindElement(By.CssSelector(".product-name")).Text);
            }

        }

    }
}
