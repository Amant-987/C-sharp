﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
for (int i=1; i < num + 1; i++)
{
    if(i!=num)
{
    Console.Write(Math.Pow(i,3)+" , ");
        }
    else
    {
        
    Console.Write(Math.Pow(i,3));
    }

}