using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_AbstractClass.com.PurePolymorphism
{
    interface ITransformer
    {
        void State();
    }
    class Car : ITransformer
    {
        public void State()
        {
            Console.WriteLine("Run Car");
        }
    }
    class Boat : ITransformer
    {
        public void State()
        {
            Console.WriteLine("Run Boat");

        }
    }
    class Plane : ITransformer
    {
        public void State()
        {
            Console.WriteLine("Run Plane");
        }
    }
}
