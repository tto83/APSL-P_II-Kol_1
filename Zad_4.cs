using System;

namespace Kolokwium_1
{
     class Przesuwanie
     {
          public int[] tablica = new int[10];

          public int p
          {
               get; set;
          }

          public void losowanie()
          {
               int i = 0;
               Random rand = new Random();

               while (i < 10)
               {
                    int liczba = rand.Next(1, 50);
                    tablica[i] = liczba;
                    i++;
               }
          }

          public void lewo_prawo()
          {
               int[] temp_tablica = new int[10];
               Random rand = new Random();

               if (p > 0)
                    for (int i = 0; i < 10; i++)
                    {
                         if (i + p < 10)
                         {
                              temp_tablica[i] = tablica[i + p];
                         }
                    }
               else
               {
                    for (int i = 9; i >= 0; i--)
                    {
                         if (i + p >= 0)
                         {
                              temp_tablica[i] = tablica[i - (-p)];
                         }
                    }
               }

               for (int i = 0; i < 10; i++)
               {
                    if (temp_tablica[i] == 0)
                    {
                         int liczba = rand.Next(51, 100);
                         temp_tablica[i] = liczba;
                    }
               }

               Console.Write("Tablica przed przesunięciem: ");
               foreach (int liczba in tablica)
               {
                    Console.Write("{0} ", liczba);
               }
               Console.Write("\nTablica po przesunięciu: ");
               foreach (int liczba in temp_tablica)
               {
                    Console.Write("{0} ", liczba);
               }

          }
     }

     class Program
     {
          static void Main(string[] args)
          {
               Przesuwanie P = new Przesuwanie();
               int p1 = 99;

               while (Math.Abs(p1) > 8)
               {
                    Console.Write("Podaj współczynnik do przesunięcia, ujemny jeśli w prawo, dodatni jeśli w lewo (max 8): ");
                    p1 = Convert.ToInt32(Console.ReadLine());
               }

               P.p = p1;

               P.losowanie();
               P.lewo_prawo();

          }
     }
}