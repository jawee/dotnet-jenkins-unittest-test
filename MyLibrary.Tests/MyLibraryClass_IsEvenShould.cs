using System;
using MyLibrary;
using Xunit;

namespace MyLibrary.Test 
{
  public class MyLibraryClass_IsEvenShould
  {
    private readonly MyLibraryClass _myLibrary;

    public MyLibraryClass_IsEvenShould()
    {
      _myLibrary = new MyLibraryClass();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsEven_Ones_ReturnFalse(int value)
    {
      var result = _myLibrary.IsEven(value);

      Assert.False(result, $"{value} should not be even");
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    public void IsEven_ValuesLessThan5_ReturnTrue(int value)
    {
      var result = _myLibrary.IsEven(value);

      Assert.True(result, $"{value} should be even");
    }

    [Theory]
    [InlineData(-2)]
    [InlineData(-4)]
    public void IsEven_Negative_ReturnTrue(int value)
    {
      var result = _myLibrary.IsEven(value);

      Assert.True(result, $"{value} should be even");
    }

    [Theory]
    [InlineData(10)]
    public void IsEven_Ten_ReturnTrue(int value)
    {
      var result = _myLibrary.IsEven(value);

      Assert.True(result, $"{value} should be even");
    }
  }
}
