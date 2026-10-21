using Backend;

namespace Frontend.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txrDisplay.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txrDisplay.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "(";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (txrDisplay.TextLength > 0)
            {
                txrDisplay.Text = txrDisplay.Text[..^1];
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += ")";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "(";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txrDisplay.Text))
            {
                return;
            }

            try
            {
                txrDisplay.Text = ExpressionEvaluator.Evalute(txrDisplay.Text).ToString();
            }
            catch (Exception)
            {
                txrDisplay.Text = "Error";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "8";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "5";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "2";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "-";
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "(";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txrDisplay.Text += "^";
        }
    }
}
