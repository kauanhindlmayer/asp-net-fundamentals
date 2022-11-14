namespace PaymentContext.Domain.valueObjects
{
  public class Name
  {
    public Name(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
  }
}