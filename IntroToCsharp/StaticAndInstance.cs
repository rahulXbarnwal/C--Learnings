using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp
{

    // static methods can be called by only the class itself and not the instances
    // static constructor is called only once, no matter how many instances you create
    // static constructors are called before instance constructors and even before you refer to any static field of that class
    class Circle
    {
        //static float _PI = 3.141F;
        static float _PI;
        int _Radius;
        static Circle()
        {
            Console.WriteLine("static constructor called");
            Circle._PI = 3.141F;
        }
        public Circle(int r)
        {
            _Radius = r;
        }
        public float CalculateArea()
        {
            return _Radius * _Radius * Circle._PI;
        }
    }
    internal class StaticAndInstance
    {
        public void func()
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine(Area1);

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine(Area2);

            // only this line and make static field of _PI as public, then just by calling the static field using Class Circle will invoke the static constructor
            //Console.WriteLine(Circle._PI);
        }
    }
}
