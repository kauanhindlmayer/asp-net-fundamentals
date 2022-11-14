using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
  [TestClass]
  public class StudentTests
  {
    [TestMethod]
    public void AdicionarAssinatura()
    {
      var subscription = new Subscription(null);
      var student = new Student("Kauan", "Hindlmayer", "000.000.000-00", "kauan.h@gmail.com");
      student.AddSubscription(subscription);
    }
  }
}