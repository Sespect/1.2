using System;
using System.Collections.Generic;

class Program
{   
  static Dictionary<string, double> CalculateAverageTemperatures(Dictionary<string, int[]> dictionaryTemperatures)
  {
    Dictionary<string, double> averageTemperatures = new Dictionary<string, double>();
    foreach (var t in dictionaryTemperatures)
    {
      string month = t.Key;
      int[] temperatures = t.Value;
      int sum = 0;
      foreach (int temperature in temperatures)
      {
        sum += temperature;
      }
       int averageTemperature = sum / temperatures.Length;
      averageTemperatures.Add(month, averageTemperature);
    }
    return averageTemperatures;
  }
  static void Main() 
  {      
    Dictionary<string, int[]> dictionaryTemperatures = new Dictionary<string, int[]>();    
    Random rnd = new Random(); 
    string[] months = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
    Console.Write("          "); 

    for (int day = 1; day <= 30; day++) 
    { 
      Console.Write($"{day,4}");
    } 
    Console.WriteLine(); 

    for (int i = 0; i < 12; i++)    
    {     
      Console.Write($"{months[i],-10}");

      int[] monthTemperatures = new int[30];      
      for (int j = 0; j < 30; j++)     
      {           
        if (i >= 0 && i <= 1 || i == 11) // Зима          
        {        
          monthTemperatures[j] = rnd.Next(-30, -9);
        }              
        else if (i >= 2 && i <= 4) // Весна            
        {           
          monthTemperatures[j] = rnd.Next(-10, 16);     
        }        
        else if (i >= 5 && i <= 7) // Лето     
        {         
          monthTemperatures[j] = rnd.Next(10, 31);     
        }     
        else if (i >= 8 && i <= 10) // Осень   
        {         
          monthTemperatures[j] = rnd.Next(-12, 16);       
        }
        Console.Write($"{monthTemperatures[j],4}");
      }
      Console.WriteLine();

      dictionaryTemperatures.Add(months[i], monthTemperatures);
    }
    Console.WriteLine("\nСредняя температура:");

    Dictionary<string, double> averageTemperatures = CalculateAverageTemperatures(dictionaryTemperatures);
    foreach (var t in averageTemperatures)
    {
      Console.WriteLine($"{t.Key}: {t.Value}");
    }
  }
}