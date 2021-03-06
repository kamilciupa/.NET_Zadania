﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_c
{
    class ObjectIndexorEventArgs : EventArgs
    {
        public int idxSize { get; set; }
        public int[] objs { get; set; }
    }

    class ObjectIndexor
    {

        public int idxSize;
        private int[] objs;
        public event EventHandler<ObjectIndexorEventArgs> NewElement;
        public event EventHandler<ObjectIndexorEventArgs> NewSize;


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
                   
                    OnNewSize();
                }
               
                    objs[i] = value;
                

            }
        }

        public void Add(int value)
        {
            //Array.Resize<int>(ref objs, objs.Length * 2);
            Array.Resize<int>(ref objs, idxSize * 2);
            objs[idxSize] = value;
            idxSize++;
            OnNewSize();
            OnNewElement();
        }


        public void Printing()
        {
            for (int i = 0; i < idxSize; i++)
                Console.WriteLine(i + ") komorka przechowuje " + objs[i] + "\n");

        }

        public virtual void OnNewSize()
        {
            if (NewSize != null)
                NewSize(this, new ObjectIndexorEventArgs() { idxSize = idxSize });
        }

        public virtual void OnNewElement()
        {
            if (NewElement != null)
                NewElement(this, new ObjectIndexorEventArgs() { idxSize = idxSize, objs = objs });
        }

    }
}
