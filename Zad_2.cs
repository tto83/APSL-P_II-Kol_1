using System;

namespace Kolokwium_1
{
     class Faktura
     {
          public double vat()
          {

               Console.Write("Wybierz stawkę VAT - 3%, 7%, 15%, 23%, np. 7 dla 7%: ");
               double a = Convert.ToInt32(Console.ReadLine());
               return a / 100;
          }

          public double ilosc()
          {
               Console.Write("Podaj ilość produktu: ");
               double ilosc = Convert.ToDouble(Console.ReadLine());
               return ilosc;
          }

          public double cena()
          {
               Console.Write("Podaj cenę produktu: ");
               double cena = Convert.ToDouble(Console.ReadLine());
               return cena;
          }

          public void liczVat()
          {
               double var_net = ilosc() * cena();
               double var_brut = var_net * (1 + vat());
               Console.WriteLine("Wartość netto: {0}", var_net);
               Console.WriteLine("Wartość brutto: {0}", var_brut);
          }

          public void odliczVat()
          {
               Console.WriteLine("Podaj kwotę brutto: ");
               double var_brut = Convert.ToDouble(Console.ReadLine());
               double var_vat = 1 + vat();
               Console.WriteLine("Warość netto: {0}", var_brut / var_vat);
               Console.WriteLine("Warość podatku: {0}", var_brut - (var_brut / var_vat));
          }
     }
     class Program
     {
          static void Main(string[] args)
          {
               Console.Write("Czy liczbymy kwotę brutto(1) czy netto(2)?\nWariant: ");
               int b = Convert.ToInt32(Console.ReadLine());

               Faktura F = new Faktura();

               if (b == 1)
               {
                    F.liczVat();
               }
               else
               {
                    F.odliczVat();
               }
          }
     }
}
