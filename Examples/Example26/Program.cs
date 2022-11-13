// Задача 58: 
//Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц._

//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
//public void WriteMat()
 //       
 // МЕтод ввести размерности матрицы
 // Метод проверки на совпадение количества столбцов первой матрицы 
 // количества строк второй матрицы. Если не совпадают- перемножить нельзя
 // поэтому сразу определяем количество строк во второй матрице чтоб совпало.
 // Метод генерирования матриц случ.числами (от 0 до 10)
 // Метод перемножения матриц
 // Метод вывод матриц на печать
 //          Решение
 // Предложение вести разеры матриц
 // Проверка на возможность перемножения
 // Вывод на печать сгенерированных матриц
 // Перемножение матриц
 // вывод результата

int EnterNumbArray(string Name) //ввод корректности целого числа
{
    int x1;
    Console.Write($"Введите число {Name} : ");
    if (!int.TryParse(Console.ReadLine(), out x1)) // проверка на корректность ввода
    {
        do
        {
            Console.WriteLine("неправильный ввод");
            Console.Write($"введите целое число {Name}: ");
        } while (!int.TryParse(Console.ReadLine(), out x1));
    }
    return x1;
}

double[,]  Array(int m,int n) //генерация массива 2-х мерного случайными числами
{
    double[,] inArray = new double[m, n];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(0, 100);
        }
    }
    return inArray;
}
      
         double[,]  umnMatriz(double[,] A, double[,] B)
        {
            double[,] resMass = new double[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    resMass[i, j]=0;
                    for (int k = 0; k < B.GetLength(0); k++)
                    {
                        resMass[i, j]+= A[i, k]*B[k, j];
                    }
                }
            }
            return resMass;
        }
   
   void PrintArray(double[,] inArray) // печать массива двухмерного
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,6:0}",inArray[i, j]));
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Задайте размер Матрицы1");
int M1 = EnterNumbArray("строк M1"); //строк всего
int N1 = EnterNumbArray("столбцов N1"); // столбцов всего
Console.WriteLine("Задайте размер Матрицы2");
Console.WriteLine($"Количество строк M2 : {N1}");
int M2 = N1; //строк всего
int N2 = EnterNumbArray("столбцов N2"); // столбцов всего

    double[,] a = Array(M1,N1); // матрица1
    double[,] b = Array(M2,N2); // матрица2

PrintArray(a);// печать массива
Console.WriteLine();
PrintArray(b);// печать массива
double[,] rezMatriz = umnMatriz(a, b);// матрица для результата умножения создали
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(rezMatriz);// печать массива
Console.WriteLine();
