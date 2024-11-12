/*namespace lesson_7
{
    class Program
    {
        /*public static int DivideAndRound(double a, double b)
        {
            ///
            var c = a / b;
            var d = (int)Math.Round(c);
            return d;
            //return (int)math.round(a/b);
        }
        public static void WriteNumber(int a) // не возвращает ничего
        {
            Console.WriteLine("a is int");
            Console.WriteLine(a);
        }
        //методы могут быть с одинаковым названием но с разными входными данными
        //есть неявная конверсия в double но обратно нет
        public static void WriteNumber(double a)
        {
            Console.WriteLine("a is double");
            Console.WriteLine(a);
        }
        public static void WriteNumber(float a)
        {
            Console.WriteLine("a is float");
            Console.WriteLine(a);
        }
        /*static void Main(string[] args)
        {
            var c = DivideAndRound(2, 3);
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            int  a = 2;
            WriteNumber(a);
        } */
public static void Main()    
{
	Console.WriteLine(GetGreetingMessage("Student", 10.01));
	Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
	Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
}
private static string GetGreetingMessage(string name, double salary)
{
    // возвращает "Hello, <name>, your salary is <salary>"
    return "Hello, " + name + ", your salary is " + Math.Ceiling(salary);
}
    
    
    //}

//}
/*Вася до завтра должен написать важную подпрограмму для Доброго Работодателя. Оставалось дописать всего один метод, когда Вася от переутомления крепчайше заснул.

Напишите метод, который принимает на вход имя и зарплату и возвращает строку вида: Hello, <Name>, your salary is <Salary>.

Но так как Работодатель Добр, он всегда округляет зарплату до ближайшего целого числа вверх.

Во многих редакторах и IDE сочетание клавиш Ctrl + Space показывает контекстную подсказку. Тут подсказки также работают, однако внутри Visual Studio они гораздо полнее и удобнее.

public static void Main()
{
	Console.WriteLine(GetGreetingMessage("Student", 10.01));
	Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
	Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
}
1
public static void Main()
2
{
3
    Console.WriteLine(GetGreetingMessage("Student", 10.01));
4
    Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
5
    Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
6
}

08 ноября 2024 в 13:40
public static void Main()
{
	Console.WriteLine(GetGreetingMessage("Student", 10.01));
	Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
	Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
}
private static string GetGreetingMessage(string name, double salary)
{
    // возвращает "Hello, <name>, your salary is <salary>"
    }
*/