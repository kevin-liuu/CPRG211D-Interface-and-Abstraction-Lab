using System.Runtime.CompilerServices;

namespace CPRG211D_Abstraction_Lab
{
    internal interface IAnimal // this is all  default public even though not stated
    {
        int Age { get; set; }
        string Colour { get; set; }

        int Height { get; set; }
        string Name { get; set; }

        void Cry(); // means all the other classes have to implement speak method 
        void Eat();
        string ToString();
    }
}