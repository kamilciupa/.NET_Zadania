using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Submarine : IDive, IAccelerate
    {

        private int speed;
        private int depth;
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }     
        }

        public int Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }

        public Submarine(string name)
        {
            Speed = 0;
            Depth = 0;
            Name = name;
        }


        public void Accelerate(int change)
        {
            int buf = Speed;
            Speed = buf + change;
        }

        public void Dive(int change)
        {
            int buf = Depth;
            Depth = buf + change;
        }
    }
}
