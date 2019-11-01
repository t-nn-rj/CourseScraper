using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseScraperGUI
{
    public partial class MainForm : Form
    {
        private CourseScraper _scraper;

        public MainForm()
        {
            _scraper = new CourseScraper(writeOutput);
            InitializeComponent();
        }

        private void scrapeEnrollmentsBtn_Click(object sender, EventArgs e)
        {
            _scraper.FetchEnrollments(semesterInput.Text, yearInput.Text);
        }

        private void scrapeDescriptionsBtn_Click(object sender, EventArgs e)
        {
            //_scraper.FetchDescriptions(courseInput.Text.Split(','));
        }

        private void writeOutput(string output)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                outputText.AppendText(output + "\n");
            });
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            if (courseInput.MaskFull && !courseListLabel.Text.Contains(courseInput.Text.ToUpper()))
            {
                courseListLabel.Text += courseInput.Text.ToUpper() + ", ";
                if (courseListLabel.Text.Length > 40)
                {
                    var newText = courseListLabel.Text.Replace("...", "");
                    newText = newText.Remove(0, 8);
                    newText = newText.Insert(0, "...");
                    courseListLabel.Text = newText;
                }
                courseInput.ResetText();
            }
        }

        private void courseInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addCourseBtn_Click(sender, e);
            }
        }

        private void courseInput_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                courseInput.Select(0, 0);
            });
        }

        private void yearInput_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                yearInput.Select(0, 0);
            });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _scraper.Shutdown();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "txt";
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                if (!_scraper.SaveData(dialog.FileName))
                {
                    MessageBox.Show("Unable to write file to " + dialog.FileName, "Error");
                }
            }
        }
    }
}
