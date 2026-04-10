using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        string strAns = "0";

        public Form1()
        {
            InitializeComponent();

            textAns.Text = strAns;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //現在のテキストボックスに連結された文字列になる
            TextAns("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TextAns("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TextAns("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TextAns("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TextAns("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TextAns("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TextAns("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TextAns("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TextAns("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TextAns("0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textAns.Clear();
            textAns.Text = "0";
        }

        private void TextAns(string num)
        {
            if(strAns != "0")
            {
               strAns = textAns.Text + num;
            }
            else
            {
                strAns = num;
            }


            textAns.Text = strAns;
        }
    }
}
