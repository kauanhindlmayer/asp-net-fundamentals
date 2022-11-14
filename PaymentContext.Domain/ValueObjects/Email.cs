namespace PaymentContext.Domain.valueObjects
{
  public class Email
  {
    public Email(string address)
    {
      Address = address;
    }

    public string Address { get; private set; }
  }
}