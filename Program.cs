using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{

  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, true);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, false);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, false);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, true);
      double salePrice;

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      yugo.SetPrice(300);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
          salePrice = automobile.GetPrice() * .75;
          Console.WriteLine("$" + salePrice);
        }
      }

      foreach (Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("--------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
      }

      foreach (Car automobile in Cars)
      {
        Console.WriteLine("--------------------");
        if (automobile.GetFWD())
        {
          Console.WriteLine(automobile.GetMakeModel() + ": This car would do well in the Dakar Rally");
        }
        else
        {
          Console.WriteLine(automobile.GetMakeModel() + ": This car would NOT do well in the Dakar Rally");
        }
      }
      

      Console.WriteLine("Check for resale value, Enter number of years from now: ");
      int years = Int32.Parse(Console.ReadLine());
      foreach (Car automobile in Cars)
      {
        Console.WriteLine("The resale value for {0} is {1}", automobile.GetMakeModel(), automobile.ResaleValue(years));
      }
    }
  }
}