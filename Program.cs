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

Zadanie43();

