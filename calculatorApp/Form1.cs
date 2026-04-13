using System;
using System.Data;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        string strAns = "0";

        private bool isAfterEqual = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form1が呼び出されたときに実行される
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            textFormula.Text = strAns;
            textAns.Text = strAns;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TextFormula("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TextFormula("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TextFormula("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TextFormula("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TextFormula("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TextFormula("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TextFormula("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TextFormula("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TextFormula("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TextFormula("0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            strAns = "0";
            textFormula.Text = strAns;
            textAns.Text = strAns;
        }

        private void TextFormula(string num)
        {
            if (textFormula.Text == "0")
            {
                strAns = num;
                textFormula.Text = num;
            }
            else
            {
                strAns = textFormula.Text + num;
                textFormula.Text = strAns;
            }
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            OP("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OP("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OP("×");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            OP("÷");
        }

        private void OP(string op)
        {
            if (isAfterEqual)
            {
                textFormula.Text = strAns + op;
                isAfterEqual = false;
            }
            else
            {
                textFormula.Text += op;
            }

            strAns = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string formula = textFormula.Text.Replace("×", "*").Replace("÷", "/");
                //演算子の優先順位などを考慮して文字列を動的に計算する
                //文字列で表現された数式や集計式を評価し、その結果を返す機能
                var result = new DataTable().Compute(formula, null);
                textAns.Text = result.ToString();
                strAns = result.ToString();
                isAfterEqual = true;
            }
            catch
            {
                textAns.Text = "エラー";
                strAns = "0";
                isAfterEqual = false;
            }
        }
    }
}
