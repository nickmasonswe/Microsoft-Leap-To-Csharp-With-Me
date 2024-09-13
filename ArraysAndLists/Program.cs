/* 
*** To use lists, we need to add:
using System.Collections.Generic; ***

//Arrays and Lists
we can initialize an array that has a length of 3 without specifying what those values are, then later go back and edit the array to include a new value. This is useful if we know how many things we’re expecting, but we don’t know their specific values yet:

// plantHeights will be equal to [0, 0, 0]
int[] plantHeights = new int[3]; 

// plantHeights will now be [0, 0, 8]
plantHeights[2] = 8; 

(When using on an array) IndexOf() typically takes 2 parameters: the first is the array and the second is the value whose index we’re looking for. IndexOf() also has several overloads that allow you to search for a specific range of the array. 

Initializing and Adding to a list:
List<string> citiesList = new List<string>();
citiesList.Add("Delhi");
citiesList.Add("Los Angeles");

We can do it all in one line using object initialization:

List<string> citiesList2 = new List<string> { "Delhi", "Los Angeles" };

    Basic construction uses parentheses ( ) and no values.
    Object initialization uses curly braces { } and the actual values go in-between.

Contains, Add, Remove are common methods. Clear method removes all from list. 

foreach is standalone ie foreach (number in numberArray) ... 

four common range-related methods:

    AddRange() — takes an array or list as an argument. Adds the values to the end of the list. Returns nothing.

    InsertRange() — takes an int and array or list as an argument. Adds the values at the int index. Returns nothing.

    RemoveRange() — takes two int values. The first int is the index at which to begin removing, and the second int is the number of elements to remove. Returns nothing.

    GetRange() — takes two int values. The first int is the index of the first desired element, and the second int is the number of elements in the desired range. Returns a list of the same type.

    List<string> places = new List<string> { "first", "second" };

places.AddRange(new string[] { "fifth", "sixth" });
// List is  "first", "second", "fifth", "sixth" ]
places.InsertRange(2, new string[] { "third", "fourth"});
// List is [ "first", "second", "third", "fourth", "fifth", "sixth" ]
places.RemoveRange(4, 2);
// List is [ "first", "second", "third", "fourth" ]
List<string> newPlaces = places.GetRange(0, 3);
// New list is [ "first", "second", "third" ]


Type Safety: In C#, once you define the type (like List<string>), you can't add anything that isn't a string to that list. This is different from JavaScript/TypeScript, where arrays can hold mixed types unless explicitly typed.

Example in TypeScript:

typescript

let mixedList: (number | string)[] = [1, "two"];

In C#, you would need to define the list with List<Object> if you want to store mixed types.


 */
using System;
using System.Collections.Generic;

namespace messingAroundWithGenerics
{
  class Program
  {
    static void Main()
    {
      // A list, or List<T>, is a generic, sequential data structure. The specific type that it contains is specified upon instantiation
      List<bool> bools = new List<bool>();
      List<Random> randoms = new List<Random>();
      List<IServiceProvider> i = new List<IServiceProvider>();
      //object initialization for List<T> objects
      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
    }
  }
}
