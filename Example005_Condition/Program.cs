﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "марина")
{
    Console.WriteLine("Ура, это Марина!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
