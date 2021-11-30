﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        static string filePathRecords = @"C:\Users\franc\source\repos\Assign#6ContactTracer\ContactTracingApp\ContactTracingApp\Properties\Contact-Tracing-Records";
        static string[] files = Directory.GetFiles(filePathRecords);

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                filename = filename.Replace(".txt", "");
                listBox.Items.Add(filename);
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\franc\source\repos\Assign#6ContactTracer\ContactTracingApp\ContactTracingApp\Properties\Contact-Tracing-Records\" + listBox.Text + ".txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            MessageBox.Show(ListToString(lines), listBox.Text);
        }

        private string ListToString(List<string> lines)
        {
            string x = "";

            foreach (string line in lines)
            {
                x = x + line + "\n";
            }

            return x;
        }
    }
}
