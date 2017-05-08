using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        //[STAThread]
        static void Main(string[] args)
        {
            // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            ObjectIndexor objectIndexor = new ObjectIndexor();
            EventsImpl events = new EventsImpl();

            objectIndexor.NewSize += events.OnNewSize;
            objectIndexor.NewElement += events.OnNewElement;

            // Rozszerzenie tablicy do 5 elementu

            objectIndexor[5] = 5;

            // Dodanie elementu na koniec

            objectIndexor.Add(23);

            //Odczytanie poza zakresem

            //int test = objectIndexor[8];

            Console.ReadKey();
        }
    }
}
