class Lesson_8
{
    static void Main()
    {
	    Print(GetSquare(42));
    }
    static int GetSquare(int a)
    {
        return (int)Math.Pow(a, 2);
    }	
    static void Print(int a)
    {
	    Console.WriteLine(a);
    }

}





/*Многие знают, что ответ на главный вопрос жизни, вселенной и всего такого — 42. Но Вася хочет большего! Он желает знать квадрат этого числа!

Вы разделили с Васей работу — он написал главный метод Main, а вам осталось лишь дописать методы Print и GetSquare.

Создайте два метода Print и GetSquare, так, чтобы код снизу заработал. Если забыли синтаксис определения методов — подсмотрите в видеолекции или в предыдущие задачи.

public static void Main()
{
	Print(GetSquare(42));
}
1
public static void Main()
