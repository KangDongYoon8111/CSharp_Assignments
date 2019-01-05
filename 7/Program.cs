using System;

class Program
{
    static void Main()
    {
        int i = 0;
        int a = 1;
        int b = 0;

        Console.WriteLine("'10' 숫자를 입력해주세요");
        string str = Console.ReadLine();
        bool parsed = Int32.TryParse(str, out i);
        //string[] strarr = str.Split();

        if (!parsed)
        {
            Console.WriteLine("'10' 숫자만 입력가능합니다.");
            Environment.Exit(0);
        }

        if(i == 10)
        {
            Console.WriteLine("입력숫자 : {0}", i);
            Console.Write("{0} 까지의 숫자 : ", i);
            /*for(int a = 1; a <= i; a++)
            {
                b += a;
                Console.Write("[0]", a);
            }
            Console.WriteLine();
            Console.WriteLine("{0}까지의 숫자합은 : {1}", i, b);*/
            while (a <= i)
            {
                b += a;
                Console.Write("{0} ", a);
                a++;
            }
            Console.WriteLine();
            Console.WriteLine("10 까지의 숫자합은 : {0}", b);     
        }
        else
        {
            Console.WriteLine("'10' 숫자만 입력가능합니다.");
        }
    }
}