//  Задача 64: 
// Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии._

//N = 5 -> "5, 4, 3, 2, 1"
//
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int EnterNumb( ) //ввод корректности целого числа
{
    int x1;
    Console.Write($"Введите натуральное число  : ");
    if (!int.TryParse(Console.ReadLine(), out x1)) // проверка на корректность ввода
    {
        do
        {
            Console.WriteLine("неправильный ввод");
            Console.Write($"введите натуральное число : ");
        } while (!int.TryParse(Console.ReadLine(), out x1));
    }
    return x1;
}


void NaturEnter(int n)
{
    if (n == 1) Console.Write("{0}", n);
    else
    {
        Console.Write("{0}, ", n);
        NaturEnter(n - 1);
    }
}

Console.Clear();
int name=EnterNumb( ); 
Console.Write($"N = {name} -> \"");
NaturEnter(name);
Console.Write("\"");

 
