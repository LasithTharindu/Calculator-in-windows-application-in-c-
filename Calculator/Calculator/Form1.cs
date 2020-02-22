using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        string operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKevin;
        char iOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 256;
            txtDisplay.Width = 214;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 497;
            txtDisplay.Width = 455;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 256;
            txtDisplay.Width = 214;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    //Celsius to Fahrenheit
                    iCelsius = float.Parse(lblConvert.Text);
                    txtConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());

                    break;
                case 'F':
                    //Fahrenheit to Celsius
                    iFahrenheit = float.Parse(lblConvert.Text);
                    txtConvert.Text = ((((iFahrenheit-32) * 5)/9).ToString());
                    break;
                case 'K':
                    //Convert to Kevin
                    iKevin = float.Parse(lblConvert.Text);
                    txtConvert.Text = (((((9 * iKevin) / 5) + 32)+273.15).ToString());
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 830;
            txtDisplay.Width = 455;
            lblConvert.Focus();

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;

            groupBox1.Location = new Point(480, 19);
            groupBox1.Width = 321;
            groupBox1.Height = 271;

        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = /*1386*/830;
            txtDisplay.Width = 455;
            txtConvert.Focus();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;

            groupBox4.Location = new Point(480, 19);
            groupBox4.Width = 321;
            groupBox4.Height = 271;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 830;
            txtDisplay.Width = 455;
            txtMultiply.Focus();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;

            groupBox3.Location =new Point (480, 19);
            groupBox3.Width = 321;
            groupBox3.Height = 321;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false; 
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";

        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + "" + operation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (results + double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (results - double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (results * double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (results / double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Mod":
                    txtDisplay.Text = (results % double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Exp":
                    double i = double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);

        }

        private void button24_Click(object sender, EventArgs e)
        {
            double qSinh = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = System.Convert.ToString(qSinh);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            double qSin = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
            qSin = Math.Sin(qSin);
            txtDisplay.Text = System.Convert.ToString(qSin);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double qcosh = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            txtDisplay.Text = System.Convert.ToString(qcosh);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double qcos = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            qcos = Math.Cos(qcos);
            txtDisplay.Text = System.Convert.ToString(qcos);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double qtanh = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            qtanh = Math.Tanh(qtanh);
            txtDisplay.Text = System.Convert.ToString(qtanh);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double qtan = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            qtan = Math.Tan(qtan);
            txtDisplay.Text = System.Convert.ToString(qtan);
        }

        private void button30_Click(object sender, EventArgs e)
        {
             int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button21_Click(object sender, EventArgs e)
        {

            double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void button40_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            rbCelToFah.Checked = false;
            rbFahToCel.Checked = false;
            rbKevin.Checked = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtMultiply.Text);
            for (int i = 1; i < 13 ; i ++)
            {
                lsMultiply.Items.Add(i + "x" + a + "=" + a * i);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestM_Click(object sender, EventArgs e)
        {
            lsMultiply.Items.Clear();
            txtMultiply.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length>0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);

            }
            if (txtDisplay.Text=="")
            {
                txtDisplay.Text = "0";
            }
        }

        private void bntConvertA_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (comboBox1.SelectedItem=="Rupees"&& comboBox2.SelectedItem=="Dollar")
            {
                int conver = a / 155;
                display_txt.Text = "Converted Amount : $ "+conver;
            }
            if (comboBox1.SelectedItem == "Rupees" && comboBox2.SelectedItem == "Euro")
            {
                int conver = a / 115;
                display_txt.Text = "Converted Amount : Euro " + conver;
            }
        }

        private void txtConvert_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }
    }
}