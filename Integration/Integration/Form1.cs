using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = Integrator.Rectangle(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();
            //textBox5.Text = Integrator.Tropez(textBox1.Text,Double.Parse(textBox2.Text),Double.Parse(textBox3.Text),Convert.ToInt32(textBox4.Text)).ToString();
            //textBox6.Text = Integrator.Rectangle(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();
            textBox6.Text = "0";
        }
    }
}
