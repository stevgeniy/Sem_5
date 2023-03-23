// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int arrayLength = GetNumberFromUser("Введите длину нового Массива: ", "Ошибка ввода!");
int[] arrayRandom = new int [arrayLength];
FillArray(arrayRandom);
Console.WriteLine($"Сумма НЕчетных элементов массива [{String.Join("; ", arrayRandom)}]-> {Sum2array(arrayRandom)}");


/////////////////////////////   Методы:  //////////////////////////
int Sum2array(int[] arraySum)
{
   int length = arraySum.Length;
   int sum = 0;
   for (int j = 1; j < length; j+=2)
   {  
        sum += arraySum[j];
   }
   return sum;
}

void FillArray(int[] array2)
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
        if (isCorrect && usernamber >= 0)
        {
            return usernamber;
        }  
        Console.WriteLine(errorMessage);

    }
    
}