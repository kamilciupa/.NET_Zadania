using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_c
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectIndexor objectIndexor = new ObjectIndexor();
            EventsImpl events = new EventsImpl();
            objectIndexor.NewSize += events.OnNewSize;
            objectIndexor.NewElement += events.OnNewElement;
            // Rozszerzenie tablicy do 5 elementu

            objectIndexor[5] = 5;

            // Dodanie elementu na koniec

            objectIndexor.Add(23);

            //Odczytanie poza zakresem

            int test = objectIndexor[8];

            objectIndexor.Printing();

            Console.ReadKey();
        }
    }
}
