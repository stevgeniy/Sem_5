// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int arrayLength = GetNumberFromUser("Введите длину нового Массива: ", "Ошибка ввода!");
double[] arrayRandom = new double [arrayLength];
FillArray(arrayRandom);
Console.WriteLine($"Max - Min  в массиве [{String.Join("; ", arrayRandom)}]-> {DeltaMaxMin(arrayRandom)}");


/////////////////////////////   Методы:  //////////////////////////
double DeltaMaxMin(double[] deltaArray)
{
   double result = 0;
   int length = deltaArray.Length;
   double Max = deltaArray[0];
   double Min = deltaArray[0];
   for (int j = 1; j < length; j++)
   {  
      if (deltaArray[j]>Max) Max = deltaArray[j];
      else if (deltaArray[j]<Min) Min = deltaArray[j];
   }
   result = Max - Min;
   return result;
}

void FillArray(double[] array2)
{
    int length = array2.Length;
   for (int i = 0; i < length; i++)
   {      
      array2[i] = new Random().Next(0, 1000);
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
