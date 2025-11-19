using System;

namespace MyAppforArrays
{
    public class Array1D
    {
        private int[] arr;    // приховане поле

        // Властивість: отримання розміру
        public int Length => arr.Length;

        // Конструктор без параметрів (масив 1 елемента)
        public Array1D()
        {
            arr = new int[1];
        }

        // Конструктор з параметром (розмір)
        public Array1D(int size)
        {
            arr = new int[size];
        }

        // Індексатор
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                    throw new IndexOutOfRangeException("Індекс за межами масиву");

                return arr[index];
            }
            set
            {
                if (index < 0 || index >= arr.Length)
                    throw new IndexOutOfRangeException("Індекс за межами масиву");

                arr[index] = value;
            }
        }

        // Перевірка чи масив впорядкований за спаданням
        public bool IsDescending()
        {
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] < arr[i + 1])
                    return false;

            return true;
        }

        // Повертає масив у вигляді рядка
        public string PrintArray()
        {
            return string.Join(" ", arr);
        }
    }
}
