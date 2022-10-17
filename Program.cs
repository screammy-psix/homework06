//Задача 47.Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
void Zadanie47()
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    double[,] arr = new double[m, n];
    FillArrayDoubleTwoArr(arr);
    PrintArrayDoubleTwoArr(arr);
}

void FillArrayDoubleTwoArr(double[,] num)  
{
    Random random = new Random();
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = random.NextDouble() * 200 - 100;
            num[i, j] = Math.Round(num[i, j], 1);
        }
    }

}

void PrintArrayDoubleTwoArr(double[,] num)  
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void Zadanie50()
{
    Random random = new Random();
    
    int m = random.Next(2,10);
    int n = random.Next(2,10);
    int[,] arr = new int[m, n];
    FillArray(arr);
    PrintArray(arr);
    FindingElement(arr);
}
void FillArray(int[,] num, 
                int minValue = 0, 
                int maxValue = 100)  
{
    maxValue++;
    Random random = new Random();
        for (int i = 0; i < num.GetLength(0); i++)
        {
            for (int j = 0; j < num.GetLength(1); j++)
            {
                num[i, j] = random.Next(minValue, maxValue);
            }
        }
}
void PrintArray(int[,] num) 
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindingElement(int[,] arr)
{
    Console.WriteLine("Введите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < arr.GetLength(0))
    {
        Console.WriteLine($"Значение элемента = {arr[m, n]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует!");
    }
}

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Zadanie52()
{
    Random random = new Random();
    int m = random.Next(2,10);
    int n = random.Next(2,10);
    int[,] a = new int[m, n];
    double[] b = new double[n];

    FillArray(a);
    PrintArray(a);
    ArithmeticMean(a, b);
}

void ArithmeticMean(int[,] arr, double[] mass)
{
    Console.WriteLine();
    for (int i = 0, k = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        mass[k] = Math.Round(sum / arr.GetLength(0), 1);
        Console.Write(mass[k] + "\t");
        k++;
    }

    Console.WriteLine(" Среднее арифметическое каждого столбца");
}
Zadanie52();




//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 
//ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
void Zadanie41()
{
Console.WriteLine("Сколько чисел требуется ввести?");
int countOfNumbers = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] numbers = new int[countOfNumbers];
for(int i=1; i<=countOfNumbers; i++)
{
    Console.WriteLine($"Введите {i} число");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    numbers[i-1] = inputNumber;
    if (inputNumber > 0) count++;
}
Console.WriteLine($"Положительных чисел введено "+ count);
}


//Задача 43: Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//k1 = 5, b1 = 2, k2 = 9, b2 = 4,  -> (-0,5; -0,5)
void Zadanie43()
{
    Console.WriteLine($"Введите значение k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите значение b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите значение k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите значение b2");
    double b2 = Convert.ToDouble(Console.ReadLine());

    double x = Convert.ToDouble(b2-b1)/Convert.ToDouble(k1-k2);
    x  = Math.Round(x, 2);
    double y = k1 * x + b1;
    y  = Math.Round(y, 2);
    Console.WriteLine($"точка пересечения А {x}, {y}");
}


