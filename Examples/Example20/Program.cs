// Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем._
//
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 1. Метод: Предложить ввести пользователю для уравнения прямой коэфициенты
// 2. Метод: Проверка ввода чисел на корректность
// 3. Метод: Считаем координату х, формируем результат
// 4. Метод: Считаем координату Y, формируем результат
// 5. Метод печати на экран решения задачи
// 6. Метод вывод на экран текста

// Запускаем метод 1
// запускаем метод 2 
// запускаем метод 3 (выясняем пересекаются ли прямые)
// запускаем метод 4 (если при методе 3, есть пересечение прямых)
// Метод 6 вывод текста или
// метод 5 :Вывод результата "->" значение счетчика подсчета

void SetQuantity(string text) //1. Метод: Вывести текст о чем либо
{
    Console.Write(text);
}

double[,] GetArray(int m, int n) // создание двумерного массива
{
    double[,] result = new double[m, n];
    return result;
}


//void PrintArray(double[,] inArray) // печать массива двухмерного
//{
//    for (int i = 0; i < inArray.GetLength(0); i++)
//    {
//        for (int j = 0; j < inArray.GetLength(1); j++)
//        {
//            Console.Write($"{inArray[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}

double[,] EnterNumbArray(double[,] inArray, string[] Line) //3.Генерация массива через ввод в консоле
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       double x1;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"Введите {Line[j]}{i + 1} : ");
            if (!double.TryParse(Console.ReadLine(), out x1)) // проверка на корректность ввода
            {
                do
                {
                    Console.WriteLine("неправильный ввод");
                    Console.Write($"введите {Line[j]}{i + 1} : ");
                } while (!double.TryParse(Console.ReadLine(), out x1));
            }
            inArray[i, j] = x1;
        }
        
    }
   return inArray;
}

Console.Clear();
Console.WriteLine("Для нахождения точки пересечения двух прямых y=k1*x+b1 и y=k2*x+b2 ,");
Console.WriteLine("задайте коэффициенты k1, b1 и k2, b2");
string[] Line1 = { "k", "b" }; // название коэф.прямой

double[,] ArrayLine = GetArray(2, 2); // создали пустой массив

double[,] LinePow=EnterNumbArray(ArrayLine, Line1);// сгенирировали массив по вводу с консоли

//PrintArray(LinePow); для проверки 
if (LinePow[0,0] == LinePow[1,0])
{
    SetQuantity("Паралельные прямые не пересекаются!");
}
else
{
    double x= Math.Round((LinePow[1,1]-LinePow[0,1])/(LinePow[0,0]-LinePow[1,0]),2);
    double y = Math.Round(x*LinePow[0,0]+LinePow[0,1],2);
    //string textReturn=String.Empty;
     for (int i = 0; i < LinePow.GetLength(0); i++)
    {
        for (int j = LinePow.GetLength(1)-1 ; j >= 0 ; j--)
        {
          SetQuantity($"{Line1[j]}{i+1} = {LinePow[i,j]}, ");
        }
    }
     SetQuantity($" - > ({x} ; {y})");
}