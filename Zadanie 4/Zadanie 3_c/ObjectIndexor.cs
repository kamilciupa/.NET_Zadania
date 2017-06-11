using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class ObjectIndexorEventArgs : EventArgs
    {
        public int idxSize { get; set; }
        public int[] objs { get; set; }
    }

    class ObjectIndexor
    {
        private Object thisLock = new Object();
        public int idxSize;
        private int[] objs;
        public event EventHandler<ObjectIndexorEventArgs> NewElement;
        public event EventHandler<ObjectIndexorEventArgs> NewSize;


        public ObjectIndexor()
        {
            this.idxSize = 1;
            this.objs = new int[idxSize];
            EventsImpl events = new EventsImpl();
            this.NewSize += events.OnNewSize;
            this.NewElement += events.OnNewElement;
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
            Array.Resize<int>(ref objs, idxSize * 2);
            objs[idxSize] = value;
            idxSize++;
            //OnNewSize();
            //OnNewElement();
        }

        public void BlockingAdd(int value)
        {
            // lock (thisLock)
            System.Threading.Monitor.Enter(thisLock);
            try
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                Add(value);
                Console.WriteLine("Blocking) Dodano wartość " + value + "\n");
                stopwatch.Stop();
                Console.Write("Blocking) Czas oczekiwania na dostęp: " + stopwatch.ElapsedTicks + "\n");
            }
            catch (Exception)
            {

            } finally
            {
                System.Threading.Monitor.Exit(thisLock);
            }
        }

        public bool NonBlockingAdd(int value)
        {

            if (!System.Threading.Monitor.TryEnter(thisLock)) return false;
            try
            {
                Add(value);
                Console.WriteLine("NonBlocking) Dodano wartość: " + value + "\n");
                // System.Threading.Monitor.Exit(thisLock);
                return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                System.Threading.Monitor.Exit(thisLock);
            }
            return true;

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
