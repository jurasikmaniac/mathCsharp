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
        delegate ResultAndError Rectangle(string Func, double a, double b, int n);
        delegate ResultAndError TropezRunge(string Func, double a, double b, int n);
        delegate ResultAndError Simp(string Func, double a, double b, int n);
        Rectangle download1 = new Integrator().RectangleRunge;
        TropezRunge download2 = new Integrator().TropezRunge;
        Simp download3 = new Integrator().SimpRunge;


        delegate ResultAndError Rectangle1(string Func, double a, double b, double epsilon);
        delegate ResultAndError TropezRunge1(string Func, double a, double b, double epsilon);
        delegate ResultAndError Simp1(string Func, double a, double b, double epsilon);
        Rectangle1 download11 = new Integrator().RectangleWithAnEpsilon;
        TropezRunge1 download21 = new Integrator().TropezWithAnEpsilon;
        Simp1 download31 = new Integrator().SimpWithAnEpsilon;


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
           
            ResultAndError er1 = download1.EndInvoke(cookie1);
            
            textBox6.Text = er1.result.ToString();
            textBox9.Text = er1.error.ToString();
            ResultAndError er2 = download2.EndInvoke(cookie2);
            textBox5.Text = er2.result.ToString();
            textBox8.Text = er2.error.ToString();

            

            ResultAndError er3 = download3.EndInvoke(cookie3); 
            textBox7.Text = er3.result.ToString();
            textBox10.Text = er3.error.ToString();



            // textBox5.Text = Integrator.Tropez(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();
            //textBox6.Text = Integrator.Rectangle(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();
            // textBox7.Text = Integrator.Simp(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            IAsyncResult cookie11 = download11.BeginInvoke(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Double.Parse(textBox11.Text), null, null);
            IAsyncResult cookie21 = download21.BeginInvoke(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Double.Parse(textBox11.Text), null, null);
            IAsyncResult cookie31 = download31.BeginInvoke(textBox1.Text, Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), Double.Parse(textBox11.Text), null, null);
            
            ResultAndError er1 = download11.EndInvoke(cookie11);
            textBox16.Text = er1.result.ToString();

            ResultAndError er2 = download21.EndInvoke(cookie21);
            textBox17.Text = er2.result.ToString();

            ResultAndError er3 = download31.EndInvoke(cookie31);
            textBox15.Text = er3.result.ToString();
            
        }
    }
}
