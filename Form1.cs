using System;
using System.Windows.Forms;

namespace assignment2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Exit button
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label13.Text = "";
        }

        // calculate revenue button
        private void button1_Click(object sender, EventArgs e)
        {
            decimal result;
            // costs
            decimal classACost = decimal.Parse(label10.Text.Substring(0, 5));
            decimal classBCost = decimal.Parse(label11.Text.Substring(0, 5));
            decimal classCCost = decimal.Parse(label12.Text.Substring(0, 5));
            // ticket amount
            int classAAmount;
            int classBAmount;
            int classCAmount;

            if (
                Int32.TryParse(textBox1.Text, out classAAmount) &&
                Int32.TryParse(textBox2.Text, out classBAmount) &&
                Int32.TryParse(textBox3.Text, out classCAmount)
            )
            {
                result = classACost * classAAmount + classBCost * classBAmount + classCCost * classCAmount;

                label13.Text = result.ToString() + " €";
            }
            else
            {
                button2.PerformClick();
            }

        }
    }
}
