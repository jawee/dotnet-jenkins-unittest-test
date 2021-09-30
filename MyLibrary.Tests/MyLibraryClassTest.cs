using Xunit;
using MyLibrary;

namespace MyLibrary.Tests 
{
  public class MyLibraryTestClass
  {
    private readonly MyLibraryClass _myLibrary;

    public MyLibraryTestClass()
    {
      _myLibrary = new MyLibraryClass();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
    {
      var result = _myLibrary.IsPrime(value);

      Assert.False(result, "1 should not be prime");
    }
  }
}
