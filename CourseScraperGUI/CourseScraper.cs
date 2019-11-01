using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseScraperGUI
{
    class CourseScraper
    {
        public delegate void OutStream(string output);

        private OutStream _out;
        private FirefoxDriver _driver;
        private IDictionary<string, Course> _sessionData;

        public CourseScraper(OutStream outStream)
        {
            // perform web driver setup
            var options = new FirefoxOptions();
            options.LogLevel = FirefoxDriverLogLevel.Fatal;
            _driver = new FirefoxDriver(options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            _out = outStream;
            _sessionData = new Dictionary<string, Course>();
        }

        public void FetchEnrollments(string semester, string year, int max = 100)
        {
            _out($"Scraping all CS enrollments for {semester} {year}");
            var results = new Dictionary<string, Course>();
            _driver.Navigate().GoToUrl("https://student.apps.utah.edu/uofu/stu/ClassSchedules/main/1"
                + year.Substring(2) + semCode(semester) + "/class_list.html?subject=CS");

            // scrape course details
            var table = _driver.FindElementById("classDetailsTable");
            var rows = table.FindElements(By.CssSelector("tbody > tr:not(.notes)"));
            int i = 0;
            foreach (var row in rows)
            {
                if (i++ >= 100)
                {
                    break;
                }

                try
                {
                    string section = row.FindElement(By.CssSelector("td:nth-child(4)")).Text;
                    int courseNum = int.Parse(row.FindElement(By.CssSelector("td:nth-child(3)")).Text);
                    string title = row.FindElement(By.CssSelector("td:nth-child(7)")).Text;
                    if (section == "001" && courseNum >= 1000 && courseNum <= 7000
                        && !title.ToUpper().Contains("SEMINAR") && !title.ToUpper().Contains("SPECIAL TOPICS"))
                    {
                        string dept = row.FindElement(By.CssSelector("td:nth-child(2)")).Text;
                        results.Add((dept + courseNum).ToUpper(), new Course
                        {
                            Department = dept,
                            Number = courseNum.ToString(),
                            Credits = row.FindElement(By.CssSelector("td:nth-child(6)")).Text,
                            Title = title,
                            Semester = semester,
                            Year = year
                        });
                    }
                }
                catch
                {
                    _out("Unable to read course details at index " + i);
                }
            }

            // scrape enrollments
            _driver.FindElementByLinkText("Seating availability for all CS classes").Click();
            rows = _driver.FindElementsByCssSelector("tbody > tr");
            foreach (var row in rows)
            {
                string dept = row.FindElement(By.CssSelector("td:nth-child(2)")).Text;
                string num = row.FindElement(By.CssSelector("td:nth-child(3)")).Text;
                if (results.ContainsKey((dept+num).ToUpper()))
                {
                    Course course = results[(dept + num).ToUpper()];
                    course.Enrollment = row.FindElement(By.CssSelector("td:nth-child(7)")).Text;
                }
            }
            _out($"Found {results.Count()} courses");

            // scrape descriptions
            FetchDescriptions(results);

            // update saved data & print
            foreach (var c in results)
            {
                if (!_sessionData.ContainsKey(c.Key))
                {
                    _sessionData.Add(c);
                }
                else
                {
                    _sessionData[c.Key] = c.Value;
                }
                _out("\n" + c.Value.toOutputString());
            }
        }

        public void FetchDescriptions(IDictionary<string, Course> courses)
        {
            _out($"Scraping course descriptions for {courses.Count} courses");            
        }

        public bool SaveData(string path)
        {
            try
            {
                var data = String.Join(String.Empty, _sessionData.Select(c => c.Value.toSaveString()));
                File.WriteAllText(path, data);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Shutdown()
        {
            _driver.Quit();
        }

        // returns 4,6,8 semester code
        private int semCode(string semester)
        {
            switch (semester)
            {
                case "Spring": return 4;
                case "Summer": return 6;
                case "Fall": return 8;
                default: return 0;
            }
        }
    }

    public class Course
    {
        public string Department;
        public string Number;
        public string Credits;
        public string Title;
        public string Enrollment;
        public string Semester;
        public string Year;
        public string Description;
        
        public string toSaveString()
        {
            return $"{Department}, {Number}, {Credits}, {Title}, {Enrollment}, {Semester}, {Year}, {Description}\n";
        }

        public string toOutputString()
        {
            return $"{Department}{Number}: {Title}\nCredits: {Credits}\nSemester: {Semester} {Year}\nEnrollment: {Enrollment}\nDescription: {Description}";
        }
    }

}
