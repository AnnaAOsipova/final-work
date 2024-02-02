// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

 Console.WriteLine("Введите элементы массива через пробел:");
 string input = Console.ReadLine();
 string[] inputArray = input.Split(' ');

int count = 0;
for (int i = 0; i < inputArray.Length; i++)
  {
      if (inputArray[i].Length <= 3)
        {
           count++;
           }
      }

      string[] resultArray = new string[count];
       int index = 0;
  for (int i = 0; i < inputArray.Length; i++)
      {
           if (inputArray[i].Length <= 3)
           {
               resultArray[index] = inputArray[i];
                index++;
           }
         }  
 Console.WriteLine("Новый массив из строк, длина элементов которых не более 3:");
 for (int i = 0; i < resultArray.Length-1; i++)
 {
 Console.Write(resultArray[i] + ",");
 }
 Console.Write(resultArray[resultArray.Length-1]);
