using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Polymorphism_AbstractClass.com.management;
//using Polymorphism_AbstractClass.com.PurePolymorphism;
using Polymorphism_AbstractClass.com.Explict_MultipleInhertance;
namespace Polymorphism_AbstractClass
{
    class Program
    {
        
       static void Main(string[] args)
        {
            /*  Transformer t = new Car();
              t.show();
              t.run();

               t = new Boat();
              t.run();

               t = new Plane();
              t.run();

      */


            //Interface use Here
            /*
            ITransformer ob = new Car();
            ob.State();

             ob = new Boat();
            ob.State();

             ob = new Plane();
            ob.State();
            */

            //Use Multiple Inheretence, Explict Implimentation of method

            Car c = new Car();
            ITransformer it = c;
            it.Run();

            IExamle ie = c;
            ie.Run();

            Console.ReadLine();
        }
    }
    
}
