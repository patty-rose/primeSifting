using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace Primesifting.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string stringNum = Console.ReadLine();
      int number = int.Parse(stringNum);
      List<int> numberList = CreateNumberList(number);

      Console.WriteLine("Here's your list:");
      for (int i = 0; i < numberList.Count; i++)
      {
        Console.WriteLine(numberList[i]);
      }

      List<int> parsedList = ParseNumberList(numberList);

      Console.WriteLine("Here's your list of prime numbers:");
      for (int i = 0; i < parsedList.Count; i++) {
        Console.WriteLine(parsedList[i]);
      }

    }

    public static List<int> CreateNumberList(int number)
    {
      List<int> listOfNumbers = new List<int> {};
      for(int index = 2; index <= number; index++)
      {
        listOfNumbers.Add(index);
      }
      return listOfNumbers;
    }

    public static List<int> ParseNumberList(List<int> numberList)
    {
      //i =2 i <= 10 xx
      //itterate through list j=0 xx
      //if j / i % === 0 
      //remove j from list
      // {2, 3, 4, 5, 6, 7, 8, 9, 10}
      // List<int> parsedList = new List<int> {};

      for (int i = 2; i <= 10; i++) {
        for (int index = 0; index < numberList.Count; index++) {
          if (numberList[index] != i){
            if (numberList[index] % i == 0) {
              numberList.Remove(numberList[index]);
            }
          }
        }
      } return numberList;

    }
  }
}