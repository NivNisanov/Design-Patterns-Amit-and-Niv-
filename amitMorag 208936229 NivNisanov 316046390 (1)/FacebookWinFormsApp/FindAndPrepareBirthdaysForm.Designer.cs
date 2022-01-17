
namespace BasicFacebookFeatures
{
    partial class FindAndPrepareBirthdaysForm
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
            this.listOfEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchEventsButton = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.coverPic = new System.Windows.Forms.PictureBox();
            this.generateCalendarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPic)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfEvents
            // 
            this.listOfEvents.FormattingEnabled = true;
            this.listOfEvents.ItemHeight = 16;
            this.listOfEvents.Location = new System.Drawing.Point(326, 231);
            this.listOfEvents.Name = "listOfEvents";
            this.listOfEvents.Size = new System.Drawing.Size(265, 84);
            this.listOfEvents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Birthdays";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(13, 231);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(242, 22);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(13, 288);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(242, 22);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date";
            // 
            // searchEventsButton
            // 
            this.searchEventsButton.Location = new System.Drawing.Point(85, 329);
            this.searchEventsButton.Name = "searchEventsButton";
            this.searchEventsButton.Size = new System.Drawing.Size(108, 42);
            this.searchEventsButton.TabIndex = 6;
            this.searchEventsButton.Text = "Search";
            this.searchEventsButton.UseVisualStyleBackColor = true;
            this.searchEventsButton.Click += new System.EventHandler(this.searchEventsButton_Click);
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(254, 108);
            this.profilePic.Name = "profilePic";
            this.profilePic.Padding = new System.Windows.Forms.Padding(5);
            this.profilePic.Size = new System.Drawing.Size(100, 100);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 7;
            this.profilePic.TabStop = false;
            // 
            // coverPic
            // 
            this.coverPic.Location = new System.Drawing.Point(13, 11);
            this.coverPic.Name = "coverPic";
            this.coverPic.Size = new System.Drawing.Size(578, 170);
            this.coverPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPic.TabIndex = 8;
            this.coverPic.TabStop = false;
            // 
            // generateCalendarButton
            // 
            this.generateCalendarButton.Enabled = false;
            this.generateCalendarButton.Location = new System.Drawing.Point(356, 329);
            this.generateCalendarButton.Name = "generateCalendarButton";
            this.generateCalendarButton.Size = new System.Drawing.Size(205, 42);
            this.generateCalendarButton.TabIndex = 9;
            this.generateCalendarButton.Text = "Generate a calendar with birthdays wishes";
            this.generateCalendarButton.UseVisualStyleBackColor = true;
            this.generateCalendarButton.Visible = false;
            this.generateCalendarButton.Click += new System.EventHandler(this.GenerateCalendarButton_Click);
            // 
            // FindAndPrepareBirthdaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 395);
            this.Controls.Add(this.generateCalendarButton);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.coverPic);
            this.Controls.Add(this.searchEventsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FindAndPrepareBirthdaysForm";
            this.Text = "Prepare Birthdays Form";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchEventsButton;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.PictureBox coverPic;
        private System.Windows.Forms.Button generateCalendarButton;
    }
}