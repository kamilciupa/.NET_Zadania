using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2Indeksator
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
            objectIndexor[0] = new Object();
            //Object object2 = objectIndexor[10];
            objectIndexor[12] = new Object();
            Object object2 = objectIndexor[10];
        }
    }
}
