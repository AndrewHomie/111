﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


int length = 10;
int[] array = new int[length];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < length; i++) 
{
    array[i] = rnd.Next(1, 10);
    if (array[i] % 2 != 0) 
    {
        sum += array[i];
        Console.WriteLine(array[i]);
    }
}
Console.WriteLine(sum);
