
Console.Clear();
Console.Write("Введите номер задачи 47, 50 или 52: ");
int number = int.Parse(Console.ReadLine());

if(number == 47){
    GetArrayDouble();
}
else if(number == 50){
    GetArray();
}
else if(number == 52){
    ArithmeticMeanOfColumns();
}
else if(number != 47 || number != 50 || number != 52){
    Console.WriteLine("Ошибка. Введите правильный номер задачи.");
}



/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5  7  -2 -0,2
1  -3,3  8 -9,9
8   7,8 -7,1  9 */

double[,] GetArrayDouble(){
Console.Clear();
Console.WriteLine("Задача 47. Задайте двумерный массив размером МхN, заполненный случайными вещественными числами.");
Console.WriteLine();
Console.WriteLine("Введите количество строк в массиве :");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве :");
int column = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[row, column];
Console.WriteLine("Полученный вещественный массив на основе ваших данных:");
for(int i = 0; i < row; i++){
    for(int j = 0; j < column; j++){
        array[i, j] = new Random().NextDouble();
        Console.Write($"| {array[i, j]} | ");
    }
    Console.WriteLine();
}
return array;
}


/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] GetArray()
{
    Console.Clear();
    Console.WriteLine("Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и выдает, что такого элемента нет");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк в массиве :");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве :");
    int column = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[row, column];
    Console.WriteLine("Полученный массив на основе ваших данных:");
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(10, 101);
            Console.Write($"| {array[i, j]} | ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Введите искомое число от 1 до 100: ");
    int find = Convert.ToInt32(Console.ReadLine());

    int countAbsent = 0;
    int countExists = 0;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (array[i, j] == find) countExists++;
            else countAbsent++;
        }
    }
    if(countExists > 0)
    {
        Console.WriteLine("Заданное число присутствует в массиве.");
    }
    else if(countAbsent > 0)
    {
       Console.WriteLine("Заданное число отсутствует в массиве.");
    }
    return array;
}

/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


void ArithmeticMeanOfColumns()
{
    Random rand = new Random();
    int rows = rand.Next(4, 5);
    int columns = rand.Next(4, 5);
    int[,] array = new int[rows, columns];
    FillArray(array, 1, 10);
    PrintArray(array);
    int columnCount = 0;
    double sumColumns = 0;
    double arithmeticMean = 0;
    Console.WriteLine();
    Console.WriteLine("Результат нахождения среднего арифметического:");
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumColumns += array[i, j];
            arithmeticMean = sumColumns / array.GetLength(0);

        }
        sumColumns *= 0;
        columnCount++;
        Console.WriteLine($"В столбце {columnCount} SrAr = " + Math.Round(arithmeticMean, 2));
    }
    Console.WriteLine();
}
void FillArray(int[,] array, int minValue, int maxValue)
{
    Random rand = new Random();
    minValue++;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.WriteLine("  Полученный массив:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"| {array[i, j]} | ");
        }
        Console.WriteLine();
    }

}
