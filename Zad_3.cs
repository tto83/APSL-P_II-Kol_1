using System;

namespace Kolokwium_1
{
     class Dzialania
     {
          public int a
          {
               get; set;
          }

          public int b
          {
               get; set;
          }

          public int NWD()
          {
               int temp;
               while (b != 0)
               {
                    temp = a % b;
                    a = b;
                    b = temp;
               }
               return a;
          }

          public int Potega()
          {
               int temp = 1;
               for (int i = 1; i <= b; i++)
               {
                    temp = temp * a;
               }
               return temp;
          }
     }

     class Program
     {
          static void Main(string[] args)
          {
               Console.Write("Podaj pierwszą liczbę naturalną: ");
               int l1 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Podaj drugą liczbę naturalną: ");
               int l2 = Convert.ToInt32(Console.ReadLine());

               Dzialania D = new Dzialania();
               D.a = l1;
               D.b = l2;

               Console.Write("Szukamy NWD(1) czy potęgi liczb(2)?\nPodaj wariant: ");
               int x = Convert.ToInt32(Console.ReadLine());

               if (x == 1)
               {
                    Console.WriteLine("NWD to: {0}", D.NWD());
               }
               else
               {
                    Console.WriteLine("Wynik potęgowania to: {0}", D.Potega());
               }

          }
     }
}
