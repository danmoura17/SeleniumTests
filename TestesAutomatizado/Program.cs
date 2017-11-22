using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace TestesAutomatizado {

    [TestFixture]
    class Program {
        [Test]
        public void DeveCadastrarUsuario() {
            IWebDriver firefox = new FirefoxDriver();

            firefox.Navigate().GoToUrl("http://localhost:65186");

            IWebElement buttonLearn = firefox.FindElement(By.ClassName("btn-primary"));

            buttonLearn.Click();

            bool achouNome = firefox.PageSource.Contains("Free courses");

            firefox.Close();
            Assert.IsTrue(achouNome);

        }
    }
}
