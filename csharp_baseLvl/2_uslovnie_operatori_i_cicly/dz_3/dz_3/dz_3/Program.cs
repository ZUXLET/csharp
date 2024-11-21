/*Задача:
Написать конвертер валют (3 валюты).

У пользователя есть баланс в каждой из представленных валют. Он может попросить сконвертировать часть баланса в одной валюты в другую. 
Тогда у него с баланса одной валюты снимет X и зачислится на баланс другой Y. Курс конвертации должен быть просто прописан в программе.

Программа должна завершиться тогда, когда это решит пользователь.*/
var rubUSD = 0.0099;
var usdRUB = 100.00;
var rubYEN = 0.65;
var yenRUB = 1.54;
var usdYEN = 0.0064;
var yenUSD = 155.29;
Console.Write("Сколько у вас рублей на счете:");
var rubHave = Convert.ToDouble(Console.ReadLine());
Console.Write("Сколько у вас долларов на счете:");
var usdHave = Convert.ToDouble(Console.ReadLine());
Console.Write("Сколько у вас йен на счете:");
var yenHave = Convert.ToDouble(Console.ReadLine());
var okey = 0;
var itsOpen = true;
while (itsOpen == true)
{

    Console.WriteLine("Выберете что хотите сделать:\n1.Пополнить баланс\n2.Совершить обмен валюты\n3.Узнать баланс\n4.Я все сделал");
    var vhod = int.Parse(Console.ReadLine());
        switch (vhod)
    {
        case 1:
            Console.Write("Вложите рубли:");
            rubHave += Convert.ToDouble(Console.ReadLine());
            Console.Write("Вложите доллары:");
            usdHave += Convert.ToDouble(Console.ReadLine());
            Console.Write("Вложите йены:");
            yenHave += Convert.ToDouble(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("Что вы хотите конвертировать:\n1.Рубли\n2.Доллары\n3.Йены");
            var convVALUTE = int.Parse(Console.ReadLine());
            Console.WriteLine("В какую валюту вы хотите конвретировать: \n1.Рубли\n2.Доллары\n3.Йены");
            var toCONVERT = int.Parse(Console.ReadLine());
            Console.Write("Сколько вы хотите сконвертировать:");
            var countCONV = Convert.ToDouble(Console.ReadLine());
            switch (convVALUTE)
            {
                case 1:
                    switch (toCONVERT)
                    {
                        case 1:
                            Console.WriteLine($"Вы хотите конвертировать рубли в рубли. Комисия составит 10%. На вашем счету будет " +
                                $"{rubHave - (countCONV * 1.1)} рублей. Подтверждаете перевод: 1.да 2.нет \n");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                rubHave -= countCONV * 1.1;
                            }
                            Console.WriteLine("Попробуйте еще раз!");
                            break;
                        case 2:
                            Console.WriteLine($"Вы хотите конвертировать рубли в доллары. Комисия составит 10%. На вашем счету будет " +
                                $"{rubHave - countCONV} рублей и {usdHave + countCONV * rubUSD * 0.9} долларов. Подтверждаете перевод: 1.да 2.нет");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                rubHave -= countCONV;
                                usdHave += countCONV * rubUSD * 0.9;
                            }
                            else
                                Console.WriteLine("Попробуйте еще раз!");
                            break;
                        case 3:
                            Console.WriteLine($"Вы хотите конвертировать рубли в йены. Комисия составит 10%. На вашем счету будет " +
                                $"{rubHave - countCONV} рублей и {usdHave + countCONV * rubUSD * 0.9} йен. Подтверждаете перевод: 1.да 2.нет");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                rubHave -= countCONV;
                                yenHave += countCONV * rubYEN * 0.9;
                            }
                            else
                                Console.WriteLine("Попробуйте еще раз!");
                            break;
                    }
                    break;
                case 2:
                    switch (toCONVERT)
                    {
                        case 2:
                            Console.WriteLine($"Вы хотите конвертировать доллары в рубли. Комисия составит 10%. На вашем счету будет " +
                                $"{usdHave - countCONV} долларов и {rubHave + countCONV * usdRUB * 0.9}. Подтверждаете перевод: 1.да 2.нет");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                usdHave -= countCONV;
                                rubHave += countCONV * usdRUB * 0.9;
                            }
                            Console.WriteLine("Попробуйте еще раз!");
                            continue;
                        case 1:
                            Console.Write($"Вы хотите конвертировать доллары в доллары. Комисия составит 10%. На вашем счету будет " +
                                $"{usdHave - countCONV * 1.1} долларов. Подтверждаете перевод: 1.да 2.нет");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                usdHave -= countCONV * 1.1;

                            }
                            else
                                Console.WriteLine("Попробуйте еще раз!");
                            continue;
                        case 3:
                            Console.WriteLine($"Вы хотите конвертировать доллары в йены. Комисия составит 10%. На вашем счету будет " +
                                $"{usdHave - countCONV} долларов и {yenHave + countCONV * usdYEN * 0,9} йен. Подтверждаете перевод: 1.да 2.нет");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                usdHave -= countCONV;
                                yenHave += countCONV * usdYEN * 0.9;
                            }
                            else
                                Console.WriteLine("Попробуйте еще раз!");
                            break;
                    }
                    break;
                case 3:
                    switch (toCONVERT)
                    {
                        case 2:
                            Console.WriteLine($"Вы хотите конвертировать йены в рубли. Комисия составит 10%. На вашем счету будет {usdHave - countCONV * 1.1} йен и {rubHave + countCONV * yenRUB * 0.9}. Подтверждаете перевод: 1.да 2.нет");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                yenHave -= countCONV;
                                rubHave += countCONV * yenRUB * 0.9;
                            }
                            Console.WriteLine("Попробуйте еще раз!");
                            continue;
                        case 1:
                            Console.Write($"Вы хотите конвертировать йены в доллары. Комисия составит 10%. На вашем счету будет {usdHave - countCONV * 1.1} йен и {rubHave + countCONV * usdRUB * 0,9} долларов. Подтверждаете перевод: 1.да 2.нет");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                usdHave -= countCONV;
                                yenHave += countCONV * yenUSD * 0.9;
                            }
                            else
                                Console.WriteLine("Попробуйте еще раз!");
                            continue;
                        case 3:
                            Console.WriteLine($"Вы хотите конвертировать йены в йены. Комисия составит 10%. На вашем счету будет {usdHave - countCONV * 1.1} йен. Подтверждаете перевод: 1.да 2.нет");
                            okey = int.Parse(Console.ReadLine());
                            if (okey == 1)
                            {
                                yenHave -= countCONV * 1.1;

                            }
                            else
                                Console.WriteLine("Попробуйте еще раз!");
                            break;
                    }
                    break;
            } 
            break;   
        case 3:
            Console.WriteLine($"У вас на счету:\n{rubHave} рублей\n{usdHave} долларов\n{yenHave} йен");
            break;
        case 4:
            itsOpen = false;
            break;
    }

    }



