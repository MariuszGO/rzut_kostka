using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        public static void rzut_kostka() {
            int ilosc;
            
            Random losowanie = new Random();
            do
            {
                Console.WriteLine("Podaj ilość rzutów (min: 3 max: 10)");
                ilosc = Convert.ToInt32(Console.ReadLine());

            } while (!(ilosc >= 3 && ilosc <= 10));


            int [] rzut = new int[ilosc+1];
            int [] rzut_ilosc = new int[7];
            int suma = 0;
            for (int i = 1; i < 7; i++)
            {
                rzut_ilosc[i] = 0;
            }


                for (int i = 1; i < ilosc+1; i++)
            {
                rzut[i] = losowanie.Next(0,7);
                rzut_ilosc[rzut[i]] = rzut_ilosc[rzut[i]] + rzut[i];
                Console.WriteLine(rzut[i]);
            }

                for(int i = 1;i < 7; i++)
            {
                if (rzut_ilosc[i] > i)
                {
                    suma = suma + rzut_ilosc[i];
                }
            }
            Console.WriteLine("Suma rzutów ponowionych: " + suma);

        }
        
        
        static void Main(string[] args)
        {
            rzut_kostka();
            Console.WriteLine("Hello World!");
        
        
        
        
        }
    }
}