using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imtahanlarin sayini daxil edin");
            string imtahansayi = Console.ReadLine();
            int say = int.Parse(imtahansayi);
            int[] arr = new int[say];

            for (int i = 0; i < arr.Length; i++)
            {
            step:
                Console.WriteLine("Imtahan ballarini duzgun shekilde daxil edin");
                string b = Console.ReadLine();
                int points = int.Parse(b);
                arr[i] = points;
            
                if (points > 100)
                {
                    Console.WriteLine("Imtahan neticesini duzgun daxil edin");
                    goto step;
                }


            }


            if (calcavg(arr, say) > 60)
            {
                Console.WriteLine("Mezun oldunuz");

            }
            else
            {
                Console.WriteLine("Mezun ola bilmediniz");



            }



        }
        static int calcavg(int[] arr, int points)
        {
            int examsum = 0;
            int average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                examsum += arr[i];
            }
            average = examsum / arr.Length;

            return average;
        }
    }
}