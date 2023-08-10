/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.

class Math
{
       static void Sort(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            int[] rowArray = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                rowArray[j] = arr[i, j];
            }
            Array.Sort(rowArray, (x, y) => y.CompareTo(x));
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = rowArray[j];
            }
        }
    }
    static void Main()
    {
    Console.Write("Input amount of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input amount of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
        int[,] arr = new int[rows, cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = random.Next(1, 10);
            }
        }
        Console.WriteLine("Primary massive:");
        Show2dArray(arr);
        Sort(arr);
        Console.WriteLine("New massive:");
        Show2dArray(arr);
        Console.WriteLine();
    }
    static void Show2dArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/



// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// class Test
// {
//     static int[,] CreateMyArray(int rows, int columns, int minVal, int maxVal)
//     {
//         int[,] array = new int[rows, columns];
//         Random random = new Random();
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 array[i, j] = random.Next(minVal, maxVal + 1);
//             }
//         }
//         return array;
//     }
//     static int[,] finalArray(int[,] array, int[,] newarray)
//     {
//         int rows1 = array.GetLength(0);
//         int columns1 = array.GetLength(1);
//         int rows2 = newarray.GetLength(0);
//         int columns2 = newarray.GetLength(1);
//         int[,] result = new int[rows1, columns2];
//         for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < columns2; j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < columns1; k++)
//                 {
//                     sum += array[i, k] * newarray[k, j];
//                 }
//                 result[i, j] = sum;
//             }
//         }
//         return result;
//     }
//     static void ShowArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите параметры 1 массива:");
//         Console.WriteLine("Число строк:");
//         int rows1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Число столбцов:");
//         int columns1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Минимальное значение:");
//         int minVal1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Максимальное значение:");
//         int maxVal1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine();

//         int[,] firstArray = CreateMyArray(rows1, columns1, minVal1, maxVal1);
//         ShowArray(firstArray);
//         Console.WriteLine();

//         Console.WriteLine("Введите параметры 2 массива:");
//         Console.WriteLine("Число строк:");
//         int rows2 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Число столбцов:");
//         int columns2 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Минимальное значение:");
//         int minVal2 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Максимальное значение:");
//         int maxVal2 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine();
//         int[,] secondArray = CreateMyArray(rows2, columns2, minVal2, maxVal2);
//         ShowArray(secondArray);
//         Console.WriteLine();

//         int[,] final = finalArray(firstArray, secondArray);
//         Console.WriteLine("Перемноженная матрица: ");
//         Console.WriteLine();
//         ShowArray(final);
//         Console.WriteLine();
                  
//     }
// }
