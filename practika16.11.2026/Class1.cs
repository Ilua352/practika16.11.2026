using System;

namespace praktika16._11._2026
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        private static double Dev(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: на ноль делить нельзя!");
                return 0;
            }
            return (double)a / b;
        }

        public static void ShowDivision(int a, int b)
        {
            double result = Dev(a, b);
            Console.WriteLine($"Результат деления: {result}");
        }
    }
}