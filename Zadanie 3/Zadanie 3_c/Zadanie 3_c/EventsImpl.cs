using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_c
{
    class EventsImpl
    {

        public void OnNewSize(object source, ObjectIndexorEventArgs args)
        {
            Console.WriteLine("____________");
            Console.WriteLine(" Zmieniono rozmiar. Obecny rozmiar tablicy to: " + args.idxSize);
            Console.WriteLine("____________");
        }

        public void OnNewElement(object source, ObjectIndexorEventArgs args)
        {
            Console.WriteLine("____________");
            Console.WriteLine(" Dodano wartość : " + args.objs[args.idxSize - 1] + " do ostatniego indeksu tablicy");
            Console.WriteLine("____________");
        }
    }
}
