using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe4
{
    class Program
    {
        static bool JeProst(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Zadatak1()
        {
            Console.Write("Unesite broj n(velicina niza): ");
            int n; // deklarirana varijabla n
            n = int.Parse(Console.ReadLine()); // int.Parse pretvara tekst u broj ako je moguce, Console.ReadLine čita upisane simbole u konzoli i vraća string

            int[] niz = new int[n];
            string ispis = "";

            for (int i = 0; i < n; i++)
            {
                Console.Write("Unesite broj u niz: ");
                niz[i] = int.Parse(Console.ReadLine());

                if (JeProst(niz[i]))
                {
                    ispis += niz[i].ToString() + " ";
                }
            }

            Console.WriteLine(ispis);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Zadatak1(); // Laura se treba smiriti i ne napastovati Josipa(seksualno ili neseksualno)
        }
    }
}
