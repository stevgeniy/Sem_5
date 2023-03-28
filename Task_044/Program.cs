// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
int num = GetNumberFromUser("Введите целое положительное число N: ", "Ошибка ввода!");
int[] arrayFibon = GetFibonNambers(num);
Console.WriteLine($"{num} -> {String.Join(" ", arrayFibon)}");
//////////////////////////////////////////////////////////////////////////////////
// Запрашивает у пользователя целые числа
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}
//
int[] GetFibonNambers(int a)
{
    int[] result = new int[a];
    result[1] = 1;
    for (int i = 2; i < a; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}