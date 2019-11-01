namespace CourseScraperGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.courseListLabel = new System.Windows.Forms.Label();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.scrapeDescriptionsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.courseInput = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scrapeEnrollmentsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.MaskedTextBox();
            this.semesterInput = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.courseListLabel);
            this.groupBox2.Controls.Add(this.addCourseBtn);
            this.groupBox2.Controls.Add(this.scrapeDescriptionsBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.courseInput);
            this.groupBox2.Location = new System.Drawing.Point(360, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Descriptions";
            // 
            // courseListLabel
            // 
            this.courseListLabel.AutoSize = true;
            this.courseListLabel.Location = new System.Drawing.Point(105, 45);
            this.courseListLabel.Name = "courseListLabel";
            this.courseListLabel.Size = new System.Drawing.Size(0, 13);
            this.courseListLabel.TabIndex = 7;
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Location = new System.Drawing.Point(76, 41);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(23, 22);
            this.addCourseBtn.TabIndex = 6;
            this.addCourseBtn.Text = "+";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // scrapeDescriptionsBtn
            // 
            this.scrapeDescriptionsBtn.Location = new System.Drawing.Point(22, 78);
            this.scrapeDescriptionsBtn.Name = "scrapeDescriptionsBtn";
            this.scrapeDescriptionsBtn.Size = new System.Drawing.Size(306, 35);
            this.scrapeDescriptionsBtn.TabIndex = 5;
            this.scrapeDescriptionsBtn.Text = "Scrape Course Descriptions";
            this.scrapeDescriptionsBtn.UseVisualStyleBackColor = true;
            this.scrapeDescriptionsBtn.Click += new System.EventHandler(this.scrapeDescriptionsBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course";
            // 
            // courseInput
            // 
            this.courseInput.Location = new System.Drawing.Point(22, 42);
            this.courseInput.Mask = "AA0000";
            this.courseInput.Name = "courseInput";
            this.courseInput.Size = new System.Drawing.Size(49, 20);
            this.courseInput.TabIndex = 4;
            this.courseInput.ValidatingType = typeof(int);
            this.courseInput.Enter += new System.EventHandler(this.courseInput_Enter);
            this.courseInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.courseInput_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scrapeEnrollmentsBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yearInput);
            this.groupBox1.Controls.Add(this.semesterInput);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Semester Enrollments";
            // 
            // scrapeEnrollmentsBtn
            // 
            this.scrapeEnrollmentsBtn.Location = new System.Drawing.Point(19, 78);
            this.scrapeEnrollmentsBtn.Name = "scrapeEnrollmentsBtn";
            this.scrapeEnrollmentsBtn.Size = new System.Drawing.Size(310, 35);
            this.scrapeEnrollmentsBtn.TabIndex = 4;
            this.scrapeEnrollmentsBtn.Text = "Scrape Course Enrollments";
            this.scrapeEnrollmentsBtn.UseVisualStyleBackColor = true;
            this.scrapeEnrollmentsBtn.Click += new System.EventHandler(this.scrapeEnrollmentsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Semester";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(196, 41);
            this.yearInput.Mask = "0000";
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(133, 20);
            this.yearInput.TabIndex = 1;
            this.yearInput.ValidatingType = typeof(int);
            this.yearInput.Enter += new System.EventHandler(this.yearInput_Enter);
            // 
            // semesterInput
            // 
            this.semesterInput.FormattingEnabled = true;
            this.semesterInput.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.semesterInput.Location = new System.Drawing.Point(19, 41);
            this.semesterInput.Name = "semesterInput";
            this.semesterInput.Size = new System.Drawing.Size(171, 21);
            this.semesterInput.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.outputText);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 298);
            this.panel1.TabIndex = 2;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(3, 3);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(702, 259);
            this.outputText.TabIndex = 3;
            this.outputText.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(534, 269);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(171, 29);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save Session Data";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(714, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button scrapeDescriptionsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scrapeEnrollmentsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox yearInput;
        private System.Windows.Forms.ComboBox semesterInput;
        private System.Windows.Forms.Label courseListLabel;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.MaskedTextBox courseInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RichTextBox outputText;
    }
}

