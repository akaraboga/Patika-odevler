using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_apıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("sayimiz 10 dan büyüktür");
            }
            else if (sayi < 10)
            {
                Console.WriteLine("sayimiz 10 ' dan küçüktür");
            }
            else {

                Console.WriteLine("sayimiz 10 ' a eşittir");
            }

            if (sayi % 2 == 0)
            {
                Console.WriteLine("sayimiz çift sayidir");
            }
            else
            {
                Console.WriteLine("tek sayidir");
            }

            Console.ReadLine();
        }
    }
}
