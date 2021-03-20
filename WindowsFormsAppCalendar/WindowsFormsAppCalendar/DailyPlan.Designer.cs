
namespace WindowsFormsAppCalendar
{
    partial class DailyPlan
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
            this.panelJob = new System.Windows.Forms.Panel();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.addWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPreviousday = new System.Windows.Forms.Button();
            this.buttonNextday = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelJob);
            this.panel1.Location = new System.Drawing.Point(6, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 516);
            this.panel1.TabIndex = 0;
            // 
            // panelJob
            // 
            this.panelJob.Location = new System.Drawing.Point(3, 53);
            this.panelJob.Name = "panelJob";
            this.panelJob.Size = new System.Drawing.Size(809, 460);
            this.panelJob.TabIndex = 0;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(284, 9);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerDate.TabIndex = 1;
            this.dateTimePickerDate.Value = new System.DateTime(2021, 2, 7, 0, 0, 0, 0);
            // 
            // addWorkToolStripMenuItem
            // 
            this.addWorkToolStripMenuItem.Name = "addWorkToolStripMenuItem";
            this.addWorkToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.addWorkToolStripMenuItem.Text = "Add Work";
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.todayToolStripMenuItem.Text = "Today";
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWorkToolStripMenuItem,
            this.todayToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(833, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonNextday);
            this.panel3.Controls.Add(this.buttonPreviousday);
            this.panel3.Controls.Add(this.dateTimePickerDate);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 44);
            this.panel3.TabIndex = 1;
            // 
            // buttonPreviousday
            // 
            this.buttonPreviousday.Location = new System.Drawing.Point(12, 3);
            this.buttonPreviousday.Name = "buttonPreviousday";
            this.buttonPreviousday.Size = new System.Drawing.Size(119, 35);
            this.buttonPreviousday.TabIndex = 2;
            this.buttonPreviousday.Text = "Previous day";
            this.buttonPreviousday.UseVisualStyleBackColor = true;
            // 
            // buttonNextday
            // 
            this.buttonNextday.Location = new System.Drawing.Point(688, 4);
            this.buttonNextday.Name = "buttonNextday";
            this.buttonNextday.Size = new System.Drawing.Size(109, 36);
            this.buttonNextday.TabIndex = 2;
            this.buttonNextday.Text = "Next Day";
            this.buttonNextday.UseVisualStyleBackColor = true;
            this.buttonNextday.Click += new System.EventHandler(this.button2_Click);
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "DailyPlan";
            this.Text = "DailyPlan";
            this.Load += new System.EventHandler(this.DailyPlan_Load);
            this.panel1.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Panel panelJob;
        private System.Windows.Forms.ToolStripMenuItem addWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonNextday;
        private System.Windows.Forms.Button buttonPreviousday;
    }
}