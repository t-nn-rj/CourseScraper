using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseScraperGUI
{
    class CourseScraper
    {
        // global webdriver
        public static FirefoxDriver _driver;

        public CourseScraper()
        {
            // perform web driver setup
            var options = new FirefoxOptions();
            options.LogLevel = FirefoxDriverLogLevel.Fatal;
            _driver = new FirefoxDriver(options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
