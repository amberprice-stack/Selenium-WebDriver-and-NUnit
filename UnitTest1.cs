using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");
        }

        [Test]
        public void Test1()
        {
            driver.Url = "http://www.google.com";
        }

        [TearDown]

        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}