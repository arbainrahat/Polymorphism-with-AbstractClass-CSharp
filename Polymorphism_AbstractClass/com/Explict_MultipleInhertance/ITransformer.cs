using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_AbstractClass.com.Explict_MultipleInhertance
{
    interface ITransformer
    {
        void Run();
    }

    interface IExamle
    {
        void Run();
    }

    class Car : ITransformer, IExamle
    {
        void ITransformer.Run()
        {
            Console.WriteLine("ITransformer");
        }

        void IExamle.Run()
        {
            Console.WriteLine("IExample");
        }
    }
}
