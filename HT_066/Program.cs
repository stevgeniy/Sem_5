int a = GetNumberFromUser("Введите натуральное число N: ","Ошибка ввода");
int b = GetNumberFromUser("Введите натуральное число M: ","Ошибка ввода");

//string result = GetNumbersFromMToN(b,a);

Console.WriteLine($"{b} -> {a} : {SummaNumber(a,b)}");

static int SummaNumber(int fromNumber, int toNumber)
{ 
    if (fromNumber < toNumber)
         {
            return fromNumber + SummaNumber(fromNumber + 1, toNumber);
         }
    if (fromNumber > toNumber)
         {
            return toNumber + SummaNumber(toNumber + 1, fromNumber);
         }
    else   
    {    
        return toNumber;    
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

