// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
Console.Clear();
int A = GetNumberFromUser("Введите длинну 1 стороны: ", "Ошибка ввода!");
int B = GetNumberFromUser("Введите длинну 2 стороны: ", "Ошибка ввода!");
int C = GetNumberFromUser("Введите длинyу 3 стороны: ", "Ошибка ввода!");
bool isTringle = IsTringle(A, B, C);
Console.WriteLine(isTringle? "Да" : "Нет");
//////////////////////////////////////////////////////////////////////////////////
// Запрашивает у пользователя целые числа
int GetNumberFromUser(string message, string errorMessage)
{
while(true)
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

bool IsTringle(int a, int b, int c)
{
    return(a + b > c && b + c > a && a + c > b);
}