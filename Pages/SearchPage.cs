using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Automation_Testing_Project_Anhoch.Tests
{
    [TestFixture]
    public class SearchPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://www.anhoch.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SearchTest()
        {
            string searchTerm = "iPhone";

            // Enter search term  
            var searchInput = driver.FindElement(By.Name("query"));
            searchInput.SendKeys(searchTerm);
            searchInput.SendKeys(Keys.Enter);

            // Wait until results are loaded  
            wait.Until(d => d.FindElements(By.CssSelector(".product-grid .product-item")).Any());

            // Get search results  
            var results = driver.FindElements(By.CssSelector(".product-grid .product-item"));

            // Assert that results exist  
            Assert.That(results.Count, Is.GreaterThan(0), "No search results were found.");

            // Optional: check if some results mention the term  
            bool found = results.Any(r => r.Text.ToLower().Contains("iphone"));
            Assert.That(found, Is.True, $"None of the results contain the term '{searchTerm}'.");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
