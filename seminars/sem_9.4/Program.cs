﻿// // Задача 65: Задайте значения M и N
// // Напишите программу, которая выведет все натуральные числа
// // в промежутке от M до N.
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.Write("Enter number m: ");
// int m = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Enter number n: ");
// int n = Convert.ToInt32(Console.ReadLine()); 

// int min = m;
// int max = n;
// if(n < m) 
// {
//     min = n;
//     max = m;
// }
// int i = min;

// int RecForNatNumbersFrom(int max, int i)
// {
//     if(i == max)
//     {
//         Console.WriteLine(i);
//         return i;
//     }

//     Console.Write($"{i} ");

//     return RecForNatNumbersFrom(max, i + 1);
// }

// RecForNatNumbersFrom(max, i);



// // Through the lines
// // Console.Clear();

// // System.Console.WriteLine(ReturnNumber(PutNumber("Введите m : "),PutNumber("Введите n : ")));

// // int PutNumber(string message)
// // {
// //   System.Console.WriteLine(message);
// //   int number = Convert.ToInt32(Console.ReadLine());
// //   return number;
// // }

// // string ReturnNumber(int m, int n)
// // {
// //   if (m == n) return n + "";
// //   else
// //     return m + " " + ReturnNumber(m + 1, n);

// // }

// // Задача 67: Напишите программу, которая будет принимать на вход число
// // и возвращать сумму его цифр.
// // 453 -> 12
// // 45 -> 9

// Console.Write("Enter number to find sum of him digits: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int n = 0;
// int SumDigitsOfNumber(int number)
// {
//     if(number == 0)
//     {
//         return sum;
//     }

//     n = number % 10;
//     sum += n;
//     return SumDigitsOfNumber(number / 10);

// }

// sum = SumDigitsOfNumber(number);
// Console.WriteLine(sum);

// // Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// // и возводит число А в целую степень B с помощью рекурсии.
// // A = 3; B = 5 -> 243 (3⁵)
// // A = 2; B = 3 -> 8

// Console.Write("Enter number A: ");
// int a = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Enter number B: ");
// int b = Convert.ToInt32(Console.ReadLine()); 

// int RaisingNumberOfPower(int number, int power)
// {
//     if(power == 1) return number;
//     else if(power == 0) return 1;
    
//     power--;

//     return RaisingNumberOfPower(number + number, power);

// }

// a = RaisingNumberOfPower(a, b);
// Console.WriteLine(a);
