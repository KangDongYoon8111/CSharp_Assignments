using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요. ");
            string str = Console.ReadLine();
            int m = 0;
            int sum = 0;
            bool parsed = Int32.TryParse(str, out m);

            if (!parsed)
            {
                Console.WriteLine("숫자도 입력 못하세요!!");
                Environment.Exit(0);
            }

            Console.Write(m + "까지의 숫자 : ");
            for (int i = 1; i <= m; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write(m + "까지의 숫자합은 : " + sum);
        }
    }
}