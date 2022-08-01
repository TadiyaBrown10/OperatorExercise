using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;

            var b = 4;

            int div = a / b;
            int mod = a % b;


            if (a == 17 && b == 4)

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");
        }
    }
}

