using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("'10' 숫자를 입력해주세요");
        string str = Console.ReadLine();
        str.Trim();
        //string[] strarr = str.Split();

        int a = 0;
        int b = 0;
        int i = int.Parse(str);
        if(i == 10)
        {
            while (a <= i)
            {
                b += a;
                a++;
                Console.Write("10 까지의 숫자 : {0}", a);
            }
            Console.WriteLine("10 까지의 숫자합은 : {0}", b);            
        }
        else
        {
            Console.WriteLine("'10' 숫자만 입력가능합니다.");
        }
    }
}