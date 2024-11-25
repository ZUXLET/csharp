int[] tables = { 5, 4, 2, 1, 1, 4, 5, 6, 4, 8 };
var isOpen = true;
while (isOpen == true)
{
    Console.WriteLine("Добро пожаловать в кафе у помойки!");

    for (int i = 0; i < tables.Length; i++)
    {
        Console.WriteLine("За столом - " + (i + 1) + " свободно " + tables[i] + " мест.");
    }
    Console.Write("С чем пожаловали?\n1.Забронировать место\n2.Выйти из программы\nВыберете команду:");
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            int userTable = 0, userPlace = 0;
            Console.Write("За каким столом вы хотите забронировать место:");
            userTable = Convert.ToInt32(Console.ReadLine()) - 1;
            if (userTable < 0 || userTable > tables.Length - 1)
            {
                Console.WriteLine("Ты безнадежен! Выбери существующий стол АЛЕША!");
                break;
            }
            if (tables[userTable] == 0)
            {
                Console.WriteLine("Товарищ! Посмотри на количество мест у этого стола!");
                break;
            }
            Console.Write("Сколько мест вы хотите забронировать:");
            userPlace = Convert.ToInt32(Console.ReadLine());
            if (tables[userTable] < userPlace || userPlace <= 0)
            {
                Console.WriteLine("Ты ввести не правильный выбор, я ничего не делать.");
                break;
            }
            else tables[userTable] -= userPlace;

            break;
        case 2:
            isOpen = false;
            break;
        default:
            Console.WriteLine("Что ты вводишь кукумбер?? Выбери что-то из списка!");
            break;  
    }
    Console.ReadKey();
    Console.Clear();
}