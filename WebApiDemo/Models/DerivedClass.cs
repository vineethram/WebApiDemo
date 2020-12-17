using System;

namespace LinQtoObject
{
    public class DerivedClass : BaseClass
    {
        public override void displayClass()
        {
            Console.WriteLine();
            Console.WriteLine("Show use of \'base\' keyword");
            base.displayClass();
            Console.WriteLine("This is from the Derived Class ");
        }
    }
}