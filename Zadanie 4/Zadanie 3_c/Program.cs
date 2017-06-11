using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {

        static void Main(string[] args)
        {
            ObjectIndexor objectIndexor = new ObjectIndexor();
            EventsImpl events = new EventsImpl();

            objectIndexor.NewSize += events.OnNewSize;
            objectIndexor.NewElement += events.OnNewElement;


            int howLong = 0;
            int howLong2 = 0;
            Thread t1 = new Thread(() =>
            {
                while (howLong < 20)
                {
                    Thread.Sleep(300);
                    objectIndexor.BlockingAdd(50);
                    howLong++;
                }
            });

            Thread t2 = new Thread(() =>
            {
                while(howLong2 < 20)
                {
                    if (!objectIndexor.NonBlockingAdd(25))
                    {
                        Console.WriteLine("NonBlocking)  Nie dodano wartosci" + "\n");
                    } 
                    Thread.Sleep(300);
                    howLong2++;
                }
            });

 
            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
    }
}
