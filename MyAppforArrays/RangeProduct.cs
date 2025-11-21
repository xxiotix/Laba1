using System;
using System.Collections.Generic;
using System.Text;

namespace MyAppforArrays
{
    public class RangeProduct
    {
        // Приховані поля
        private int a;
        private int b;

        // Відкрите поле
        public string Info = "Добуток чисел кратних 14";

        // Властивості
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        // Конструктор без параметрів
        public RangeProduct()
        {
            a = 1;
            b = 1;
        }

        // Конструктор з двома параметрами
        public RangeProduct(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        // конструктор з одним параметром
        public RangeProduct(int a)
        {
            this.a = a;
            this.b = a + 10;
        }

        // Метод для реалізації завдання
        public long Calculate()
        {
            long product = 1;
            bool found = false;

            // Гарантія правильного напрямку (на випадок, якщо a > b)
            int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            for (int i = start; i <= end; i++)
            {
                if (i % 14 == 0)
                {
                    product *= i;
                    found = true;
                }
            }

            // Якщо не знайдено жодного кратного 14
            return found ? product : 0;
        }
    }
}
