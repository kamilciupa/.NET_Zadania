using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Plane : IRise, IAccelerate
    {
        private int speed;
        private int high;
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
        public int High
        {
            get { return this.high; }
            set { this.high = value; }
        }

        public Plane(string name)
        {
            Speed = 0;
            High = 0;
            Name = name; 
        }

        public void Accelerate(int change)
        {
            int buf = Speed;
            Speed = buf + change;
        }

        public void Rise(int change)
        {
            int buf = High;
            High = buf + change;
        }
    }
}
