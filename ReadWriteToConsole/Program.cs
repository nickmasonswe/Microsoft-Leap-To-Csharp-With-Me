// comments like js/ts
/* Multi line comment as such */
//Writing and Reading input via console
using System;
namespace GettingInput
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What\'s your name?");
      string input = Console.ReadLine();
      Console.WriteLine($" Hi, {input}!");
    }
  }
}
