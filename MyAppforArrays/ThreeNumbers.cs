using System;
using System.Collections.Generic;
using System.Text;

namespace MyAppforArrays
{
    public class ThreeNumbers
    {
        // Приховані поля
        private int a;
        private int b;
        private int c;
        // Відкрите поле
        public String Description = "Порівняння трьох чисел";
        // Властивості
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
        // Конструктор без параметрів
        public ThreeNumbers()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        // Конструктор з параметрами
        public ThreeNumbers(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // Конструктор з одним параметром
        public ThreeNumbers(int a) : this(a, 0, 0)
        {
        }
        // Метод для порівняння чисел
        public int Calculate()
        {
            if (a > 15 && b > 15 && c > 15)
                return a * b * c;
            else
            {
                int sum = a + b + c;
                return sum * sum;
            }
        }
    }
}
