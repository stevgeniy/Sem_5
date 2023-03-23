int arrayLength = GetNumberFromUser("Введите длину нового Массива: ", "Ошибка ввода!");
int[] arrayRandom = new int [arrayLength];
FillArray(arrayRandom);
Console.WriteLine($"Внутри массива [{String.Join("; ", arrayRandom)}]-> {Chek2array(arrayRandom)} четных числа");


/////////////////////////////   Методы:  //////////////////////////
int Chek2array(int[] arrayChek)
{
   int length = arrayChek.Length;
   int count = 0;
   for (int j = 0; j < length; j++)
   {  
     if (arrayChek[j]%2 == 0)
     {
        count++;
     }
   }
   return count;
}

void FillArray(int[] array2)
{
    int length = array2.Length;
   for (int i = 0; i < length; i++)
   {      
      array2[i] = new Random().Next(99, 1000);
   }
}


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int usernamber);
        if (isCorrect && usernamber >= 0)
        {
            return usernamber;
        }  
        Console.WriteLine(errorMessage);

    }
    
}


