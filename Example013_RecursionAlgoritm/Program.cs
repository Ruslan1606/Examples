// string[,] table = new string[2, 5]; //Начало двумерного массива
// //String.Empty  константа для строк по умолчанию
// //table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] обозначение индексов столбцов
// //table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] обозначение индексов строк


// // table[1, 2] = "слово";

// // for (int rows = 0; rows < 2; rows++)
// // {
// //     for (int columns = 0; columns < 5; columns++)
// //     {
// //         Console.WriteLine($"-{table[rows, columns]}-");
// //     }
// // }



// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)                             //Задаем случайные числа этим методом
// {
//     for (int i = 0; i < matr.GetLength(0); i++)  // Возвращает количество строк в массиве
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // Возвращает количество столбцов в массиве
//         {
//             matr[i, j] = new Random().Next(1, 10);      
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

//_____________________________________________________________
//Для закрашивания  выделенной области 

// int[,] pic = new int[23, 24];

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//            // Console.Write($"{image[i, j]} ");
//            if(image[i,j] == 0)  Console.Write($" ");
//            else Console.Write($"+");

//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13); // Задает первую точку для закрашивания
// PrintImage(pic);

//__________________________________________________________________________________________________

//Факториал числа!

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

//__________________________________________________________________________________________________

//Рекурсия Фибоначи.

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"({i}) = {Fibonacci(i)}");
}

