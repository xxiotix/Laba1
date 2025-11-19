using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyAppforArrays
{
    public partial class Form2 : Form
    {
        private Array1D? arr;

        public Form2()
        {
            InitializeComponent();
            buttonCheck.Click += buttonCheck_Click;
        }
        private void buttonCreate_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Введіть додатній розмір!");
                return;
            }

            arr = new Array1D(n);

            dataGridView1.Rows.Clear();
        }

        private void buttonCheck_Click(object? sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Спочатку створіть масив!");
                return;
            }

            dataGridView1.EndEdit();  // 🔥 ДУЖЕ ВАЖЛИВО

            for (int i = 0; i < arr.Length; i++)
            {
                var cell = dataGridView1[0, i].Value;

                if (cell == null || string.IsNullOrWhiteSpace(cell.ToString()))
                {
                    MessageBox.Show($"Комірка {i + 1} порожня!");
                    return;
                }

                arr[i] = Convert.ToInt32(cell);
            }

            label2.Text = arr.IsDescending() ? "Так ✔" : "Ні ✘";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    dataGridView1[0, i].Value = "";

            label2.Text = " ";
            arr = null;

            textBox1.Clear();
            textBoxIndex.Clear();
            textBox1.Focus();
        }

        private void buttonShowElement_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Спочатку створіть масив!");
                return;
            }

            if (!int.TryParse(textBoxIndex.Text, out int index))
            {
                MessageBox.Show("Введіть цілий індекс!");
                return;
            }

            try
            {
                int value = arr[index];
                MessageBox.Show($"Елемент arr[{index}] = {value}");
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonShowArray_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Спочатку створіть масив!");
                return;
            }

            MessageBox.Show(arr.PrintArray(), "Весь масив");
        }
    }
}
