
namespace WindowsFormsAppCalendar
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDownNotify = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.buttonToday = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSunday = new System.Windows.Forms.Button();
            this.buttonSaturday = new System.Windows.Forms.Button();
            this.buttonFriday = new System.Windows.Forms.Button();
            this.buttonThursday = new System.Windows.Forms.Button();
            this.buttonWednesday = new System.Windows.Forms.Button();
            this.buttonTuesday = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonMonday = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 442);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.buttonToday);
            this.panel3.Controls.Add(this.dateTimePickerDate);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 33);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.numericUpDownNotify);
            this.panel6.Controls.Add(this.checkBoxNotify);
            this.panel6.Location = new System.Drawing.Point(6, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 26);
            this.panel6.TabIndex = 2;
            // 
            // numericUpDownNotify
            // 
            this.numericUpDownNotify.Location = new System.Drawing.Point(75, 3);
            this.numericUpDownNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNotify.Name = "numericUpDownNotify";
            this.numericUpDownNotify.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownNotify.TabIndex = 1;
            this.numericUpDownNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Location = new System.Drawing.Point(3, 3);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(66, 21);
            this.checkBoxNotify.TabIndex = 0;
            this.checkBoxNotify.Text = "Notify";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // buttonToday
            // 
            this.buttonToday.Location = new System.Drawing.Point(559, 3);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(75, 25);
            this.buttonToday.TabIndex = 1;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            this.buttonToday.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonToday_MouseClick);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(279, 6);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(263, 22);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelMatrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 397);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelMatrix
            // 
            this.panelMatrix.Location = new System.Drawing.Point(70, 68);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Size = new System.Drawing.Size(743, 326);
            this.panelMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonNext);
            this.panel4.Controls.Add(this.buttonSunday);
            this.panel4.Controls.Add(this.buttonSaturday);
            this.panel4.Controls.Add(this.buttonFriday);
            this.panel4.Controls.Add(this.buttonThursday);
            this.panel4.Controls.Add(this.buttonWednesday);
            this.panel4.Controls.Add(this.buttonTuesday);
            this.panel4.Controls.Add(this.buttonLast);
            this.panel4.Controls.Add(this.buttonMonday);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(815, 59);
            this.panel4.TabIndex = 0;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(750, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 53);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Next Month";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonNext_MouseClick);
            // 
            // buttonSunday
            // 
            this.buttonSunday.Location = new System.Drawing.Point(662, 3);
            this.buttonSunday.Name = "buttonSunday";
            this.buttonSunday.Size = new System.Drawing.Size(82, 53);
            this.buttonSunday.TabIndex = 0;
            this.buttonSunday.Text = "Sunday";
            this.buttonSunday.UseVisualStyleBackColor = true;
            this.buttonSunday.Click += new System.EventHandler(this.buttonSunday_Click);
            // 
            // buttonSaturday
            // 
            this.buttonSaturday.Location = new System.Drawing.Point(567, 3);
            this.buttonSaturday.Name = "buttonSaturday";
            this.buttonSaturday.Size = new System.Drawing.Size(82, 53);
            this.buttonSaturday.TabIndex = 0;
            this.buttonSaturday.Text = "Saturday";
            this.buttonSaturday.UseVisualStyleBackColor = true;
            // 
            // buttonFriday
            // 
            this.buttonFriday.Location = new System.Drawing.Point(469, 3);
            this.buttonFriday.Name = "buttonFriday";
            this.buttonFriday.Size = new System.Drawing.Size(82, 53);
            this.buttonFriday.TabIndex = 0;
            this.buttonFriday.Text = "Friday";
            this.buttonFriday.UseVisualStyleBackColor = true;
            this.buttonFriday.Click += new System.EventHandler(this.buttonFriday_Click);
            // 
            // buttonThursday
            // 
            this.buttonThursday.Location = new System.Drawing.Point(368, 3);
            this.buttonThursday.Name = "buttonThursday";
            this.buttonThursday.Size = new System.Drawing.Size(82, 53);
            this.buttonThursday.TabIndex = 0;
            this.buttonThursday.Text = "Thursday";
            this.buttonThursday.UseVisualStyleBackColor = true;
            // 
            // buttonWednesday
            // 
            this.buttonWednesday.Location = new System.Drawing.Point(259, 3);
            this.buttonWednesday.Name = "buttonWednesday";
            this.buttonWednesday.Size = new System.Drawing.Size(96, 53);
            this.buttonWednesday.TabIndex = 0;
            this.buttonWednesday.Text = "Wednesday";
            this.buttonWednesday.UseVisualStyleBackColor = true;
            this.buttonWednesday.Click += new System.EventHandler(this.buttonWednesday_Click);
            // 
            // buttonTuesday
            // 
            this.buttonTuesday.Location = new System.Drawing.Point(171, 3);
            this.buttonTuesday.Name = "buttonTuesday";
            this.buttonTuesday.Size = new System.Drawing.Size(82, 53);
            this.buttonTuesday.TabIndex = 0;
            this.buttonTuesday.Text = "Tuesday";
            this.buttonTuesday.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(3, 3);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(60, 53);
            this.buttonLast.TabIndex = 0;
            this.buttonLast.Text = "Last Month";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.button1_Click);
            this.buttonLast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLast_MouseClick);
            // 
            // buttonMonday
            // 
            this.buttonMonday.Location = new System.Drawing.Point(73, 3);
            this.buttonMonday.Name = "buttonMonday";
            this.buttonMonday.Size = new System.Drawing.Size(82, 53);
            this.buttonMonday.TabIndex = 0;
            this.buttonMonday.Text = "Monday";
            this.buttonMonday.UseVisualStyleBackColor = true;
            this.buttonMonday.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 466);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calender";
     //       this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonSunday;
        private System.Windows.Forms.Button buttonSaturday;
        private System.Windows.Forms.Button buttonFriday;
        private System.Windows.Forms.Button buttonThursday;
        private System.Windows.Forms.Button buttonWednesday;
        private System.Windows.Forms.Button buttonTuesday;
        private System.Windows.Forms.Button buttonMonday;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numericUpDownNotify;
        private System.Windows.Forms.CheckBox checkBoxNotify;
    }
}

