//Задача 68: 
//Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n._
//
//m = 2, n = 3 -> A(m,n) = 9
//
//m = 3, n = 2 -> A(m,n) = 29

//функции Аккермана
// A(m,n)= n+1, ecли m=0;
// A(m,n)= A(m-1,1), ecли m>0, n=0;
// A(m,n)= A(m-1,A(m, n-1)), ecли m>0, n>0;

//1. Вводим Натуральное число
//2. Метод рекурсии функции Аккермана (m,n)
// 
// Предлагаем вести число m,n
// с заданными числами вычисляем функцию Атермана (m,n)  
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


 int Akkerman(int m, int n)
{
    if (m==0)
        return n+1;
    if (m!=0 && n==0)
        return Akkerman(m-1,1);
    if (m>0 && n>0)
        return Akkerman(m-1,Akkerman(m,n-1));
    return -1;
}

Console.Clear();
int M1=EnterNumb("m "); 
int N1=EnterNumb("n "); 
//nt M1=3;
//int N1=2;
int Cout=Akkerman(M1, N1);
Console.Write($" m = {M1}; n = {N1} -> A(m,n) = {Cout}");