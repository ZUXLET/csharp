/*int a = 1;
int b = 2;
int c = (a + b) * 2;
Console.WriteLine(c);*/
/*int a = 2;
int b = 3;
int c = b % a; //операция остатка, показывает 
//сколько останеться после деления если ответ без запятой
Console.WriteLine(c);*/
/*int a = 2;
int b = 3;
int c = b / a; 
double d = (double)b / a;

Console.WriteLine(c);
Console.WriteLine(d);*/
/*double angle = 3.14159;

Console.WriteLine(Math.Sin(angle));
Console.WriteLine(Math.Pow(2,3 ));*/
/*int a = 2;
int b = 4;
var c = a * b;
Console.WriteLine(c);
var d = c.ToString();
Console.WriteLine(d);*/
/*var a = 2;
var b = 4;
var c = 6;
Console.WriteLine(b = c);
a= b= c;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);*/
/*
var a = 2;
var b = 4;
var c = 6;
var d = 6;
a += 2;
b *= 3;
c /= 2;
d ++;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
*/
/*
С прибавлением единицы все оказалось просто. Казалось бы прибавление к числу 
половинки должно быть не сложнее...

Подумайте, как так получилось, что казалось бы корректная программа не работает. 
Исправьте первую строчку программы так, чтобы она компилировалась и выводила на 
консоль ожидаемый ответ — 5.5.
static public void Main()
{
    var a = 5; // ← исправьте эту строку
    a += 0.5;
    Console.WriteLine(a);
}
*/

    var a = 5.00; // ← исправьте эту строку
    a += 0.5;
    Console.WriteLine(a);
