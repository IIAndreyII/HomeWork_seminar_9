// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine();
Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());


Console.Write($"Сумма натуральных элементов в промежутке от M до N = {Summ(num1,num2)} ");
Console.WriteLine();


int Summ (int n,int m)
{

    if(n<m)
    {
        n += Summ(n+1,m);
        return n; 
    }

    if(n>m)
    {
        n += Summ(n-1,m);
        return n;
    }
    return n;
}

