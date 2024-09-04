/* 
    implicit conversion: happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.

    explicit conversion: requires a cast operator to convert a data type into another one. If we do want to convert a double to an int, we could use the operator (int).

    Example of Type casting:
    double positiveDouble = 3.75
    double negativeDouble = -3.75;

    // casting double to int truncates the decimal portion
    int positiveInt = (int)positiveDouble; // 3
    int negativeInt = (int)negativeDouble; // -3

    It’s also possible to convert data types using built-in methods. For most data types, there is a Convert.ToX() method, like Convert.ToString() and Convert.ToDouble()

*/

//Can't implictly change string to number, so must use Convert method.
using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter your favorite number!: ");
      int faveNumber = Convert.ToInt32(Console.ReadLine());
    }
  }
}
