/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */
Console.Clear();
int num = GetNumberFromUser("Введите целое положительное число: ", "Ошибка ввода!");
int[] resultBin = GetDecToBin(num);
Console.WriteLine($"{num} -> {String.Join("", resultBin)}");
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
int[] GetDecToBin(int a)
{
    int temp = a;
    int count = 0;
    while (temp > 0)
    {
        temp /= 2;
        count++;
    }
    int[] result = new int[count];
    for (int i = count - 1; i >= 0; i--)
    {
        result[i] = a % 2;
        a /= 2;
    }
    return result;

}

