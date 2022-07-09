// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [rows, columns];
FillArray(matrix);
PrintArray(matrix);
Selection(matrix);
PrintArray(matrix);
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
void Selection (int[,] currentArray)
{
    int temp = 0;
    for (int i = 0; i < currentArray.GetLength(0)-1; i++)
    {     
        for (int j = 0; j < currentArray.GetLength(1)-1; j++)
            {
                for (int k = j+1; k < currentArray.GetLength(1); k++)
                {               
                    if (currentArray[i, k] > currentArray[i, j])
                    {
                        temp = currentArray[i, k];
                        currentArray[i, k] = currentArray[i, j];
                        currentArray[i, j] = temp;
                    }
                }
            }
    }
}