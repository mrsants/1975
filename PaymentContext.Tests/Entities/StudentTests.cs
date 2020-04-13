using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var student = new Student("Test",
                                      "Tests",
                                      "1212454545",
                                      "teste@teste.com");

            student.AddSubscription(subscription);

        }
    }
}
