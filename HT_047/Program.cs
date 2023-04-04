/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int stroki = GetNumberFromUser("Введите число строк: ","Ошибка ввода");

int stolbcy = GetNumberFromUser("Введите число строк: ","Ошибка ввода");

double [,] array = GetArray(stroki, stolbcy);
Console.WriteLine("Массив случайных вещественных чисел: \n");
PrintArray(array);


/// массив
double [,] GetArray(int stroki, int stolbcy)
{
    double [,] array = new double[stroki, stolbcy];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.NextDouble() * (10 + 10) - 10;
                }
            }
    return array;
}

/// Метод печати массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,8}", Math.Round(array[i, j], 1));
        }
        Console.WriteLine();
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int usernamber);
        if (isCorrect)
        {
            return usernamber;
        }  
        Console.WriteLine(errorMessage);

    }
    
}

