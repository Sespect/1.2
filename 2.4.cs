using System;

class Program
{
  static void BubbleSort(int[] array, string[] months)
  {
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)
    {
      for (int j = 0; j < n - i - 1; j++)
      {
        if (array[j] > array[j + 1])
        {
      // Обмен значениями, если текущий элемент больше следующего
          int temp = array[j];
          array[j] = array[j + 1];
          array[j + 1] = temp;
         // Соответствующая перестановка в массиве месяцев
          string tempMonth = months[j];
          months[j] = months[j + 1];
          months[j + 1] = tempMonth;
        }
      }
    }
  }

  static void Main()
  {
   // Создаем двумерный массив temperature 12 на 30
    int[,] temperature = new int[12, 30];

    // Создаем генератор случайных чисел
    Random rnd = new Random();

    string[] months = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
    Console.Write("          "); 

    for (int day = 1; day <= 30; day++) 
    { 
      Console.Write($"{day,4}");
    } 
    Console.WriteLine(); 
      // Заполняем массив случайными значениями
    for (int i = 0; i < 12; i++)
    { 
      Console.Write($"{months[i],-10}");      
      for (int j = 0; j < 30; j++)
      {
        if (i >= 0 && i <= 1 || i == 11) // Зима
        {
          temperature[i, j] = rnd.Next(-30, -9);
        }
        else if (i >= 2 && i <= 4) // Весна
        {
          temperature[i, j] = rnd.Next(-10, 16);
        }
        else if (i >= 5 && i <= 7) // Лето
        {
          temperature[i, j] = rnd.Next(10, 31);
        }
        else if (i >= 8 && i <= 10) // Осень
        {
          temperature[i, j] = rnd.Next(-12, 16);
        }
        Console.Write($"{temperature[i, j],4}");
      }
        Console.WriteLine();
    } // Вычисляем и выводим неотсортированные средние значения

    Console.WriteLine("\nСредняя температура (неотсортированная):");  
    int[] averageTemperatures = new int[12];
    for (int i = 0; i < 12; i++)
    {
      int sum = 0;
      for (int j = 0; j < 30; j++)
      {
        sum += temperature[i, j];
      }
      averageTemperatures[i] = sum / 30;
    }
    for (int i = 0; i < 12; i++)
    {
      Console.WriteLine($"{months[i]}: {averageTemperatures[i]}");
    }
     // Сортируем средние температуры по возрастанию методом пузырька
    BubbleSort(averageTemperatures, months);
     // Выводим отсортированные средние температуры
    Console.WriteLine("\nОтсортированные средние температуры по возрастанию:");
    for (int i = 0; i < 12; i++)
    {
      Console.WriteLine($"{months[i]}: {averageTemperatures[i]}");
    }
  }
}