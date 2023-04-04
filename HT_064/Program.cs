int a = GetNumberFromUser("Введите натуральное число N: ","Ошибка ввода");

//string result = GetNumbersFromMToN(b,a);

Console.WriteLine($"{a} -> 1 : {GetNumbersFromMToN(a)}");

static string GetNumbersFromMToN(int fromNumber)
{ 
    if (fromNumber > 1)
         return fromNumber + ", " + GetNumbersFromMToN(fromNumber - 1);
    else   
        return fromNumber.ToString();            
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
