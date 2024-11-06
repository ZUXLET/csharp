namespace lesson_7
{
    class Program
    {
        /*public static int DivideAndRound(double a, double b)
        {
            var c = a / b;
            var d = (int)Math.Round(c);
            return d;
            //return (int)math.round(a/b);
        }*/
        public static void WriteNumber(int a) // не возвращает ничего
        {
            Console.WriteLine("a is int");
            Console.WriteLine(a);
        }
        public static void WriteNumber(double a)
        {
            Console.WriteLine("a is double");
            Console.WriteLine(a);
        }
        /*static void Main(string[] args)
        {
            var c = DivideAndRound(2, 3);
            Console.WriteLine(c);
        }*/
        static void Main(string[] args)
        {
            long a = 2;
            WriteNumber(a);
        }
    }
}