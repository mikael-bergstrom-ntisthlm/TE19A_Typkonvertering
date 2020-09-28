using System;

namespace Typkonv
{
  class Program
  {
    static void Main(string[] args)
    {


      string t = Console.ReadLine();

      int k = 0;

      bool result = int.TryParse(t, out k);

      if (result == false) {
        Console.WriteLine("O NOES");
      }

      // try
      // {
      //   k = int.Parse(t);
      // }
      // catch
      // {
      //   Console.WriteLine("O NOES");
      // }

      Console.WriteLine(k + k);

      Console.ReadLine();
    }
  }
}
