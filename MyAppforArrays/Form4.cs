using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyAppforArrays
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBoxA.Text);
            int y = Convert.ToInt32(textBoxB.Text);
            int z = Convert.ToInt32(textBoxC.Text);

            ThreeNumbers t = new ThreeNumbers(x, y, z);
            labelResult1.Text = "Результат: " + t.Calculate();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxA2.Text);
            int b = Convert.ToInt32(textBoxB2.Text);

            RangeProduct r = new RangeProduct(a, b);
            labelResult2.Text = "Результат: " + r.Calculate();
        }

        private void buttonClear1_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            labelResult1.Text = " ";

            textBoxA.Focus();
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            textBoxA2.Clear();
            textBoxB2.Clear();
            labelResult2.Text = " ";

            textBoxA2.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
