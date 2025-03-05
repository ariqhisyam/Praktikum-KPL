using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300034
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int angka = 0;
        int hasil = 0;

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            hasil = hasil * 10+1;
            Label.Text = hasil.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            hasil = hasil * 10+2;
            Label.Text = hasil.ToString();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 3;
            Label.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            hasil = hasil * 10 + 4;
            Label.Text = hasil.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 7;
            Label.Text = hasil.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 6;
            Label.Text = hasil.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
            hasil = hasil * 10 + 5;
            Label.Text = hasil.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            hasil = hasil * 10 + 8;
            Label.Text = hasil.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 9;
            Label.Text = hasil.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hasil = hasil * 10 + 0;
            Label.Text = hasil.ToString();


        }

        private void button12_Click(object sender, EventArgs e)
        {

            angka = hasil;
            Label.Text = angka.ToString("+");
            hasil = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            angka = angka +hasil;
           Label.Text = angka.ToString();
            hasil = 0;

        }



        
    }
}
