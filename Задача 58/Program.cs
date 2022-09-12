// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
void FillMatrixRndNum(int[,] Matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = rnd.Next(1, 5); 
        }
    }
}
void PrintMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write(Matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
int size = InputInt("Введите размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillMatrixRndNum(matrixA);
FillMatrixRndNum(matrixB);
int[,] matrixC = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А:");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В:");
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В:");
PrintMatrix(matrixC);