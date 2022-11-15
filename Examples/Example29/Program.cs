// Задача 66: 
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N._

//M = 1; N = 15 -> 120

//M = 4; N = 8. -> 30

//1. Вводим Натуральное число
//2. Метод рекурсии
// 
// Предлагаем вести число М,N
// с заданными числами вычисляем сумму от М до N.  
// Красивая печать.

int EnterNumb(string Name ) //ввод корректности целого числа
{
    int x1;
    Console.Write($"Введите натуральное число {Name} : ");
    if (!int.TryParse(Console.ReadLine(), out x1)) // проверка на корректность ввода
    {
        do
        {
            Console.WriteLine("неправильный ввод");
            Console.Write($"введите натуральное число {Name}: ");
        } while (!int.TryParse(Console.ReadLine(), out x1));
    }
    return x1;
}


int RekurSum(int n,int m)
{
    if (n > m)
    {
      return n + RekurSum(n - 1, m);
    }
    return n;
}
 
Console.Clear();
int name1=EnterNumb("M "); 
int name2=EnterNumb("N "); 
int Cout=RekurSum(name2, name1);
  
Console.Write($" M = {name1}; N = {name2} -> {Cout}");

