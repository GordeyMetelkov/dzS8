// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
int rows = 4;
int columns = rows;
int[,] matrix = new int [rows, columns];
FillSpiral(matrix);
Print(matrix);
void FillSpiral (int [,] matrixB)
{
    int i = 0;
    int j = 0;
    int number = 1;
    int iStart = 0;
    int jStart = 0;
    int iFinish = rows-1;
    int jFinish = columns-1;
    while (iStart < iFinish && jStart < jFinish)
    {
        while (j <= jFinish)
        {
            matrixB[i,j] = number;
            number++;
            j++;
        }
        j--;
        i++;
        while (i <= iFinish)
        {
            matrixB[i, j] = number;
            number++;
            i++;
        }
        i--;
        j--;
        while (j >= jStart)
        {
            matrixB[i, j] = number;
            number++;    
            j--;
        }
        j++;
        i--;
        while (i>iStart)
        {
            matrixB[i, j] = number;
            number++;
            i--;
        }
        i++;
        j++;
        iStart++;
        jStart++;
        iFinish--;
        jFinish--;
    }
    if (rows%2==1) matrixB[i, j] = number;
}
void Print (int [,] matrixB)
{
    for (int k = 0; k < matrixB.GetLength(0); k++)
    {
        for (int t = 0; t < matrixB.GetLength(1); t++)
        {
            Console.Write(matrixB[k, t] + "\t");
        }
        Console.WriteLine();
    }
}