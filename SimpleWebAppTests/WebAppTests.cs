using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SimpleWebAppTests
{
    [TestClass]
    public class WebAppTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }

        [TestMethod]
        public void TestPageLoad()
        {
            driver.Navigate().GoToUrl("http://localhost:5240");
            Assert.AreEqual("Enter your details", driver.FindElement(By.TagName("h2")).Text);
        }

        [TestMethod]
        public void TestFormSubmission()
        {
            driver.Navigate().GoToUrl("http://localhost:5240");
            driver.FindElement(By.Id("name")).SendKeys("John Doe");
            driver.FindElement(By.Id("email")).SendKeys("john.doe@example.com");
            driver.FindElement(By.Id("phone")).SendKeys("1234567890");
            driver.FindElement(By.TagName("button")).Click();

            Thread.Sleep(3000); // Simulate delay
            
            var welcomeMessage = driver.FindElement(By.TagName("h3")).Text;
            Assert.AreEqual("Welcome, John Doe!", welcomeMessage);
        }
    }
}