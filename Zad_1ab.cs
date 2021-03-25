using System;

namespace Kolokwium_1
{
     class Pierwsza
     {
          int n;

          public int n2
          {
               get; set;
          }

          public bool sprwadzPierwsza() //sprawdzamy tylko nieparzyste z wyłączeniem 2
          {
               Console.Write("Podaj liczbę do sprawdzenia: ");
               n = Convert.ToInt32(Console.ReadLine());

               if (n % 2 == 0)
               {
                    return (n == 2);
               }
               for (int i = 3; i <= Math.Sqrt(n); i += 2)
               {
                    if (n % i == 0)
                    {
                         return false;
                    }
               }
               return true;
          }

          public bool sprwadzPierwsza2()
          {
               if (n2 % 2 == 0)
               {
                    return (n2 == 2);
               }
               for (int i = 3; i <= Math.Sqrt(n2); i += 2)
               {
                    if (n2 % i == 0)
                    {
                         return false;
                    }
               }
               return true;
          }
     }
     class Program
     {
          static void Main(string[] args)
          {
               Pierwsza P = new Pierwsza();
               if (P.sprwadzPierwsza())
               {
                    Console.WriteLine("Twoja liczba jest liczba pierwsza");
               }
               else
               {
                    Console.WriteLine("Twoja liczba nie jest liczba pierwsza");
               }

               Console.Write("\nPodaj kolejną liczbę do sprawdzenia: ");
               int a = Convert.ToInt32(Console.ReadLine());
               P.n2 = a;
               if (P.sprwadzPierwsza2())
               {
                    Console.WriteLine("Twoja liczba jest liczba pierwsza");
               }
               else
               {
                    Console.WriteLine("Twoja liczba nie jest liczba pierwsza");
               }
          }
     }
}
