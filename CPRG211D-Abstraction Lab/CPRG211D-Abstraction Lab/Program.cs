using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_Abstraction_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PART 1
            /*Animal dog = new Dog ("Max", "White", 5, 100);
            dog.Eat();
            
            Animal cat = new Cat("Mouse", "Black", 4, 114);
            cat.Eat();
            //PART 2
            IAnimal dog2 = new Dog("Bob", "Gray", 2, 32);
            dog2.Eat();
            dog2.Cry();
            IAnimal cat2 = new Cat("Tiny", "Orange", 7, 90);
            cat2.Eat(); 
            cat2.Cry();*/

            Console.WriteLine("Enter Dog Name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter Dog Height: "); 
            string intput1 = Console.ReadLine();
            int dogHeight;
            dogHeight = Convert.ToInt32(intput1);
            Console.WriteLine("Enter Dog Color: ");
            string dogColor = Console.ReadLine();
            Console.WriteLine("Enter Dog Age");
            string input2 = Console.ReadLine();
            int dogAge = Convert.ToInt32(input2);
            Console.WriteLine("\n");

            IAnimal newdog = new Dog(dogName,dogColor, dogAge, dogHeight);
            Console.WriteLine(newdog);
            newdog.Eat();
            newdog.Cry();
            Console.WriteLine("\n");

            Console.WriteLine("Enter Cat Name: ");
            string catName = Console.ReadLine();
            Console.WriteLine("Enter Cat Height: ");
            string intput3 = Console.ReadLine();
            int catHeight;
            catHeight = Convert.ToInt32(intput3);
            Console.WriteLine("Enter Cat Color: ");
            string catColor = Console.ReadLine();
            Console.WriteLine("Enter Cat Age");
            string input4 = Console.ReadLine();
            int catAge = Convert.ToInt32(input4);
            Console.WriteLine("\n");

            IAnimal newcat = new Cat(catName, catColor, catAge, catHeight);
            Console.WriteLine(newcat);
            newcat.Eat();
            newcat.Cry();
            Console.WriteLine("\n");

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(newdog);
            animals.Add(newcat);

            foreach (var i in animals)
            {
                Console.WriteLine(i+"\n");

            }
           


        }
    }
}
