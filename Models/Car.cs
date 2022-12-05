using System;

namespace Dealership.Models
{

public class Car
{
  private string _makeModel;

  public string MakeModel
  {
	get 
	{
	  return _makeModel;
	}
	set
	{
	  _makeModel = value;
	}
  }

  private double _price;
  private int _miles;
  private bool _fourWheelDrive;

  public Car(string makeModel, double price, int miles, bool fourWheelDrive)
  {
	_makeModel = makeModel;
	_price = price;
	_miles = miles;
	_fourWheelDrive = fourWheelDrive;
  }

  public string GetMakeModel()
  {
	return _makeModel;
  }

  public double GetPrice()
  {
	return _price;
  }

  public int GetMiles()
  {
	return _miles;
  }

  public bool GetFWD()
  {
	return _fourWheelDrive;
  }

  public bool WorthBuying(int maxPrice)
  {
	return (_price <= maxPrice);
  }

  public void SetPrice(double newPrice)
  {
	_price = newPrice;
  }

  // public int SalePrice(double rate)
  // {
  //   double newPrice = _price - ( _price * rate);
  //   return newPrice;
  // }

  public double ResaleValue(int years)
    {

      double resalePrice = 0.00;
      for(int x = years; x > 0; x--)
      {
       resalePrice = _price - (_price * 0.05);
      }
      return resalePrice;
    }

  public static string MakeSound(string sound)
  {
	return "Our cars sound line" + sound;
  }
}
}

