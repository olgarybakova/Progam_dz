﻿//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//
//6 -> да
//7 -> да
//1 -> нет 
// 1.Вводим число
// 2. проверяем на корректность ( от 1 до 7, столько дней недели) и 
// предлагаем вводить, пока не будет корректный ввод дня недели.
// 3.проверяем на выходной день : или 6 или 7
// 4. выводим на печать

bool flag = false; // для проверки корректности ввода числа дня недели

while (flag == false) // пока не будет введено число в соответствии дня недели
{
    Console.WriteLine("Введите день недели: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 0 & N < 8)
    {
        if (N==6 | N==7)
        {
            Console.Write($"{N}-> да");
            flag = true;
        } 
        else
        {
            Console.Write($"{N}-> нет"); 
            flag = true; 
        }
    }
    else
    {
     Console.WriteLine($"{N}-> Не корректное число ввода");   
    }
}