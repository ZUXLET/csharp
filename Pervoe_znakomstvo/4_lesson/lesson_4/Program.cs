﻿    double amount = 1.11; //количество биткоинов от одного человека
    int peopleCount = 60; // количество человек
    int totalMoney = (int)Math.Round(amount*peopleCount); // ← исправьте ошибку в этой строке
    Console.WriteLine(totalMoney);

    /*
    Вася регулярно получает за красивые глазки от кого-нибудь по amount биткоинов.

Вася хочет знать, сколько биткоинов у него уже накопилось. А чтобы не мелочиться, хочет округлить сумму до ближайшего целого.

Он написал для этого программу, но что-то с ней не так... Помогите ему исправить все ошибки.
public static void Main()
{
    double amount = 1.11; //количество биткоинов от одного человека
    int peopleCount = 60; // количество человек
    int totalMoney = (int) amount*peopleCount; // ← исправьте ошибку в этой строке
    Console.WriteLine(totalMoney);
}
*/