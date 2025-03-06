using System;

class Program
{
    static void Main()
    {

        Console.Write("Birinci ededi daxil edin:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ikinci ededi daxil edin:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (x % 2 == 0 && n % 2 == 0)
        {
            int cem = x + n;
            Console.WriteLine("Cem: " + cem);
        }
        else
        {
            Console.WriteLine("Daxil olan ededler cut olmalidir");
        }

       

    }
}