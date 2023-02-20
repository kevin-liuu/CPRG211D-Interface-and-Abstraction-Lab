using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_Abstraction_Lab
{
    internal abstract class Animal : IAnimal
    // abstract makes it so when it is called it can only be called within Animal or something that inherits Animal
    {
        protected string name;
        protected string colour;
        protected int age;
        protected int height; 

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }

        public int Height { 
            get { return this.height; }
            set { this.height= value; }
        }

        public Animal(string name, string colour, int age, int height)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
            this.height = height;
        }
        public abstract void Eat(); //can not have curly brackets and have to put semicolon when you make an abstract method

        public abstract void Cry(); // has to be implemented because of IAnimal interface 
        public override string ToString()
        {
            string display =
                string.Format("Name: " + this.name) + "\n"+
                string.Format("Color: " + this.colour) + "\n" +
                string.Format("Age: " + this.age) + "\n" +
                string.Format("Height: " + this.height);
            return display;
        }

    }
}
