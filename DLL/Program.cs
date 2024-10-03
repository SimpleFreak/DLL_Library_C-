using ArithmeticLibrary;
using System;

namespace DLL
{
    class Program
    {
        private static void Main()
        {
            double a = 10;
            double b = 5;

            double sum = Arithmetic.Add(a, b);
            Console.WriteLine($"Сумма: {sum}");

            double difference = Arithmetic.Subtract(a, b);
            Console.WriteLine($"Разность: {difference}");

            double product = Arithmetic.Multiply(a, b);
            Console.WriteLine($"Произведение: {product}");

            double quotient = Arithmetic.Divide(a, b);
            Console.WriteLine($"Частное: {quotient}");

            double power = Arithmetic.Power(a, b);
            Console.WriteLine($"a в степени b: {power}");

            double modulo = Arithmetic.Modulo(a, b);
            Console.WriteLine($"Остаток от деления a на b: {modulo}");
        }
    }
}
