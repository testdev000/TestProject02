using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject02
{
    public class NavigationTest
    {
        private IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void GoogleNavigationTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            Assert.That(driver.Title, Is.EqualTo("Google"));
            Console.WriteLine("Hello, world! The page title is: " + driver.Title);
        }

        [Test]
        public void SeleniumNavigationTest()
        {
            driver.Navigate().GoToUrl("https://www.selenium.dev"); 
            Assert.That(driver.Title, Is.EqualTo("SeleniumX"));
            Console.WriteLine("Hello, world! The page title is: " + driver.Title);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}