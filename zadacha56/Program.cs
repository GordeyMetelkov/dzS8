// 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows == columns) Console.WriteLine("Введите неравное количество строк и столбцов");
else
{
    int [,] matrix = new int [rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    BiggerSumRow(matrix, rows);
    void FillArray (int[,] currentArray)
    {
        Random rand = new Random();
        for (int i = 0; i < currentArray.GetLength(0); i++)
        {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
                currentArray[i, j] = rand.Next(0, 11);
            }
        }
    }
    void PrintArray (int[,] currentArray)
    {
        Console.WriteLine();
        for (int i = 0; i < currentArray.GetLength(0); i++)
        {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
                Console.Write(currentArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    void BiggerSumRow(int[,] currentArray, int currentRows)
    {       
        int [] massivSum = new int [currentRows]; 
        int sum = 0;    
        for (int i = 0; i < currentArray.GetLength(0); i++)
        {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
                sum += currentArray[i, j];
            }
            massivSum[i] = sum;
            sum = 0;
        }
        int minSum = massivSum[0];
        int minSumIndex = 0;
        for (int i = 0; i < massivSum.Length; i++)
        {
            if (massivSum[i] < minSum)
            {
                minSum = massivSum[i];
                minSumIndex = i;
            }
        }
        Console.WriteLine($"Строка с наименьшей суммой элементов - {minSumIndex+1}, сумма элементов - {minSum}");
    }
}