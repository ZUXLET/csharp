/*Задача:
При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды. Т.е. вы создаете меню, ожидаете ввода нужной команды, 
после чего выполняете действие, которое присвоено этой команде.

Примеры команд (Требуется 4-6 команд, придумать самим)

SetName – установить имя

ChangeConsoleColor- изменить цвет консоли

SetPassword – установить пароль

WriteName – вывести имя (после ввода пароля)

Esc – выход из программы

Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды.*/
//Изначально планировал работу с листами, но я пока их плохо знаю. поэтому задание выполнено чисто символически. Просто показал что могу работать с "меню". Потом переделаю
string name = "";
string sex = "";
int age = 0;
string job = "";
int stag = 0;
var isOpen = true;
while (isOpen == true)
{
    Console.WriteLine("Что вы хотите сделать:\n1.Внести новые данные\n2.Изменить старые данные\n3.Удалить старые данные\n4.Вывести все данные" +
        "\n5.Закончить работу");
    var choise = int.Parse(Console.ReadLine());
    switch (choise)
    {
        case 1:
            Console.Write("Как тебя зовут:");
            name = Console.ReadLine();
            Console.Write("Какой у тебя пол:");
            sex = Console.ReadLine();
            Console.Write("Сколько тебе лет:");
            age = int.Parse(Console.ReadLine());
            Console.Write("Кто ты по профессии:");
            job = Console.ReadLine();
            Console.Write("Какой у тебя стаж:");
            stag = int.Parse(Console.ReadLine());
            break;
        case 2:
            Console.Write("Как тебя зовут:");
            name = Console.ReadLine();
            Console.Write("Какой у тебя пол:");
            sex = Console.ReadLine();
            Console.Write("Сколько тебе лет:");
            age = int.Parse(Console.ReadLine());
            Console.Write("Кто ты по профессии:");
            job = Console.ReadLine();
            Console.Write("Какой у тебя стаж:");
            stag = int.Parse(Console.ReadLine());
            break;
        case 3:
            
            name = "";
            sex = "";
            age = 0;
            job = "";
            stag = 0;
            break;
        case 4:
            Console.WriteLine($"Ваше имя {name}, ваш пол {sex}, ваш возраст {age}, ваша профессия {job}, ваш стаж {stag}.");
            break;
        case 5:
            isOpen = false;
            break;
    }

}