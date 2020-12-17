namespace LinQtoObject
{
    public class DerivedClassCtorDemo : BaseClassCtorDemo
    {
        public DerivedClassCtorDemo() : base()
        {

        }

        public DerivedClassCtorDemo(int i, int j) : base(i,j)
        {

        }

        public override void swap()
        {
            base.swap();
            System.Console.WriteLine();

            System.Console.WriteLine("Swap method in derived class invoked : ");

            System.Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);
 
        // swapping
        int t = n1;
        n1 = n2;
        n2 = t;
        System.Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
        }
    }
}