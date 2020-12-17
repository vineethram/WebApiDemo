namespace LinQtoObject
{
    public class DemoDelegate
    {
        static int num = 10;
        public static int AddNum (int p)
        {
            num += p;
            return num;
        }
        public static int MulNum (int p)
        {
            num *= p;
            return num;
        }
        public static int Num => num;
    }
}