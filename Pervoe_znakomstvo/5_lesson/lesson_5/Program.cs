/*string str = "Hello world!";

str = str + "!";
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.Substring(0, 5));

char a = 's'; //двойная кавычка строка одинарная символ
Console.WriteLine(a);
string b = null; //только строка может иметь null
Console.WriteLine(b);
string c = Console.ReadLine();
int c2 = int.Parse(c);// 
char n = '4';
int t = n + 16;
//Console.WriteLine(c2+1);
Console.WriteLine(n);
Console.WriteLine(t);
*/
/*методы которые мы вызываем из классов они статические, а те которые мы вызываем
из переменных они называются динамические*/
string doubleNumber = "894376,243643"; //запомни краб, в винде должна стоять ЗАПЯТАЯ
double number = Convert.ToDouble(doubleNumber); // Вася уверен, что ошибка где-то тут
Console.WriteLine(number + 1);