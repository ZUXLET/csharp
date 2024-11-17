/*Задача:
При помощи циклов вы можете повторять один и тот же код множество раз.
Напишите простейшую программу которая выводит заданное пользователем сообщение заданное пользователем количество раз.*/
var messege = "";
var count = 0;
Console.Write("Введите сообщение:");
messege = Console.ReadLine();
Console.Write("Сколько раз его вывести:");
count = int.Parse(Console.ReadLine());
while (count-- > 0)
{
    Console.WriteLine(messege);       
}