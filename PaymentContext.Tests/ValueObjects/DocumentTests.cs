using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using Flunt.Validations;

namespace PaymentContext.Tests
{
  [TestClass]
  public class DocumentTests
  {
    // Red, Green, Refactor
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
      var doc = new Document("123", EDocumentType.CNPJ);
      // Assert.IsTrue(doc.Invalid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
      var doc = new Document("34110468000150", EDocumentType.CNPJ);
      // Assert.IsTrue(doc.Valid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
      var doc = new Document("123", EDocumentType.CNPJ);
      // Assert.IsTrue(doc.Invalid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
      var doc = new Document("34225545806", EDocumentType.CNPJ);
      // Assert.IsFalse(doc.Valid);
    }
  }
}