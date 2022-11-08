//Задача 25: 
//_Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B._

//3, 5 -> 243 (3⁵)
//
//2, 4 -> 16

//без использования math.pow
double pow(int A, int B)
{
    if (A == 0 && B == 0) return double.NaN;
    bool flag = B>0;
    if (B < 0)  B = -B;
    int res = 1;
    for (int i = 0; i < B; i++)  res = res * A;
      if (flag) return res;
    else return 1.0 / res;
}

Console.WriteLine("Введите первое целое  число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число, степень в которую возвести первое число");
int num2 = Convert.ToInt32(Console.ReadLine());

double Power = pow(num1, num2);
Console.Write($"{num1} в степени {num2} -> {Power}");