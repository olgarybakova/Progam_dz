Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
string raz = " -> ";
int index = 1;
Console.Write(N);
while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.Write(raz + index);
        raz = ", ";
    }
    index = index + 1;
}
