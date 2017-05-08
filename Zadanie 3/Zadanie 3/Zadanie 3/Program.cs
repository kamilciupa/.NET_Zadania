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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            ObjectIndexor objectIndexor = new ObjectIndexor();

            /*
            objectIndexor[0] = 1;
            objectIndexor.Printing();
            */

            objectIndexor[3] = 4;
            objectIndexor.Printing();
            objectIndexor.Add(3);
            objectIndexor.Add(12);
            objectIndexor[9] = 66;
            objectIndexor.Add(23);
            objectIndexor.Printing();
        }
    }
}
