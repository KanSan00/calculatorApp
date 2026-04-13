using System;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        string strAns = "0";
        int num1 = 0;
        int num2 = 0;

        public enum Operator
        {
            None,
            Plus,
            Minus,
            Multiply,
            Division,
        }

        Operator op = Operator.None;

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

        /// <summary>
        /// 1 を押す 👉 strAns は "1"、画面の式は "1"
        /// + を押す 👉 画面の式は "1+" になるが、strAns は一旦 "0" にリセットされる（OPメソッド内の処理）
        /// 1 を押す 👉 strAns は純粋な "1" になり、画面の式は "1+1" になる
        /// = を押す 👉 num2 = int.Parse("1") が安全に実行され、1 + 1 = 2 が計算される！
        /// </summary>
        /// <param name="num"></param>
        private void TextFormula(string num)
        {
            if (strAns != "0")
            {
                strAns = textFormula.Text + num;
            }
            else
            {
                strAns = strAns + num;
            }

            //初期状態の "0" なら置き換え、それ以外なら後ろにくっつける
            if (textFormula.Text == "0")
            {
                textFormula.Text = num;
            }
            else
            {
                textFormula.Text = textFormula.Text + num;
            }
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            OP(Operator.Plus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OP(Operator.Minus);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OP(Operator.Multiply);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            OP(Operator.Division);
        }

        private void OP(Operator op)
        {
            this.op = op;
            switch (this.op)
            {
                case Operator.Plus:
                    textFormula.Text = textFormula.Text + "+";
                    break;
                case Operator.Minus:
                    textFormula.Text = textFormula.Text + "-";
                    break;
                case Operator.Multiply:
                    textFormula.Text = textFormula.Text + "×";
                    break;
                case Operator.Division:
                    textFormula.Text = textFormula.Text + "÷";
                    break;
            }
            num1 = int.Parse(strAns);
            strAns = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(strAns);
            double ans = 0;
            switch (this.op)
            {
                case Operator.Plus:
                    ans = (num1 + num2);
                    break; 
                case Operator.Minus:
                    ans = (num1 - num2);
                    break;
                case Operator.Multiply:
                    ans = (num1 * num2);
                    break;
                case Operator.Division:
                    ans = (double)num1 / num2;
                    break;
            }

            textAns.Text = ans.ToString();
            strAns = ans.ToString();
        }
    }
}
