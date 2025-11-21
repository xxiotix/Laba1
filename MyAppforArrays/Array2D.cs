using System;
using System.Collections.Generic;
using System.Text;

namespace MyAppforArrays
{
    internal class Array2D
    {
        private int[,] arr;    // приховане поле
        public int Rows => arr.GetLength(0);
        public int Cols => arr.GetLength(1);
        // Конструктор без параметрів
        public Array2D()
        {
            arr = new int[3, 3];
        }
        // Конструктор з параметрами
        public Array2D(int rows, int cols)
        {
            arr = new int[rows, cols];
        }
        // Індексатор
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= Rows || j >= Cols)
                    throw new IndexOutOfRangeException("Індекс за межами масиву");
                return arr[i, j];
            }
            set
            {
                if (i < 0 || j < 0 || i >= Rows || j >= Cols)
                    throw new IndexOutOfRangeException("Індекс за межами масиву");
                arr[i, j] = value;
            }
        }

        // Заповнення за формулою
        public void Fill(int a1, int a2, int a3)
        {
            int[] a = { a1, a2, a3 };

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    arr[i, j] = (int)Math.Pow(a[i], i + 1) - 3 * (int)Math.Pow(a[j], j + 1);
        }
        
        // Вивід всього масиву
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    sb.Append($"{arr[i, j],6}");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
