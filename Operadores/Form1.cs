using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            //Variables
            double num1, num2;
            double sum, rest, mult, div, pow, root;
            //Data
            num1 =Convert.ToDouble(txt_number1.Text);
            num2 = Convert.ToDouble(txt_number2.Text);
            //Process
            sum = num1 + num2;
            rest = num1 - num2;
            mult=num1*num2;
            div = num1 / num2;
            pow = Math.Pow(num1, num2);
            root = Math.Pow(num1, (1 / num2));
            //Presentation
            txt_sum.Text = Convert.ToString(sum);
            txt_rest.Text = Convert.ToString(rest);
            txt_mult.Text = Convert.ToString(mult);
            txt_div.Text = Convert.ToString(div);
            txt_pow.Text = Convert.ToString(pow);
            txt_root.Text = Convert.ToString(root);
        }

        private void Btn_clean_Click(object sender, EventArgs e)
        {
            txt_number1.Clear();
            txt_number2.Clear();
            txt_sum.Clear();
            txt_rest.Clear();
            txt_mult.Clear();
            txt_div.Clear();
            txt_pow.Clear();
            txt_root.Clear();
        }
    }
}
