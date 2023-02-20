using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_Abstraction_Lab
{
    internal class Dog : Animal //Implement abstract class to get rid of red line

    {
        //Need to write constructor after implementing
        public Dog(string name, string colour, int age, int height): base(name, colour, age, height)
        {

        }

        public override void Cry()
        {
           
           Console.WriteLine("Woof");
        }

        // Generates eat method right after implementing 
        public override void Eat()
        {

            Console.WriteLine("Dogs eat meat");
        }

        
    }
}
