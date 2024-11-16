//Создание игры "Угадай число"
Random rand = new Random();
int number, lower, larger;
var trycount = 5;
int userInput;
number = rand.Next(0, 101);
lower = rand.Next(number-10,number);
larger = rand.Next(number +1, number + 10);
Console.WriteLine("Мы загадали число от 0 до 100, оно больше чем " + lower + ", но меньше чем " + larger);
Console.WriteLine("Что это за число?");
while (trycount-- > 0)
{
    Console.Write("Это число:");
    userInput = int.Parse(Console.ReadLine());
    if (userInput == number)
    {
        Console.WriteLine("Вы правы! Это было число - " + number + ".");
        break;
    }
    else
    {
        Console.WriteLine("Не верно, попробуйте еще раз.");
    }
    if (trycount == 0)
    {

        Console.WriteLine("К сожалению вы проиграли. Попробуйте еще раз, вдруг повезет! Это было число " + number);
    }
}