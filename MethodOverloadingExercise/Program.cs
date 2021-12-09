using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            int addAnswer = Add(x, y);

            decimal a = 3.33m;
            decimal b = 5.55m;
            decimal decAnswer = Add1(a, b);

            string dollarAnswer = Add2(7, 8, true);

            Console.WriteLine($"Integers sum = {addAnswer}, decimal sum = {decAnswer}, {dollarAnswer}");

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add1(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add2(int x, int y, bool z)
        {
            if (true)
            {
                if (x + y > 1)
                {
                    return $"{x + y} dollars";
                }
                else
                {
                    return $"{x + y} dollar";
                }
            }
            else
            {
                return $"{x + y}";
            }
        }
    }
}
