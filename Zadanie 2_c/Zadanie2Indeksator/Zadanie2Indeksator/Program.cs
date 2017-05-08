using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2Indeksator
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectIndexor objectIndexor = new ObjectIndexor();

            objectIndexor[3] = 4;
            objectIndexor.Printing();
            objectIndexor.Add(3);
            objectIndexor.Add(12);
            objectIndexor[9] = 66;
            objectIndexor.Add(23);
            objectIndexor.Printing();

            Console.ReadLine();
        }
    }
}
