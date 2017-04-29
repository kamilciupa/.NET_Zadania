using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2Indeksator
{
    class ObjectIndexor
    {
        
        public int idxSize = 10;


        private Object[] objs = new Object[10];
        public Object this[int i]
        {
            get
            {
               try
                {
                    return objs[i];
                }
                catch (Exception ex)
                {
                    throw new ArgumentOutOfRangeException("Indexor out of bounds", ex);
                }
                
            }


            set
            {
                if(i > objs.Length - 1)
                {
                    ChangeSize(i);
                    objs[i] = value;
                }
                else
                {
                    objs[i] = value;
                }
                
            }
        }

        public void Add(Object value)
        {
            objs[objs.Length-1] = value;
        }


        public void ChangeSize(int size)
        {
            Object[] temporary = new Object[idxSize];
            for (int i = 0; i < objs.Length; i++)
                temporary[i] = objs[i];

            objs = new Object[idxSize + size];

            for (int i = 0; i < temporary.Length; i++)
                objs[i] = temporary[i];

           System.Console.WriteLine("Size is bigger now \n");
        }


    }
}
