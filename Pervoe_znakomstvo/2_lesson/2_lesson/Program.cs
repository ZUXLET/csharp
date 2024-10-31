/*смена типа данных может идти без явного указания типа данных 
если нет потери части информации*/
int a;
a = 45;
Console.WriteLine(a);
double b = 34.56; // число с запятой
long c = 2000000000000000000; //очень большое число
float d = 34.56f; //редко используемый тип данных с высокой точностью
//b = a;
Console.WriteLine(b);
a = (int)Math.Round(b); //смена типа данных в целое число
Console.WriteLine(a);
float e = (float)b; //смена типа данных
Console.WriteLine(e);