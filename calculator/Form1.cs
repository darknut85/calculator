using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Settings settings = new Settings();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////
        // labels

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void outcoming_Click(object sender, EventArgs e)
        {

        }

        private void doit_Click(object sender, EventArgs e)
        {

        }
        private void calculate_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////
        // numbers

        private void button1_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 1;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 1;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 2;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 2;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 3;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 3;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 4;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 4;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 5;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 5;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 6;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 6;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 7;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 7;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 8;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 8;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 9;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 9;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            if (first_done != 1)
            {
                input1 = 0;
                label1.Text += input1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                input2 = 0;
                label2.Text += input2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        ///////////////////////////////////////////////////////
        // math

        private void plus_Click(object sender, EventArgs e)
        {
            string calculation = settings.Calculation;
            calculation = "+";
            calculate.Text = calculation;
            settings.Calculation = calculation;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            string calculation = settings.Calculation;
            calculation = "-";
            calculate.Text = calculation;
            settings.Calculation = calculation;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            string calculation = settings.Calculation;
            calculation = "/";
            calculate.Text = calculation;
            settings.Calculation = calculation;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            string calculation = settings.Calculation;
            calculation = "*";
            calculate.Text = calculation;
            settings.Calculation = calculation;
        }
        private void percent_Click(object sender, EventArgs e)
        {
            string calculation = settings.Calculation;
            calculation = "%";
            calculate.Text = calculation;
            settings.Calculation = calculation;
        }

        private void percentage2_Click(object sender, EventArgs e)
        {
            string calculation = settings.Calculation;
            calculation = "!%";
            calculate.Text = calculation;
            settings.Calculation = calculation;
        }

        ///////////////////////////////////////////////////////
        // outcome/dot

        private void equal_Click(object sender, EventArgs e)
        {
            int storedDone = settings.StoredDone;
            float lastAnswer1 = settings.LastAnswer1;
            float lastAnswer2 = settings.LastAnswer2;
            float lastAnswer3 = settings.LastAnswer3;
            float lastAnswer4 = settings.LastAnswer4;
            float input1 = settings.Input1;
            float input2 = settings.Input2;
            string calculation = settings.Calculation;
            float outcome = settings.Outcome;
            if (calculation == "+")
            {
                outcome = input1 + input2;
            }
            if (calculation == "-")
            {
                outcome = input1 - input2;
            }
            if (calculation == "/")
            {
                outcome = input1 / input2;
            }
            if (calculation == "*")
            {
                outcome = input1 * input2;
            }
            if (calculation == "%")
            {
                outcome = (input1 * input2)/(100);
            }
            if (calculation == "!%")
            {
                outcome = (input1 / input2) * (100);
            }
            outcoming.Text = outcome.ToString();
            if (storedDone == 0)
            {
                storedDone = 1;
                Stored1.Text = outcome.ToString();
                settings.StoredDone = storedDone;
                settings.LastAnswer1 = outcome;
            }
            else if (storedDone == 1)
            {
                storedDone = 2;
                Stored2.Text = outcome.ToString();
                settings.StoredDone = storedDone;
                settings.LastAnswer2 = outcome;
            }
            else if (storedDone == 2)
            {
                storedDone = 3;
                Stored3.Text = outcome.ToString();
                settings.StoredDone = storedDone;
                settings.LastAnswer3 = outcome;
            }
            else if (storedDone == 3)
            {
                storedDone = 0;
                Stored4.Text = outcome.ToString();
                settings.StoredDone = storedDone;
                settings.LastAnswer4 = outcome;
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            string dot = settings.Dot;
            dot = ",";
            if (first_done != 1)
            {
                label1.Text += dot.ToString();
            }
            else
            {
                label2.Text += dot.ToString();
            }
        }

        ///////////////////////////////////////////////////////
        // which number to fill

        private void first_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            first_done = 0;
            settings.FirstDone = first_done;
        }

        private void second_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            first_done = 1;
            settings.FirstDone = first_done;
        }

        ////////////////////////////////////////////////////////////
        // reset/delete

        private void Delete_Click(object sender, EventArgs e)
        {
            int first_done = settings.FirstDone;
            if (first_done != 1)
            {
                label1.Text = "";
                float one = 0;
                settings.Input1 = one;
            }
            else
            {
                label2.Text = "";
                float two = 0;
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            outcoming.Text = "";
            calculate.Text = "...";
            settings.Input1 = 0;
            settings.Input2 = 0;
            settings.Outcome = 0;
        }

        ////////////////////////////////////////////////////////////
        // memory buttons

        private void answer1_Click(object sender, EventArgs e)
        {
            float lastAnswer1 = settings.LastAnswer1;
            int first_done = settings.FirstDone;
            if (first_done != 1)
            {
                label1.Text = lastAnswer1.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                label2.Text = lastAnswer1.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            float lastAnswer2 = settings.LastAnswer2;
            int first_done = settings.FirstDone;
            if (first_done != 1)
            {
                label1.Text = lastAnswer2.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                label2.Text = lastAnswer2.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            float lastAnswer3 = settings.LastAnswer3;
            int first_done = settings.FirstDone;
            if (first_done != 1)
            {
                label1.Text = lastAnswer3.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                label2.Text = lastAnswer3.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            float lastAnswer4 = settings.LastAnswer4;
            int first_done = settings.FirstDone;
            if (first_done != 1)
            {
                label1.Text = lastAnswer4.ToString();
                float one = float.Parse(label1.Text);
                settings.Input1 = one;
            }
            else
            {
                label2.Text = lastAnswer4.ToString();
                float two = float.Parse(label2.Text);
                settings.Input2 = two;
            }
            settings.FirstDone = first_done;
        }

        ////////////////////////////////////////////////////////////
        // memory labels

        private void Stored1_Click(object sender, EventArgs e)
        {

        }

        private void Stored2_Click(object sender, EventArgs e)
        {

        }

        private void Stored3_Click(object sender, EventArgs e)
        {

        }

        private void Stored4_Click(object sender, EventArgs e)
        {

        }


        //euro's
        //better layout
    }
}
