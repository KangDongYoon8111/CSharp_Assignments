using System;

class Program
{
    static void Main()
    {
        int i = 0;
        while (i <= 10)
        {
            i += 1;
            if(i % 2 ==0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("---------------------------------");
        i = 0;
        while (i <= 10)
        {
            i += 1;
            if (!(i % 2 != 0))
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("---------------------------------");
        //i = 0;
        for(i=1; i <= 10; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}