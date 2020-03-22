using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox1.Text += "+";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
                textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
                textBox1.Text += "2";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0.";
            }
            else
              textBox1.Text += ".";
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                string s1 = textBox1.Text;
                string operatii = "";
                
                char[] delimiterChars = { '+', '-', '/', '*',};
                for (int a=0; a<s1.Length; a++)
                {
                    if (s1[a] == '+' || s1[a] == '-' || s1[a] == '/' || s1[a] == '*')
                        operatii += s1[a];

                }
                string[] words = s1.Split(delimiterChars);
                double result = Convert.ToDouble(words[0]);
                for (int i = 1; i < words.Length; i++)
                {
                        if (operatii[i-1] == '+')
                        {
                            result += Convert.ToDouble(words[i]);
                        }
                        if (operatii[i - 1] == '-')
                        {
                            result -= Convert.ToDouble(words[i]);
                        }
                        if (operatii[i - 1] == '/')
                        {
                            result /= Convert.ToDouble(words[i]);
                        }
                        if (operatii[i - 1] == '*')
                        {
                            result *= Convert.ToDouble(words[i]);
                        }
                    
                    
                }
                textBox1.Text = result.ToString();
                Console.WriteLine(result);

            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9+-/*.]"))
            {
                MessageBox.Show("Ai voie doar numere sa introduci!");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

            try
            {
                string ceva = textBox1.Text.ToString();
                var result = ceva.Substring(ceva.Length - 2);
                Console.WriteLine(result);
                if (result == "++" || result == "--" || result == "**" || result == "/" || result == "+-" || result == "+*" || result == "+/")
                {
                       textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }


            }
            catch
            {
                Console.WriteLine("Eroare");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
                textBox1.Text += "0"; 
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
                textBox1.Text += "9";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
                textBox1.Text += "8";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
                textBox1.Text += "7";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
                textBox1.Text += "6";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
                textBox1.Text += "5";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
                textBox1.Text += "4";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
                textBox1.Text += "3";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
    }
}
