﻿// Задача 32: Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array1 = {-4, -8, 8, 2};
int[] arrayNew = new int[4];

for (int i = 0; i < array1.Length; i++)
{
    arrayNew[i] = array1[i] * -1;
    Console.WriteLine(arrayNew[i]);
}
