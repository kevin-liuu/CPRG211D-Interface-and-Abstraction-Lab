using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_Abstraction_Lab
{
    internal class Cat : Animal
    {
        public Cat(string name, string colour, int age, int height) : base(name, colour, age, height)
        {
        }

        public override void Cry()
        {
            
            Console.WriteLine("Meow");
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

       
    }
}
