using System;

namespace lab8
{
    class Program
    {
        static void Main()
        {
            double i = 10;
            int a = 0;
            double b = 0;
            int num = 0;
            double avg;

            Console.WriteLine("Input the {0} numbers : ", i);

            for (num = 1; num <= i; num++)
            {
                Console.Write("숫자-{0} :", num);
                string str = Console.ReadLine() + "\n"; //"\n" 의 역할 확인필요.
                bool parsed = Int32.TryParse(str, out a);
                b += a;
            }

            avg = b / i;
            Console.WriteLine("합 : {0}", b);
            Console.WriteLine("평균 : {0}", avg);
        }
    }
}