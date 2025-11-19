using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyAppforArrays
{
    public partial class Form3 : Form
    {
        private Array2D array;

        public Form3()
        {
            InitializeComponent();
            array = new Array2D(3, 3);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int a1 = int.Parse(textBoxa1.Text);
                int a2 = int.Parse(textBoxa2.Text);
                int a3 = int.Parse(textBoxa3.Text);

                array.Fill(a1, a2, a3);

                richTextBoxMatrix.Text = array.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxa1.Clear();
            textBoxa2.Clear();
            textBoxa3.Clear();
            richTextBoxMatrix.Clear();
            textBoxRow.Clear();
            textBoxCol.Clear();

            textBoxa1.Focus();
        }

        private void buttonShowElement_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBoxRow.Text);
                int j = int.Parse(textBoxCol.Text);

                int value = array[i, j];

                MessageBox.Show($"Елемент [{i},{j}] = {value}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть правильні індекси (цілі числа).");
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
