using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class ObjectIndexor
    {

        public int idxSize;
        private int[] objs;

        public ObjectIndexor()
        {
            this.idxSize = 1;
            this.objs = new int[idxSize];
        }



        public int this[int i]
        {
            get
            {
                try
                {
                    if (i > idxSize)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        return objs[i];
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(" Tablica nie ma indeksu " + i + "\n");
                    return 0;
                }
            }


            set
            {
                if (i > idxSize)
                {
                    idxSize += (i - idxSize) + 1;
                    Array.Resize<int>(ref objs, idxSize);
                    objs[i] = value;
                }
                else
                {
                    objs[i] = value;
                }

            }
        }

        public void Add(int value)
        {
            Array.Resize<int>(ref objs, objs.Length * 2);
            objs[idxSize] = value;
            idxSize++;
        }


        public void Printing()
        {
            for (int i = 0; i < idxSize; i++)
                Console.WriteLine(i + ") komorka przechowuje " + objs[i] + "\n");

        }

    }
}
