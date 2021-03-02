using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharacters() 
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("D:\\C#\\Stage 3Handsons\\3 Thread Handson\\1\\AsyncAwait using WinForms\\text.txt")) 
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async  void btnProcessFile(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            LblCount.Text = "Processing File. Please Wait...";
            int count = await task;
            LblCount.Text = count.ToString() + " characters in file.";
        }
    }
}
