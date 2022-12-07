using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void AdicionaAssinatura()
    {
        var subscription = new Subscription(null);
        var student = new Student("Richard", "Kendy", "12345678910", "richard@email.com");
        student.AddSubscription(subscription);
    }
}
