// Seminar 09

/*
**Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

/*
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(M, N));
string PrintNumbers(int start, int end){
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}
*/

/*
**Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

/*
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(N));
int PrintNumbers(int N){
    if(N == 0) return (0);
    return (N % 10 + PrintNumbers(N / 10));
}
*/

/*
**Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

/*
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (N == 0){
    Console.WriteLine("1");
}
else{
    Console.WriteLine(PrintNumbers(M, N));
}
int PrintNumbers(int M, int N){
    if (N == 0) return 1;
    return (PrintNumbers(M, N - 1) * M);
}
*/

// HOME WORK

/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
Console.Clear();

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(N));
string PrintNumbers(int start){
    if(start <= 1) return start.ToString();
    Console.Write ($"{start} , ");
    return (PrintNumbers(start - 1));
    
}

*/

/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
Console.Clear();
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

void PrintSum(int m, int n, int sum)
 
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}

int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"{m}, {n} ->");
PrintSum(m, n, temp = 0);

*/