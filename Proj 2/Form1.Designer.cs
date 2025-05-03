/*
Name: Arjan Subedi
Unumber: U81857374
*/
using System;
using System.Windows.Forms;

namespace Project_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by Form1.
        /// </summary>
        /// <param name="disposing">True to dispose managed resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) // Checks if disposing and components exist
            {
                components.Dispose(); // Disposes components
            }
            base.Dispose(disposing); // Calls base dispose method
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Initializes the form's components and layout.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_loadStockData = new System.Windows.Forms.Button(); // Button to load stock data
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker(); // Picker for end date
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker(); // Picker for start date
            this.label_startDate = new System.Windows.Forms.Label(); // Label for start date picker
            this.label_endDate = new System.Windows.Forms.Label(); // Label for end date picker
            this.openFileDialog_load = new System.Windows.Forms.OpenFileDialog(); // Dialog for file selection
            this.SuspendLayout(); // Suspends layout logic during initialization

            // button_loadStockData
            this.button_loadStockData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left))); // Anchors to bottom-left
            this.button_loadStockData.BackColor = System.Drawing.SystemColors.ActiveCaption; // Sets background color
            this.button_loadStockData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F); // Sets font
            this.button_loadStockData.Location = new System.Drawing.Point(211, 97); // Sets position
            this.button_loadStockData.Name = "button_loadStockData"; // Names the button
            this.button_loadStockData.Size = new System.Drawing.Size(226, 46); // Sets size
            this.button_loadStockData.TabIndex = 11; // Sets tab order
            this.button_loadStockData.Text = "Load CandleStick"; // Sets button text
            this.button_loadStockData.UseVisualStyleBackColor = false; // Disables default background style
            this.button_loadStockData.Click += new System.EventHandler(this.button_loadStockData_Click); // Binds click event

            // dateTimePicker_endDate
            this.dateTimePicker_endDate.Anchor = System.Windows.Forms.AnchorStyles.Right; // Anchors to right
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(211, 53); // Sets position
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate"; // Names the picker
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(254, 22); // Sets size
            this.dateTimePicker_endDate.TabIndex = 12; // Sets tab order
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged); // Binds value changed event

            // dateTimePicker_startDate
            this.dateTimePicker_startDate.Anchor = System.Windows.Forms.AnchorStyles.Left; // Anchors to left
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(211, 14); // Sets position
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate"; // Names the picker
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(252, 22); // Sets size
            this.dateTimePicker_startDate.TabIndex = 13; // Sets tab order

            // label_startDate
            this.label_startDate.Anchor = System.Windows.Forms.AnchorStyles.Left; // Anchors to left
            this.label_startDate.AutoSize = true; // Automatically sizes label
            this.label_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline); // Sets font with underline
            this.label_startDate.Location = new System.Drawing.Point(41, 14); // Sets position
            this.label_startDate.Name = "label_startDate"; // Names the label
            this.label_startDate.Size = new System.Drawing.Size(138, 20); // Sets size
            this.label_startDate.TabIndex = 14; // Sets tab order
            this.label_startDate.Text = "Select Start Date"; // Sets label text
            this.label_startDate.Click += new System.EventHandler(this.label_startDate_Click); // Binds click event

            // label_endDate
            this.label_endDate.Anchor = System.Windows.Forms.AnchorStyles.Right; // Anchors to right
            this.label_endDate.AutoSize = true; // Automatically sizes label
            this.label_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline); // Sets font with underline
            this.label_endDate.Location = new System.Drawing.Point(41, 55); // Sets position
            this.label_endDate.Name = "label_endDate"; // Names the label
            this.label_endDate.Size = new System.Drawing.Size(131, 20); // Sets size
            this.label_endDate.TabIndex = 15; // Sets tab order
            this.label_endDate.Text = "Select End Date"; // Sets label text

            // openFileDialog_load
            this.openFileDialog_load.FileName = "ABBV-Day"; // Sets default file name
            this.openFileDialog_load.Filter = "All Stock files|*.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly Stocks|*-Month.csv"; // Sets file filter
            this.openFileDialog_load.Multiselect = true; // Allows multiple file selection
            this.openFileDialog_load.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_load_FileOk); // Binds file OK event

            // Form1
            this.ClientSize = new System.Drawing.Size(591, 155); // Sets form size
            this.Controls.Add(this.label_endDate); // Adds end date label to form
            this.Controls.Add(this.label_startDate); // Adds start date label to form
            this.Controls.Add(this.dateTimePicker_startDate); // Adds start date picker to form
            this.Controls.Add(this.dateTimePicker_endDate); // Adds end date picker to form
            this.Controls.Add(this.button_loadStockData); // Adds load button to form
            this.Name = "Form1"; // Names the form
            this.Text = "Stock Data/Chart Analysis"; // Sets form title
            this.Load += new System.EventHandler(this.Form1_Load); // Binds load event
            this.ResumeLayout(false); // Resumes layout logic
            this.PerformLayout(); // Performs layout
        }

        #endregion

        private System.Windows.Forms.Button button_loadStockData;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog_load;
    }
}