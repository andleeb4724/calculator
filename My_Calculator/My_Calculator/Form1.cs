using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace My_Calculator
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        string operationperformed = "";
        string a = "0";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "0") || (a == "0"))
                textBox1.Clear();
            Button buttonclick = (Button)sender;
           
            textBox1.Text = textBox1.Text + buttonclick.Text;
           
            a = "1";
        }


        private void operator_click(object sender, EventArgs e)
        {
           
            Button buttonopp = (Button)sender;
            operationperformed = buttonopp.Text;
            resultvalue = double.Parse(textBox1.Text);
            a="1";
            labelCurrentOperation.Text = resultvalue + " " + operationperformed;
            if (textBox1.Text != "")
            {
                textBox1.Text = "";
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultvalue = 0;
        }


        private void button18_Click(object sender, EventArgs e)
        {
            operationperformed = ".";
            resultvalue = Double.Parse(textBox1.Text);
           a="1";
           labelCurrentOperation.Text = resultvalue + " " + operationperformed;
        }



        private void button16_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textBox1.Text = (resultvalue + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (resultvalue - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (resultvalue * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (resultvalue / Double.Parse(textBox1.Text)).ToString();
                    break;

                default:
                    break;
            }
       }

 
    }
}