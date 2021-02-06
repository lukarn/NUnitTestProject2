using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace NUnitTestProject2
{
    public class Tests
    {
        IWebDriver webDriver;



        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver("C:\\selGrid");
        }

        [Test]
        public void Test1()
        {
            webDriver.Url = "http://www.google.com";
            Thread.Sleep(3000);

            //webDriver.Url = "http://www.wp.pl";

            //Thread.Sleep(3000);
            //Assert.IsTrue(false, "dsdf=================");


            //Assert.Pass();
        }

        [Test]
        public void Test2()
        {

            webDriver.Url = "http://www.wp.pl";

            Thread.Sleep(3000);
            Assert.IsTrue(true, "dsdf=================");


            //Assert.Pass();
        }

        [Test]
        public void Test3()
        {


            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            webDriver.Close();
        }
    }
}