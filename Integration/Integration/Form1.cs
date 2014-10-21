using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration
{
    public partial class Form1 : Form
    {
        delegate double Rectangle(string Func, double a, double b, int n);
        delegate double Tropez(string Func, double a, double b, int n);
        delegate double Simp(string Func, double a, double b, int n);
        Rectangle download1 = new Integrator().Rectangle;
        Tropez download2 = new Integrator().Tropez;
        Simp download3 = new Integrator().Simp;



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

            IAsyncResult cookie1 = download1.BeginInvoke(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text), null, null);
            IAsyncResult cookie2 = download2.BeginInvoke(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text), null, null);
            IAsyncResult cookie3 = download3.BeginInvoke(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text), null, null);
            textBox5.Text = download1.EndInvoke(cookie1).ToString();
            textBox6.Text = download2.EndInvoke(cookie2).ToString();
            textBox7.Text = download3.EndInvoke(cookie3).ToString();
            // textBox5.Text = Integrator.Tropez(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();
            //textBox6.Text = Integrator.Rectangle(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();
            // textBox7.Text = Integrator.Simp(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
