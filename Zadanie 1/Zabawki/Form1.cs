using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zabawki
{
    public partial class Form1 : Form
    {

        int WhichClass;
        int WhichType;
        Car car;
        Plane plane;
        Submarine submarine;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObjectTypeBox.Items.Insert(0, "Car");
            ObjectTypeBox.Items.Insert(1, "Plane");
            ObjectTypeBox.Items.Insert(2, "Submarine");
            ObjectTypeBox.Items.Insert(3, "Computer");
            TextBoxesOff();
        }

        private void ObjectTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhichClass = ObjectTypeBox.SelectedIndex;
           

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            switch (WhichClass)
            {
                case 0:
                    Car car = new Car("car");
                    ObjectBox.Items.Add(car);
                    break;
                case 1:
                    Plane plane = new Plane("plane");
                    ObjectBox.Items.Add(plane);
                    break;
                case 2:
                    Submarine submarine = new Submarine("submarine");
                    ObjectBox.Items.Add(submarine);
                    break;
                case 3:
                    Computer computer = new Computer("computer");
                    ObjectBox.Items.Add(computer);
                    break;
                default:
                    break;
            }
        }

        private void ObjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxesOff();
            Type type =  ObjectBox.SelectedItem.GetType();
            Type[] interfaces =  type.GetInterfaces();
            WhichType = 0;

            foreach(Type t in interfaces)
            {
                if (t.Equals(typeof(IAccelerate)))
                {
                    SpeedBox.Visible = true;
                    WhichType += 1;
                }
                if (t.Equals(typeof(IDive)))
                {
                    DepthBox.Visible = true;
                    WhichType += 2;
                }
                if (t.Equals(typeof(IRise)))
                {
                    HighBox.Visible = true;
                    WhichType += 4;
                }
            }

            if(WhichType == 1)
            {
                car = (Car)ObjectBox.SelectedItem;
                SpeedBox.Text = car.Speed.ToString();
            } else if (WhichType == 3)
            {
                submarine = (Submarine)ObjectBox.SelectedItem;
                SpeedBox.Text = submarine.Speed.ToString();
                DepthBox.Text = submarine.Depth.ToString();
            } else if (WhichType == 5)
            {
                plane = (Plane)ObjectBox.SelectedItem;
                SpeedBox.Text = plane.Speed.ToString();
                HighBox.Text = plane.High.ToString();
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(WhichType == 1)
            {
                car.Speed = Int32.Parse(SpeedBox.Text);
            } else if(WhichType == 3)
            {
                submarine.Speed = Int32.Parse(SpeedBox.Text);
                submarine.Depth = Int32.Parse(DepthBox.Text);
            } else if (WhichType == 5)
            {
                plane.Speed = Int32.Parse(SpeedBox.Text);
                plane.High = Int32.Parse(HighBox.Text);
            }
        }

        private void TextBoxesOff()
        {
            SpeedBox.Visible = false;
            HighBox.Visible = false;
            DepthBox.Visible = false;
        }


    }

}
