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

    when two different numerical types are used with an arithmetic operator, the result will always be of the type that is more precise. So if we use an int with a double, the result will be a double.

Let’s look at the following example:

Console.WriteLine(5 / 3);
Console.WriteLine(5 / 3.0);

// Prints 1
// Prints 1.66667

The first operation that we log uses two ints. While 3 doesn’t go into 5 evenly, we are still left with an int as the result. Note that with integer division, any decimal portion of the result is truncated, not rounded.

In the second operation, we use an int and a double, so the final result is a double, as double is more precise than int.

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
