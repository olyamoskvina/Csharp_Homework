﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (N > 1)
{
    while (i < N)
    {
        Console.Write(i + " ");
        i += 2;
    }
}  
else
   {
     Console.Write("Введенное число меньше или равно 1");
   }
