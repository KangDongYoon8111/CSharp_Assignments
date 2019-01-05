using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("출력을 원하는 구구단 단수 : ");

            string str = null;
            bool parsed = false;
            int m = 0;

            do
            {
                str = Console.ReadLine() + "\n";

                parsed = Int32.TryParse(str, out m);

                if (!parsed)
                {
                    Console.WriteLine("숫자도 입력 못하세요!!");
                }
            } while (parsed == false);

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    Console.Write(j + "x" + i + " = " + i * j);
                    if (j < m)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}