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

    //ints and doubles
    when two different numerical types are used with an arithmetic operator, the result will always be of the type that is more precise. So if we use an int with a double, the result will be a double.

example:

Console.WriteLine(5 / 3);
Console.WriteLine(5 / 3.0);

// Prints 1
// Prints 1.66667

The first operation that we log uses two ints. While 3 doesn’t go into 5 evenly, we are still left with an int as the result. Note that with integer division, any decimal portion of the result is truncated, not rounded.

In the second operation, we use an int and a double, so the final result is a double, as double is more precise than int.

//Strings
If we want to concatenate a string with something that is another data type, C# will implicitly convert that value to a string. 

Note also that while in JS, .length() is a method, in C#, .Length is a property, no parnethesis needed.

//Arrays and Lists
we can initialize an array that has a length of 3 without specifying what those values are, then later go back and edit the array to include a new value. This is useful if we know how many things we’re expecting, but we don’t know their specific values yet:

// plantHeights will be equal to [0, 0, 0]
int[] plantHeights = new int[3]; 

// plantHeights will now be [0, 0, 8]
plantHeights[2] = 8; 

(When using on an array) IndexOf() typically takes 2 parameters: the first is the array and the second is the value whose index we’re looking for. IndexOf() also has several overloads that allow you to search for a specific range of the array. 
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
