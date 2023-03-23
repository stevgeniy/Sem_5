int arrayLength = GetNumberFromUser("Введите длину нового Массива: ", "Ошибка ввода!");
int[] arrayUser = new int [arrayLength];
FillArray(arrayUser);
Console.WriteLine($"[{String.Join("; ", arrayUser)}]");

/////////////////////////////ввод массива 


void FillArray(int[] array2)
{
    int length = array2.Length;
   for (int i = 0; i < length; i++)
   {      
      array2[i] = GetNumberFromUser($"Введите {i} элемент Массива: ", "Ошибка ввода!");
   }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    Console.Write("[");
   for (int i = 0; i < length; i++)
   {
      Console.Write($"{array[i]}");
      if (i < length - 1)
      {
        Console.Write(", ");
      }
   }
    Console.Write("]");
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


