//Гладиаторские бои
Random rand = new Random();
float health1 = rand.Next(90, 100);
var damage1 = rand.Next(5, 20);
var armor1 = rand.Next(25, 65);
float health2 = rand.Next(70, 100);
var armor2 = rand.Next(65, 100);
var damage2 = rand.Next(20, 40);
Console.WriteLine($"Гладиатор 1: {health1} здоровья, {damage1} урона, {armor1} брони.");
Console.WriteLine($"Гладиатор 2: {health2} здоровья, {damage2} урона, {armor2} брони.");
while(health1 > 0 && health2 > 0)
{
    health1 -= Convert.ToSingle(rand.Next(0, damage2)) / 100 * armor1;
    health2 -= Convert.ToSingle(rand.Next(0, damage1)) / 100 * armor2;
    Console.WriteLine("Здоровье первого гладиатора: "+ health1);
    Console.WriteLine("Здоровье второго гладиатора: "+ health2);

    if (health1 <= 0 && health2 <=0)
    {
        Console.WriteLine("Ничья, обам погибли.");
        break;
    }
    else if (health1 <=0)
    {
        Console.WriteLine("Гладиатор под номером 1 пал смертью храбрых!");
        break;
    }
    else if (health2 <= 0)
    {
        Console.WriteLine("Гладиатор под номером 2 пал смертью храбрых!");
        break;
    }
    
}