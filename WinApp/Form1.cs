using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.TextChanged += textBox2_TextChanged;

            // задаем обработчик события
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;

            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "Кузнецов",
                "Иванов",
                "Петров",
                "Кустов"
            };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://metanit.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("🔥人間盡逍遙🔥");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
        }
    }
}
