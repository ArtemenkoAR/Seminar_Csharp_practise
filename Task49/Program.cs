// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }
// int[,] array1 = GetArray(3,4,0,10)

// int[,] Kvadrat(int[] array)
// {
//     int[,] result = new int[m1, n1];
//     for (int i = 0; i < m1 && i/2==0; i++)
//     {
//         for (int j = 0; j < n1 && j/2==0; j++)
//         {
//             result[i, j] = (i + j) * (i + j);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows,columns, 0, 10);
// PrintArray(array);
// int[,] array2 = Kvadrat(array);
// Kvadrat(array);

// int [,] GetArray1( int m, int n, int minValue, int maxValue)
// {
//     int[,] result=new int[m,n];
//     for(int i=0; i<m; i++)
//     {
//         for(int j=0; j<n; j++)
//         {
//             result[i,j]= new Random().Next(minValue,maxValue);
//         }
//     }
//     return result;
// }

// int [,] GetArray2( int [,]array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//         {
//             if(j%2==0 && i%2==0)
//             {
//             array[i,j]=array[i,j]*array[i,j];
//             }
//         }
//     }
//     return array;
// }



// void PrintArray(int[,] inArray)
// {
//     for(int i=0; i<inArray.GetLength(0); i++)
//     {
//         for(int j=0; j<inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]}  ");
            
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array1= GetArray1(3,4,0,10);
// PrintArray(array1);
// Console.WriteLine();
// GetArray2(array1);
// PrintArray(array1);

int [,] GetArray1( int m, int n, int minValue, int maxValue)
{
    int[,] result=new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]= new Random().Next(minValue,maxValue);
        }
    }
    return result;
}

int [,] GetArray2( int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(j%2==0 && i%2==0)
            {
            array[i,j]=array[i,j]*array[i,j];
            }
        }
    }
    return array;
}



void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}  ");
            
        }
        Console.WriteLine();
    }
}

int[,] array1= GetArray1(3,4,0,10);
PrintArray(array1);
Console.WriteLine();
GetArray2(array1);
PrintArray(array1);
