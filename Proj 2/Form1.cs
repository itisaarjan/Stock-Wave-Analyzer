

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project_2
{
    /// <summary>
    /// The main form that loads stock data and initiates chart display.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor that initializes Form1 with default settings.
        /// </summary>
        public Form1()
        {
            InitializeComponent(); // Initializes form controls from designer
            dateTimePicker_endDate.Value = DateTime.Now; // Sets default end date to today
            dateTimePicker_startDate.Value = DateTime.Now.AddMonths(-1); // Sets default start date to 1 month ago
        }

        /// <summary>
        /// Handles the click event for the load stock data button, opening a file dialog and creating chart forms.
        /// </summary>
        /// <param name="sender">The object that triggered the event (button).</param>
        /// <param name="sender">The event arguments (unused here).</param>
        private void button_loadStockData_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog_load.ShowDialog(); // Opens file dialog for user to select CSV files
            if (result == DialogResult.OK) // Checks if user clicked OK
            {
                foreach (string file in openFileDialog_load.FileNames) // Loops through each selected file
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(file); // Reads all lines from the CSV file
                        if (lines.Length <= 1) // Checks if file is empty or only has a header
                        {
                            MessageBox.Show($"File {Path.GetFileName(file)} is empty or only a header."); // Warns user
                            continue; // Skips to next file
                        }

                        List<CandleStick> candlesticks = new List<CandleStick>(); // Creates list to store candlestick data
                        for (int i = 1; i < lines.Length; i++) // Loops through lines, skipping header
                        {
                            try
                            {
                                var cs = new CandleStick(lines[i]); // Parses CSV line into a CandleStick object
                                candlesticks.Add(cs); // Adds parsed candlestick to the list
                            }
                            catch (FormatException ex) // Catches parsing errors for individual lines
                            {
                                MessageBox.Show($"Parsing issue on line {i + 1}:\n{ex.Message}"); // Shows error message
                                continue; // Skips invalid line
                            }
                        }

                        candlesticks = candlesticks.OrderBy(cs => cs.Date).ToList(); // Sorts candlesticks by date (oldest first)
                        if (candlesticks.Count == 0) // Checks if no valid data was parsed
                        {
                            MessageBox.Show($"No valid data in {Path.GetFileName(file)}."); // Warns user
                            continue; // Skips to next file
                        }

                        // Creates and shows a new chart form with the file, candlesticks, and date range
                        ChartDisplayForm cdf = new ChartDisplayForm(
                            file,
                            candlesticks,
                            dateTimePicker_startDate,
                            dateTimePicker_endDate
                        );
                        cdf.Show(); // Displays the chart form
                    }
                    catch (Exception ex) // Catches any other file-loading errors
                    {
                        MessageBox.Show($"File load failed: {ex.Message}"); // Shows error message
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for when the file dialog confirms selection (not used).
        /// </summary>
        /// <param name="sender">The object that triggered the event (dialog).</param>
        /// <param name="e">The cancel event arguments (unused here).</param>
        private void openFileDialog_load_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Stub: No action needed
        }

        /// <summary>
        /// Event handler for clicking the start date label (not used).
        /// </summary>
        /// <param name="sender">The object that triggered the event (label).</param>
        /// <param name="e">The event arguments (unused here).</param>
        private void label_startDate_Click(object sender, EventArgs e)
        {
            // Stub: No action needed
        }

        /// <summary>
        /// Event handler for when the form loads (not used).
        /// </summary>
        /// <param name="sender">The object that triggered the event (form).</param>
        /// <param name="e">The event arguments (unused here).</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set start and end dates to February 2021
            dateTimePicker_startDate.Value = new DateTime(2021, 2, 1);
            dateTimePicker_endDate.Value = new DateTime(2021, 2, 28);

            string defaultFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ABBV-Day.csv");

            if (!File.Exists(defaultFile))
            {
                MessageBox.Show("Default file ABBV.csv not found in application directory.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(defaultFile);
                if (lines.Length <= 1)
                {
                    MessageBox.Show("ABBV.csv is empty or only contains a header.");
                    return;
                }

                List<CandleStick> candlesticks = new List<CandleStick>();
                for (int i = 1; i < lines.Length; i++)
                {
                    try
                    {
                        var cs = new CandleStick(lines[i]);
                        candlesticks.Add(cs);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"Parsing issue on line {i + 1}:\n{ex.Message}");
                        continue;
                    }
                }

                candlesticks = candlesticks.OrderBy(cs => cs.Date).ToList();
                if (candlesticks.Count == 0)
                {
                    MessageBox.Show("No valid data in ABBV.csv.");
                    return;
                }

                ChartDisplayForm cdf = new ChartDisplayForm(
                    defaultFile,
                    candlesticks,
                    dateTimePicker_startDate,
                    dateTimePicker_endDate
                );
                cdf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load ABBV.csv: {ex.Message}");
            }
        }


        /// <summary>
        /// Event handler for when the end date picker value changes (not used).
        /// </summary>
        /// <param name="sender">The object that triggered the event (picker).</param>
        /// <param name="e">The event arguments (unused here).</param>
        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            // Stub: No action needed
        }
    }
}