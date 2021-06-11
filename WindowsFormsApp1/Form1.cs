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
            this.MinimumSize = new Size(747, 408);
            checkBox1_checked();
        }
        public static string ASCII_in_6bit(string coded_number)
        {
            string decoding_number = "";
            byte[] ASCIIBytes = Encoding.ASCII.GetBytes(coded_number);
            foreach (var item in ASCIIBytes)
            {
                if (item <= 87 && item >= 48)
                {
                    decoding_number = String.Format("{0:d6}", Convert.ToInt32(Convert.ToString((item - 48), 2)));
                }
                else if (item <= 119 && item >= 96)
                {
                    decoding_number = String.Format("{0:d6}", Convert.ToInt32(Convert.ToString((item - 56), 2)));
                }
            }
            return decoding_number;
        }
        public static string _6bit_in_ASCII(string coded_number)
        {
            string decoding_number = "";
            int counter = 0;
            var result = 0u;
            for (var i = coded_number.Length - 1; i >= 0; i--)
            {
                if (coded_number[i] == '1')
                {
                    result += Convert.ToUInt32(Math.Pow(2, counter));
                }
                counter++;
            }
            if (result <= 39 && result >= 0)
            {
                result += 48;
            }
            else if (result <= 63 && result >= 40)
            {
                result += 56;
            }
            byte[] ASCIIBytes = new byte[] { Convert.ToByte(result) };
            decoding_number = Encoding.ASCII.GetString(ASCIIBytes);
            return decoding_number;
        }
        private void Clear_All_TextBox_Click(object sender, EventArgs e)
        {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
        }

        private void ASCII_in_bit_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                char[] charArray = textBox4.Text.ToCharArray();
                foreach (var item in charArray)
                {
                    textBox3.Text += ASCII_in_6bit(Convert.ToString(item)) + " ";
                }
            }
            else
            {
                textBox3.Text = ASCII_in_6bit(textBox4.Text);    
            }
        }

        private void bit_in_ASCII_Click(object sender, EventArgs e)
        {
            double num = 0.0;
            string symbol_6 = textBox1.Text;

            if (double.TryParse(textBox1.Text, out num))
            {
                if (checkBox1.Checked == true)
                {
                    string a = symbol_6;
                    for (int i = 0; i < textBox1.Text.Length; i += 6)
                    {
                        try
                        {
                        int cointer = (((a.Length / 6) - 1) * 6) > 0 ? (((a.Length / 6) - 1) * 6) : 6;
                        textBox2.Text += _6bit_in_ASCII(a.Substring(0, cointer));
                        a = a.Remove(0, cointer);
                        }
                        catch (Exception)
                        {
                            textBox2.Text = "ERROR";
                        }
                     }
                }
                else
                {
                    textBox2.Text = _6bit_in_ASCII(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = "Only numbers, please!";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_checked();
        }
        private void checkBox1_checked()
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "several symbols";
                textBox1.MaxLength = 32767;
                textBox4.MaxLength = 32767;
            }
            else
            {
                checkBox1.Text = "1 symbol";
                textBox1.MaxLength = 6;
                textBox4.MaxLength = 1;
            }
        }
    }
}
