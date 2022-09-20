// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());


string NumRange (int n,int m)
{
    if (n == m) return Convert.ToString(n);
    if (n > m) return n + " " + NumRange(n - 1, m);
    else return n + " " + NumRange(n + 1, m);
}

Console.WriteLine();
Console.WriteLine(NumRange(num1,num2));


