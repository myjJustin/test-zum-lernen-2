using System;
using System.Data;
using System.Windows.Forms;

namespace test_zum_lernen_2
{
    public partial class Form1 : Form
    {
        double ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable data = new DataTable();

            try
            {


                ans = Convert.ToDouble(data.Compute(textBox1.Text.Replace("ans", ans + ""), "").ToString());
            }
            catch (Exception f)
            {
                textBox2.Text = f.Message;
                return;
            }
            textBox2.Text = textBox1.Text + "=" + ans;
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            string kek = textBox1.Text.Replace("ans", ans + "");
            string[] variable = kek.Split('+', '-', '*', '/');
            double[] zahlen = new double[2];
            zahlen[0] = Convert.ToDouble(variable[0]);
            zahlen[1] = Convert.ToDouble(variable[1]);
            if (textBox1.Text.Contains("+"))
            {
                ans = zahlen[0] + zahlen[1];
            }
            else if (textBox1.Text.Contains("-"))
            {
                ans = zahlen[0] - zahlen[1];
            }
            else if (textBox1.Text.Contains("*"))
            {
                ans = zahlen[0] * zahlen[1];
            }
            else if (textBox1.Text.Contains("/"))
            {
                ans = zahlen[0] / zahlen[1];
            }
            textBox2.Text = textBox1.Text + "=" + ans;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            double zahl = double.Parse(textBox1.Text);
            ans = Math.Sqrt(zahl);
            textBox2.Text = "√"+textBox1.Text + "=" + ans;
        }
    }
}
