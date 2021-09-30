using Xunit;
using MyLibrary;

namespace MyLibrary.Tests 
{
  public class MyLibraryTestClass
  {
    [Fact]
    public void IsPrime_InputIs1_ReturnFalse()
    {
      var myLibrary = new MyLibraryClass();
      var result = myLibrary.IsPrime(1);

      Assert.False(result, "1 should not be prime");
    }
  }
}
