using System;

namespace MyLibrary
{
    public class MyLibraryClass
    {

      public MyLibraryClass()
      {
      }

      public bool IsPrime(int candidate) 
      {
        if(candidate < 2)
        {
          return false;
        }

        for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
        {
          if(candidate % divisor == 0)
          {
            return false;
          }
        }
        return true;
      }

      public bool IsEven(int candidate)
      {
        return candidate % 2 == 0;
      }
    }
}
