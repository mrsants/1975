using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _payments;
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool Active { get; set; }
        public string Address { get; set; }
        public IReadOnlyCollection<Payment> Payments { get; set; }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }
        public void Activate(Payment payment)
        {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }

        public void Inactivate(Payment payment)
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }

    }
}