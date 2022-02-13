using System;

namespace ProjectTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            string reqem = Console.ReadLine();
            int num = int.Parse(reqem);
            if (num <= 1)
            {
                Console.WriteLine("Duzgun eded daxil edin");
                return;
            }
            
            Console.WriteLine(prime(num));



        }

        static bool prime(int a)
        {
            int netice = 0;
            int i = 0;

            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    netice++;
                }






            }
            if (netice == 2)
                return true;
            return false;

        }
    }
}
