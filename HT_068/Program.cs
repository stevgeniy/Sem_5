int a = GetNumberFromUser("Введите натуральное число M: ","Ошибка ввода");
int b = GetNumberFromUser("Введите натуральное число N: ","Ошибка ввода");


Console.WriteLine($"Функция Аккермана для чисел ({a},{b}) = {AckermannFunction(a, b)}");


////Метод 

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
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

