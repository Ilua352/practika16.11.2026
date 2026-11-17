using System;

namespace praktika16._11._2026
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = Calculator.Add(num1, num2);
            Console.WriteLine(sum);

            Calculator.ShowDivision(num1, num2);

            Console.WriteLine();

            User myUser = new User(1, 2008, "Ivan_Dev", "ivan@example.com");
            myUser.DisplayInfo();


        }
    }
}