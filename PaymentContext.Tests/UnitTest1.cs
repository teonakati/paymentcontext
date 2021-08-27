using System;
using PaymentContext.Domain.Entities;
using Xunit;

namespace PaymentContext.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddSubscription()
        {
            var subscription = new Subscription(DateTime.Today.AddDays(30));
            var student = new Student("Teo", "Nakati", "9398217893", "hello@nakati.com");
            student.AddSubscription(subscription);
        }
    }
}
