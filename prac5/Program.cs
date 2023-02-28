





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
int[,] matrix = new int[10, 10];
void FillArray2(int[,]matrix2)
{
    for(int i = 0; i < matrix2.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
           matrix2[i,j] =  new Random().Next(1, 10);
        }
    }
}
int[,] matrix2 = new int[10, 10];
void PrintArray2(int[,] matrix2)
{

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        Console.Write($"{matrix2[i, j]} ");
    }
    Console.WriteLine();
}
}


FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArray2(matrix2);
PrintArray2(matrix2);