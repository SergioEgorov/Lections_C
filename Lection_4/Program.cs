// Задача. Закрашиваем область

// int[,] pic = new int[,];

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength; i++)
//     {
//         for (int j = 0; j < image.GetLength; j++)
//         {
//             if (image[i, j] == 0) Console.Write($"");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }

// }

// void FillImage(int row, int col)
// {
//     if (pic[row, col == 0])
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);

//     }

// }
// PrintImage(pic);
// FillImage(13,13);
// PrintImage(pic);


// Задача. Рекурсия(Вычислить Факториал)
// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Задача. Фибоначчи
// f(1) = 1
// f(2) = 2
// f(n) = f(n-1) + f(n-2)

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci (n-2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }

