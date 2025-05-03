/*
Name: Arjan Subedi
Unumber: U81857374
*/
using System;
using System.Windows.Forms;

namespace Project_2
{
    /// <summary>
    /// Provides the entry point for the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Main entry method, invoked when the application starts.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Apply Windows visual styles to give controls a modern appearance.
            Application.EnableVisualStyles();

            // Ensure text rendering is compatible with these visual styles.
            Application.SetCompatibleTextRenderingDefault(false);

            // Launch the application by displaying Form1.
            Application.Run(new Form1());
        }
    }
}
