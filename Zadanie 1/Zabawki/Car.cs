using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : IAccelerate
    {

        private int speed;
        private string name;

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Car(string name)
        {
            Speed = 0;
            Name = name;
        }

        public void Accelerate(int change)
        {
            int buf = Speed;
            Speed = buf + change;
        }
    }
}
