/*Задача:
Вывести имя в прямоугольник из символа, которые введет сам пользователь.

Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.

Пример:

Alexey

%

%%%%%%
% Alexey %
%%%%%%

Примечание:

Длину строки можно всегда узнать через свойство Length

string someString = “Hello”;

Console.WriteLine(someString.Length); //5*/
string name;
Console.Write("Как вас зовут:");
name = Console.ReadLine();
Console.Write("Выбери символ:");
char a;
a = Convert.ToChar(Console.ReadLine());
int lonng = name.Length;

int y = lonng + 2;
for (int i = 0;i<lonng+1; i++)
{
    if (i == lonng)
    {
        for (int k = 0; k < lonng + 2; k++)
        {
            Console.Write(a);
        }
    }
    
    if (i == lonng)
    {
        Console.WriteLine("\n"+ a + name + a);
        if (i == lonng)
        {
            for (int j = 0; j < lonng+2; j++)
            {
                Console.Write(a);
            }
        }
    }
    
    
}

