﻿
string[,] table = new string[3, 5];
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}






void PrintArray(int[,] matrix)
{

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

void FillArray(int[,]matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j] =  new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);





int Factorial (int n)
{
    if (n == 1) return 1;
    else  return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));




int Fibonacci (int n)
{
    if (n == 1 || n==2) return 1;
    else  return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
{
Console.WriteLine($"f{i} = {Fibonacci(i)}");
}