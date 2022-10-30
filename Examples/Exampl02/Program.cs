int num1=44, num2=5, num3=78;
Console.WriteLine("Из трех чисел: ", num1+" , "+num2+" , "+num3+" найти максимальное");
int max=num1;
if (max < num2)
{
    max=num2;
}
if (max < num3)
{
    max=num3;
}
Console.WriteLine(num1+" , "+num2+" , "+num3+" -> "+max);
