using System;

namespace LinQtoObject
{
    public class BaseClassCtorDemo
    {
        public int n1, n2;

        public BaseClassCtorDemo()
        {
            Console.WriteLine("Base Class default constructor invoked");
        }
        public BaseClassCtorDemo(int i, int j)
        {
            n1 = i;
            n2 = j;
            Console.WriteLine("Base class parametereized Constructor invoked");
            Console.WriteLine("The invoked Params in base are  {0}, {1}", n1, n2);

        }

        public virtual void swap()
        {
            Console.WriteLine("The numbers before Swapping");
            

            try
            {
                //Console.WriteLine(" n1 : {0], n2 : {1}", n1, n2);
                Console.WriteLine();

                /*n1 = n1 + n2;
                n2 = n1 - n2;
                n1 = n1 - n2;*/

                int t = n1;
                n1 = n2;
                n2 = t;

                Console.WriteLine("The numbers afer Swapping");
                Console.WriteLine(" n1 : {0}, n2 : {1}", n1, n2);
            }

            catch
            {
                throw ;
            }

        }
    }
}