﻿/*Задача:
Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
Это нужно чтобы любой разработчик взглянув на ваш код понял четкие границы вашего цикла.*/
var i = "";
while (i != "exit")
{
    Console.Write("Введите вашу команду:");
    i = Console.ReadLine();
    Console.WriteLine(i);
    if (i == "exit")
    {
        Console.WriteLine("Спасибо что воспользовались нашей программой.");
        
    }
    else Console.WriteLine("Попробуйте еще раз!");
}