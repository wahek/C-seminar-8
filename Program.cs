// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int row = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов");
// int column = int.Parse(Console.ReadLine()!);
// int[,] array0 = GetArray(row, column, 1, 9);
// PrintArray(array0);
// Console.WriteLine();
// int [,] sortedArray = SortedMaxMinArray(array0);
// PrintArray(array0);

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

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] array1 = GetArray(6, 4, 0, 9);
// PrintArray(array1);
// Console.WriteLine();
// int stringIndex = MinStringSum(array1);
// Console.WriteLine($"Индекс минимальной суммы строки на программистском: {stringIndex}");
// Console.WriteLine($"На человеческом: {stringIndex - 1}");

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Console.WriteLine("Введите количество строк первой матрицы ");
// int row0 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов первой матрицы ");
// int col0 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество строк второй матрицы ");
// int row1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов второй матрицы ");
// int col1 = int.Parse(Console.ReadLine()!);
// if(col0!=row1){
// 	Console.WriteLine("Матрицы невозможно перемножить(Правила умножения матриц: количество столбцов первой матрицы = количество строк второй матрицы");
// }
// else
// {
//     int[,] matrix0 = GetArray(row0, col0, 1, 9);
//     int[,] matrix1 = GetArray(row1, col1, 1, 9);
//     PrintArray(matrix0);
// 	Console.WriteLine();
//     PrintArray(matrix1);
// 	Console.WriteLine();
// 	int[,] matrixsolv = MatrixSolution(matrix0, matrix1);
//     PrintArray(matrixsolv);
// }

// кароче я не знаю как рассмотреть общий случай, там выше описано, но я не понимаю что там не так
// int[,] matrix0 = GetArray(2, 2, 1, 9);
// int[,] matrix1 = GetArray(2, 2, 1, 9);
// PrintArray(matrix0);
// Console.WriteLine();
// PrintArray(matrix1);
// int[,] matrixSolution = MatrixSolved(matrix0, matrix1);
// Console.WriteLine();
// PrintArray(matrixSolution);

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] arrayCube = GetArray3x3(3, 3, 3);
// PrintArray3x3(arrayCube);

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] myArray = new int[4,4];
int i = 0;
int next = 1;
int j = 0;
for(; j < myArray.GetLength(1); j++){
    myArray[i,j] = next;
    next++;
}
while(i<myArray.GetLength(0)){
    j = myArray.GetLength(1)- 1;
    myArray[i,j] = next - 1;
    next++;
    i++;
}
j-=1;
while (j >= 0)
{
    i = myArray.GetLength(0) - 1;
    myArray[i, j] = next - 1;
    next++;
    j--;
}
i-=1;
while(i>0){
    j = 0;
    myArray[i,j] = next - 1;
    next++;
    i--;
}
i++;
j++;
next--;
myArray[i,j] = next;
next++;
j++;
myArray[i,j] = next;
next++;
i++;
myArray[i,j] = next;
next++;
j--;
myArray[i,j] = next;
next++;
PrintArray(myArray);
