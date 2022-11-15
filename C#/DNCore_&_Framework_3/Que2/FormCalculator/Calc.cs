namespace FormCalculator
{
    using System.Windows.Forms;
    using System.Text;
    using System.ComponentModel;
    using System.Threading.Tasks;
    using System.Data;
    using System;
    using System.Drawing;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class Calc : Form
    {
        string first = "";
        string second = "";
        double result = 0.0;
        char function;
        string userInput = "";
        public Calc()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "1";
            textBox.Text += userInput;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "2";
            textBox.Text += userInput;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "3";
            textBox.Text += userInput;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "4";
            textBox.Text += userInput;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "5";
            textBox.Text += userInput;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "6";
            textBox.Text += userInput;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "7";
            textBox.Text += userInput;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "8";
            textBox.Text += userInput;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "9";
            textBox.Text += userInput;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += "0";
            textBox.Text += userInput;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            userInput += ".";
            textBox.Text += userInput;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            second= userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if(function == '*')
            {
                result = firstNum * secondNum;
                textBox.Text  = result.ToString();
            }
            else if(function == '+')
            {
                result = firstNum + secondNum;
                textBox.Text = result.ToString();
            }
            else if(function == '-') 
            {
                result = firstNum - secondNum;
                textBox.Text = result.ToString();
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            result = 0.0;
            userInput = "";
            textBox.Text = "0";
        }
    }
}