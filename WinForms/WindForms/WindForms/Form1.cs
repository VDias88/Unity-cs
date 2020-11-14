using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ola");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            Form2 f1 = new Form2(txt);
            f1.Show();
        }
    }
}
