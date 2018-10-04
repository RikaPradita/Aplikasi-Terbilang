using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace AppTerbilang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 trb = new Class1();

            int nominal = int.Parse(textBox1.Text);
            textBox2.Text = Convert.ToString(trb.TerbilangIndonesia(nominal));
        }
    }
}