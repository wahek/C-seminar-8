// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int column = int.Parse(Console.ReadLine()!);
int[,] array0 = GetArray(row, column, 1, 9);
PrintArray(array0);
Console.WriteLine();
int [,] sortedArray = SortedMaxMinArray(array0);
PrintArray(array0);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
	return array;
}

void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
        	Console.WriteLine();
        }
	}

int[,] SortedMaxMinArray(int[,] arraySorted)
{
    for (int i = 0; i < arraySorted.GetLength(0); i++)
    {
        for (int j = 0; j < arraySorted.GetLength(1); j++)
        {
			for(int count = j + 1; count < arraySorted.GetLength(1); count++){
				if(arraySorted[i, j] < arraySorted[i, count]){
					int temp = arraySorted[i,j];
					arraySorted[i,j] = arraySorted[i, count];
					arraySorted[i, count]= temp;
				}
			}
        }
    }
	return arraySorted;
}

int MinStringSum(int[,] arraySum)
{
    int stringSumMin = 100;
    int index = 0;
    for (int i = 0; i < arraySum.GetLength(0); i++)
    {
        int stringSum = 0;
        for (int j = 0; j < arraySum.GetLength(1); j++)
        {
            stringSum += arraySum[i, j];
        }
        if (stringSum < stringSumMin)
        {
            stringSumMin = stringSum;
            index = i;
        }
    }
    return index;
}

int[,] MatrixSolution(int[,] mat0, int[,] mat1)
{
    int[,] solutionMatrix = new int[mat0.GetLength(0), mat1.GetLength(1)];
    for (int i = 0; i < solutionMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < solutionMatrix.GetLength(1); j++)
        {

            for (int count = 0; count < mat0.GetLength(0); count++)
            {
                solutionMatrix[i, j] += mat0[i, j + count] * mat1[i + count, j];
				Console.WriteLine(mat0[i, j + count]);
				Console.WriteLine($"{solutionMatrix[i, j]}");
            }
        }
    }
	return solutionMatrix;
}

int[,] MatrixSolved(int[,] mat0, int[,] mat1){
	int[,] matrixSol = new int[2, 2];
	matrixSol[0,0] = mat0[0, 0] * mat1[0,0] + mat0[0,1]*mat1[1,0];
	matrixSol[0,1] = mat0[0, 0] * mat1[0,1] + mat0[0,1]*mat1[1,1];
	matrixSol[1,0] = mat0[1, 0] * mat1[0,0] + mat0[1,1]*mat1[1,0];
	matrixSol[1,1] = mat0[1, 0] * mat1[0,1] + mat0[1,1]*mat1[1,1];
	return matrixSol;
}

int[,,] GetArray3x3(int x, int y, int z)
{
    int[,,] array3 = new int[x, y, z];
    int start = 10;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < y; k++)
            {
                array3[i, j, k] = start;
                start++;
            }
        }
    }
    return array3;
}

void PrintArray3x3(int[,,]array3x3){
    for (int i = 0; i < array3x3.GetLength(0); i++)
    {
        for (int j = 0; j < array3x3.GetLength(1); j++)
        {
            for (int k = 0; k < array3x3.GetLength(2); k++)
            {
                Console.Write($"{array3x3[i,j,k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}
