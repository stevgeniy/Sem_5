// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int arrayLength = GetNumberFromUser("Введите длину нового Массива: ", "Ошибка ввода!");
int[] arrayRandom = new int [arrayLength];
FillArray(arrayRandom);
Console.WriteLine($"Положительных чисел в массиве [{String.Join("; ", arrayRandom)}]-> {PositivChek(arrayRandom)}");


/////////////////////////////   Методы:  //////////////////////////
int PositivChek(int[] userArr)
{
   int count = 0;
   int length = userArr.Length;
   
   for (int j = 0; j < length; j++)
   {  
      if (userArr[j]>0) count++;
   }
   return count;
}

void FillArray(int[] array2)
{
    int length = array2.Length;
   for (int i = 0; i < length; i++)
   {      
      array2[i] = GetNumberFromUser($"Введите {i} элемент Массива: ", "Ошибка ввода!");
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
