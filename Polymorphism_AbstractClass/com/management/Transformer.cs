using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_AbstractClass.com.management
{
    
    abstract class Transformer
    {
        public Transformer()
        {
            Console.WriteLine("Hello");
        }
       public void show()
        {
            Console.WriteLine("This is show method");
        }
        public  abstract void run();
    }

    class Car : Transformer
    {

        
       public override void run()
        {
            Console.WriteLine("Car is running");
        }
    }
    class Boat : Transformer
    {
        public override void run()
        {
            Console.WriteLine("boat is running");
        }
    }
    class Plane : Transformer
    {
        public override void run()
        {
            Console.WriteLine("Plane is running");
        }
    }
}
