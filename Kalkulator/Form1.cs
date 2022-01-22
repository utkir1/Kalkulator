using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        } 

        public double num1 = 0, num2=0;
        public int n1 = 0,n2 = 0;

        public bool isMod = false;
        public bool isPlus = false;
        public bool isDisposed = false;
        public bool isAccessible = false;
        public bool isDisposed1 = false;
        public bool isradioButton1 = false;
        public bool isradioButton2 = false;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6"; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
                richTextBox1.Text += "0";

          
          

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //string str = richTextBox1.Text;
            //int end = str[str.Length - 1];
            //if (end != '+' && end != '-' && end != '*' && end != '/')
            //    richTextBox1.Text += "*";
            isAccessible = true;
            isPlus = false;
           
            isDisposed1 = false;
            isDisposed = false;

            isMod = false;

            num1 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //string str = richTextBox1.Text;
            //double end = str[str.Length - 1];
            //if (end != '+' && end != '-' && end != '*' && end != '/')
            //    richTextBox1.Text += "/";
            isDisposed = true;
            isPlus = false;
            isAccessible = false;
            isDisposed1 = false;
           

            isMod = false;
            num1 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";





        }

        private void button16_Click(object sender, EventArgs e)
        {
            //string str = richTextBox1.Text;
            //int end = str[str.Length - 1];
            //if (end != '+' && end != '-' && end != '*' && end != '/')
            //    richTextBox1.Text += "+";
            isPlus = true;
            isAccessible = false;
            isDisposed1 = false;
            isDisposed = false;

            isMod = false;
            num1 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //string str = richTextBox1.Text;
            //int end = str[str.Length - 1];
            //if (end != '+' && end != '-' && end != '*' && end != '/')
            //    richTextBox1.Text += "-";
            isDisposed1 = true;
            isAccessible = false;
            isPlus = false;
            isDisposed = false;
            
            isMod = false;
            num1 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";

            if (richTextBox1.Text == "0") ;
            richTextBox1.Text = "0";
           
        }


        private void button12_Click(object sender, EventArgs e)
        {
            //  == BAROBAR ==

            if (isMod)
            {
                n2 = int.Parse(richTextBox1.Text);
                richTextBox1.Text = (n1 % n2).ToString();
            }
           if (isPlus)
            {
                num2 = double.Parse(richTextBox1.Text);
                richTextBox1.Text = (num1 + num2).ToString();
            }
           if (isDisposed)
            {
                num2 = double.Parse(richTextBox1.Text);
                richTextBox1.Text = (num1 / num2).ToString();

            }
           if (isAccessible)
            {
                num2 = double.Parse(richTextBox1.Text);
                richTextBox1.Text = (num1 * num2).ToString();
            }
           if (isDisposed1)
            {
                num2 = double.Parse(richTextBox1.Text);
                richTextBox1.Text = (num1 - num2).ToString();
            }
          


        }

        private void button17_Click(object sender, EventArgs e)
        {
           

            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            

        }

        private void button18_Click(object sender, EventArgs e)
        {
            // plyus minus

            double u = double.Parse(richTextBox1.Text);
          double a = (-1) * u;
            richTextBox1.Text = a.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {      
          // 0 BOSHQA SONGA O`ZGARISHI
            Button b = (Button)sender;
            if (richTextBox1.Text == "0")
                richTextBox1.Text = b.Text;
            else
                richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {    
            /* ILDIZ*/

            string str = richTextBox1.Text;
            double u = double.Parse(str);
            double a = Math.Sqrt( u);
            richTextBox1.Text = a.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {     /*  SINUS*/
            if(isradioButton1)
            {   
                double a = double.Parse(richTextBox1.Text);
                richTextBox1.Text = Math.Sin(a).ToString();
            }
            else if(isradioButton2)
            {
                double a = double.Parse(richTextBox1.Text);
                richTextBox1.Text = Math.Sin(Math.PI*( a/180)).ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           isradioButton1 = true;
            isradioButton2 = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isradioButton2 = true;
            isradioButton1 = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {       /*kosinus*/

            if (isradioButton1)
            {
                double a = double.Parse(richTextBox1.Text);
                richTextBox1.Text = Math.Cos(a).ToString();
            }
            else if (isradioButton2)
            {
                double a = double.Parse(richTextBox1.Text);
                richTextBox1.Text = Math.Cos(Math.PI * (a / 180)).ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (isradioButton1)
            {
                double a = double.Parse(richTextBox1.Text);
                richTextBox1.Text = Math.Tan(a).ToString();
            }
            else if (isradioButton2)
            {
                double a = double.Parse(richTextBox1.Text);
                richTextBox1.Text = Math.Tan(Math.PI * (a / 180)).ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (isradioButton1)
            {
                double a = double.Parse(richTextBox1.Text);
                richTextBox1.Text = (1/Math.Tan(a)).ToString();
            }
            else if (isradioButton2)
            {
                double a = double.Parse(richTextBox1.Text);
                richTextBox1.Text = (1/ Math.Tan(Math.PI * (a / 180))).ToString();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {       // QOLDIQLIM BO`LISH
            isMod = true;
            n1 = int.Parse(richTextBox1.Text);
            richTextBox1.Text = ""; 


        }
    }
}
