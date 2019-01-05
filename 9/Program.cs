using System;

namespace lab9
{
    class Program
    {
        static void Main()
        {
            var i = 0;
            int b = 1;

            Console.Write("출력을 원하는 구구단 단수 : ");
            string str = Console.ReadLine();
            bool parsed = Int32.TryParse(str, out i);

            if (!parsed)
            {
                Console.WriteLine("숫자를 입력해서 다시 시도해주세요.");
                Environment.Exit(0);
            }

            else
            {
                for(int num = 2; num <= 9; num++)
                {
                    for(int a =1; a <= i; a++)
                    {
                        Console.Write("{0}x{1} = {2}", a, num, num * a);
                        //Console.Write(a + "x" + num + " = " + num * a);
                        if (a < i)
                        {
                            Console.Write(", ");
                        }
                    }

                    /*while (b <= i)
                    {
                        Console.Write("{0}x{1} = {2}", b, num, b * num);
                        if (b < i)
                        {
                            Console.Write(", ");
                        }
                        b++;
                    }*/
                    Console.Write("\n");    // "\n" 의 정확한 기능???
                }
            }
        }
    }
}